﻿// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Silk.NET.Core;
using Silk.NET.Core.Contexts;
using Silk.NET.GLFW;
using Silk.NET.Windowing.Internals;

namespace Silk.NET.Windowing.Glfw
{
    internal unsafe class GlfwWindow : WindowImplementationBase, IGLContext, IVkSurface
    {
        private readonly GLFW.Glfw _glfw;
        private WindowHandle* _glfwWindow;
        private string _localTitleCache; // glfw doesn't let us get the window title.
        private readonly GlfwWindow? _parent;
        private readonly GlfwMonitor? _initialMonitor;
        
        // Callbacks
        private GlfwCallbacks.WindowPosCallback? _onMove;
        private GlfwCallbacks.WindowSizeCallback? _onResize;
        private GlfwCallbacks.FramebufferSizeCallback? _onFramebufferResize;
        private GlfwCallbacks.DropCallback? _onFileDrop;
        private GlfwCallbacks.WindowCloseCallback? _onClosing;
        private GlfwCallbacks.WindowFocusCallback? _onFocusChanged;
        private GlfwCallbacks.WindowIconifyCallback? _onMinimized;
        private GlfwCallbacks.WindowMaximizeCallback? _onMaximized;

        public GlfwWindow(WindowOptions optionsCache, GlfwWindow? parent, GlfwMonitor? monitor) : base(optionsCache)
        {
            _glfw = GlfwProvider.GLFW.Value;
            _parent = parent;
            _initialMonitor = monitor;
            _localTitleCache = optionsCache.Title;
        }

        protected override Size CoreSize
        {
            get
            {
                _glfw.GetWindowSize(_glfwWindow, out var width, out var height);
                return new Size(width, height);
            }
        }

        protected override IntPtr CoreHandle => (IntPtr) _glfwWindow;

        protected override void CoreReset()
        {
            if (_glfwWindow == null)
            {
                return;
            }
            
            try
            {
                _glfw.DestroyWindow(_glfwWindow);
                GLFW.Glfw.ThrowExceptions();
                _glfwWindow = null;
            }
            catch (GlfwException)
            {
                // If the window is already destroyed, it throws an exception,
                // but we want the window destroyed anyways, so just ignore it
            }
        }

        public override IGLContext? GLContext
            => API.API == ContextAPI.OpenGL || API.API == ContextAPI.OpenGLES ? this : null;

        public override IVkSurface? VkSurface => API.API == ContextAPI.Vulkan && _glfw.VulkanSupported() ? this : null;
        protected override bool CoreIsVisible
        {
            get => _glfw.GetWindowAttrib(_glfwWindow, WindowAttributeGetter.Visible);
            set
            {
                if (value)
                {
                    _glfw.ShowWindow(_glfwWindow);
                }
                else
                {
                    _glfw.HideWindow(_glfwWindow);
                }
            }
        }

        protected override Point CorePosition
        {
            get
            {
                _glfw.GetWindowPos(_glfwWindow, out var x, out var y);
                return new Point(x, y);
            }
            set => _glfw.SetWindowPos(_glfwWindow, value.X, value.Y);
        }

        protected override string CoreTitle
        {
            get => _localTitleCache;
            set => _glfw.SetWindowTitle(_glfwWindow, _localTitleCache = value);
        }
        protected override WindowState CoreWindowState { get; set; }
        protected override WindowBorder CoreWindowBorder { get; set; }

        protected override bool IsClosingSettable
        {
            set => _glfw.SetWindowShouldClose(_glfwWindow, value);
        }

        protected override Size SizeSettable
        {
            set => _glfw.SetWindowSize(_glfwWindow, value.Width, value.Height);
        }

        protected override void CoreInitialize(WindowOptions opts)
        {
            if (opts.API.API == ContextAPI.Vulkan && !_glfw.VulkanSupported())
            {
                throw new InvalidOperationException
                (
                    "Attempted to initialize a Vulkan window using GLFW, which doesn't support Vulkan on this computer."
                );
            }
            
            // Set window border.
            switch (opts.WindowBorder)
            {
                case WindowBorder.Hidden:
                    _glfw.WindowHint(WindowHintBool.Decorated, false);
                    _glfw.WindowHint(WindowHintBool.Resizable, false);
                    break;

                case WindowBorder.Resizable:
                    _glfw.WindowHint(WindowHintBool.Decorated, true);
                    _glfw.WindowHint(WindowHintBool.Resizable, true);
                    break;

                case WindowBorder.Fixed:
                    _glfw.WindowHint(WindowHintBool.Decorated, true);
                    _glfw.WindowHint(WindowHintBool.Resizable, false);
                    break;
            }

            // Set window API.
            switch (opts.API.API)
            {
                case ContextAPI.None:
                case ContextAPI.Vulkan:
                    _glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.NoApi);
                    break;
                case ContextAPI.OpenGL:
                    _glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.OpenGL);
                    break;
                case ContextAPI.OpenGLES:
                    _glfw.WindowHint(WindowHintClientApi.ClientApi, ClientApi.OpenGLES);
                    break;
            }

            _glfw.WindowHint(WindowHintBool.Visible, opts.IsVisible);

            // Set API version.
            _glfw.WindowHint(WindowHintInt.ContextVersionMajor, opts.API.Version.MajorVersion);
            _glfw.WindowHint(WindowHintInt.ContextVersionMinor, opts.API.Version.MinorVersion);

            // Set API flags
            if ((opts.API.Flags & ContextFlags.ForwardCompatible) != 0)
            {
                _glfw.WindowHint(WindowHintBool.OpenGLForwardCompat, true);
            }

            if ((opts.API.Flags & ContextFlags.Debug) != 0)
            {
                _glfw.WindowHint(WindowHintBool.OpenGLDebugContext, true);
            }

            // Set API profile
            _glfw.WindowHint
            (
                WindowHintOpenGlProfile.OpenGlProfile,
                opts.API.Profile == ContextProfile.Core ? OpenGlProfile.Core : OpenGlProfile.Compat
            );

            // Set video mode (-1 = don't care)
            _glfw.WindowHint(WindowHintInt.RefreshRate, opts.VideoMode.RefreshRate ?? -1);
            _glfw.WindowHint(WindowHintInt.DepthBits, opts.PreferredDepthBufferBits ?? -1);

            // Set transparent framebuffer
            _glfw.WindowHint(WindowHintBool.TransparentFramebuffer, opts.TransparentFramebuffer);

            // Create window
            _glfwWindow = _glfw.CreateWindow
            (
                opts.Size.Width, opts.Size.Height, opts.Title,
                !(_initialMonitor is null) ? _initialMonitor.Handle : null,
                null
            );

            if (opts.API.API == ContextAPI.OpenGL || opts.API.API == ContextAPI.OpenGLES)
            {
                _glfw.MakeContextCurrent(_glfwWindow);
            }

            GLFW.Glfw.ThrowExceptions();
        }

        public override event Action<Point>? Move;
        public override event Action<WindowState>? StateChanged;
        public override event Action<string[]>? FileDrop;
        public override void SetWindowIcon(ReadOnlySpan<RawImage> icons)
        {
            if (!IsInitialized)
            {
                throw new InvalidOperationException("Window should be initialized.");
            }

            if (icons == null)
            {
                _glfw.SetWindowIcon(_glfwWindow, 0, null);
            }
            else
            {
                var images = stackalloc Image[icons.Length];
                for (var i = 0; i < icons.Length; i++)
                {
                    var icon = icons[i];
                    // ReSharper disable once StackAllocInsideLoop
                    var iconMemory = stackalloc byte[icon.Pixels.Length];
                    images[i] = new Image
                    {
                        Width = icon.Width, Height = icon.Height,
                        Pixels = iconMemory
                    };

                    for (var j = 0; j < icon.Pixels.Length; j++)
                    {
                        iconMemory[j] = icon.Pixels[j];
                    }
                }

                _glfw.SetWindowIcon(_glfwWindow, icons.Length, images);
                GLFW.Glfw.ThrowExceptions();
            }
        }

        public override IWindow CreateWindow(WindowOptions opts) => new GlfwWindow(opts, this, null);

        public override IWindowHost? Parent => (IWindowHost?)_parent ?? Monitor;
        public override IMonitor? Monitor
        {
            get
            {
                if (!IsInitialized)
                {
                    return _initialMonitor;
                }

                var monitor = _glfw.GetWindowMonitor(_glfwWindow);
                if (monitor == null)
                {
                    if (WindowState != WindowState.Fullscreen)
                    {
                        var monitors = new GlfwMonitorEnumerable();
                        // Determine which monitor this window is on. [6 marks]
                        foreach (var m in monitors)
                        {
                            var pos = Position;
                            var size = Size;
                            if (m.Bounds.Contains(new Point(pos.X + size.Width / 2, pos.Y + size.Height / 2)))
                            {
                                return m;
                            }
                        }
                    }

                    monitor = _glfw.GetPrimaryMonitor();
                }

                return monitor == null
                    ? null
                    : new GlfwMonitor
                    (
                        monitor,
                        IndexOf(_glfw.GetMonitors(out var count), monitor, count)
                    );
            }
            set
            {
                if (!IsInitialized)
                {
                    throw new InvalidOperationException("Window is not running.");
                }

                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                if (WindowState == WindowState.Fullscreen)
                {
                    var h = ((GlfwMonitor) value).Handle;
                    var vidMode = value.VideoMode;
                    var resolution = vidMode.Resolution;
                    if (!resolution.HasValue)
                    {
                        throw new InvalidOperationException("Monitor resolution not found.");
                    }

                    if (!vidMode.RefreshRate.HasValue)
                    {
                        throw new InvalidOperationException("Monitor refresh rate not found.");
                    }

                    _glfw.SetWindowMonitor
                    (
                        _glfwWindow, h, 0, 0, resolution.Value.Width, resolution.Value.Height, vidMode.RefreshRate.Value
                    );
                    GLFW.Glfw.ThrowExceptions();
                }
                else
                {
                    Position = value.Bounds.Location;
                }
            }
        }

        private static int IndexOf<T>(T** array, T* target, int count)
            where T : unmanaged
        {
            for (var i = 0; i < count; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }
        public override bool IsClosing => _glfw.WindowShouldClose(_glfwWindow);

        public override VideoMode VideoMode
            => IsInitialized ? CachedVideoMode = Monitor?.VideoMode ?? CachedVideoMode : CachedVideoMode;
        public override bool IsEventDriven { get; set; }

        public override Size FramebufferSize
        {
            get
            {
                _glfw.GetFramebufferSize(_glfwWindow, out var width, out var height);
                return new Size(width, height);
            }
        }

        public override void DoEvents()
        {
            if (IsEventDriven)
            {
                _glfw.WaitEvents();
            }
            else
            {
                _glfw.PollEvents();
            }
        }
        public override void ContinueEvents() => _glfw.PostEmptyEvent();

        public override void Dispose()
        {
            CoreReset();
            GC.SuppressFinalize(this);
        }

        public IntPtr GetProcAddress(string proc) => _glfw.GetProcAddress(proc);

        public override void Close()
        {
            Closing?.Invoke();
            IsClosingSettable = true;
        }

        protected override void RegisterCallbacks()
        {
            _onMove = (window, x, y) =>
            {
                var point = new Point(x, y);
                UpdatePosition(point);
                Move?.Invoke(point);
            };

            _onResize = (window, width, height) =>
            {
                var size = new Size(width, height);
                UpdateSize(size);
                Resize?.Invoke(size);
            };

            _onFramebufferResize = (window, width, height) =>
            {
                FramebufferResize?.Invoke(new Size(width, height));
            };

            _onClosing = window => Closing?.Invoke();

            _onFocusChanged = (window, isFocused) => FocusChanged?.Invoke(isFocused);

            _onMinimized = (window, isMinimized) =>
            {
                WindowState state;
                // If minimized, we immediately know what value the new WindowState is.
                if (isMinimized)
                {
                    state = WindowState.Minimized;
                }
                else
                {
                    // Otherwise, we have to querry a few things to figure out out.
                    if (_glfw.GetWindowAttrib(_glfwWindow, WindowAttributeGetter.Maximized))
                    {
                        state = WindowState.Maximized;
                    }
                    else if (_glfw.GetWindowMonitor(_glfwWindow) != null)
                    {
                        state = WindowState.Fullscreen;
                    }
                    else
                    {
                        state = WindowState.Normal;
                    }
                }

                UpdateState(state);
                StateChanged?.Invoke(state);
            };

            _onMaximized = (window, isMaximized) =>
            {
                // Same here as in onMinimized.
                WindowState state;
                if (isMaximized)
                {
                    state = WindowState.Maximized;
                }
                else
                {
                    if (_glfw.GetWindowAttrib(_glfwWindow, WindowAttributeGetter.Iconified))
                    {
                        state = WindowState.Minimized;
                    }
                    else if (_glfw.GetWindowMonitor(_glfwWindow) != null)
                    {
                        state = WindowState.Fullscreen;
                    }
                    else
                    {
                        state = WindowState.Normal;
                    }
                }

                UpdateState(state);
                StateChanged?.Invoke(state);
            };

            _onFileDrop = (window, count, paths) =>
            {
                var arrayOfPaths = new string[count];

                if (count == 0 || paths == IntPtr.Zero)
                {
                    return;
                }

                for (var i = 0; i < count; i++)
                {
                    var p = Marshal.ReadIntPtr(paths, i * IntPtr.Size);
                    arrayOfPaths[i] = Marshal.PtrToStringAnsi(p);
                }

                FileDrop?.Invoke(arrayOfPaths);
            };

            _glfw.SetWindowPosCallback(_glfwWindow, _onMove);
            _glfw.SetWindowSizeCallback(_glfwWindow, _onResize);
            _glfw.SetWindowCloseCallback(_glfwWindow, _onClosing);
            _glfw.SetWindowFocusCallback(_glfwWindow, _onFocusChanged);
            _glfw.SetWindowIconifyCallback(_glfwWindow, _onMinimized);
            _glfw.SetWindowMaximizeCallback(_glfwWindow, _onMaximized);
            _glfw.SetFramebufferSizeCallback(_glfwWindow, _onFramebufferResize);
            _glfw.SetDropCallback(_glfwWindow, _onFileDrop);
            GLFW.Glfw.ThrowExceptions();
        }

        protected override void UnregisterCallbacks()
        {
            // All callbacks are initialized at the same time,
            // so checking each one individually shouldn't be
            // necessary.
            if (_onClosing != null)
            {
                _glfw.GcUtility.Unpin(_onClosing);
                _glfw.GcUtility.Unpin(_onMaximized);
                _glfw.GcUtility.Unpin(_onMinimized);
                _glfw.GcUtility.Unpin(_onMove);
                _glfw.GcUtility.Unpin(_onResize);
                _glfw.GcUtility.Unpin(_onFramebufferResize);
                _glfw.GcUtility.Unpin(_onFileDrop);
                _glfw.GcUtility.Unpin(_onFocusChanged);
            }
        }

        public override event Action<Size>? Resize;
        public override event Action<Size>? FramebufferResize;
        public override event Action? Closing;
        public override event Action<bool>? FocusChanged;

        ~GlfwWindow()
        {
            CoreReset();
        }

        public bool IsCurrent => _glfw.GetCurrentContext() == _glfwWindow;
        public void SwapInterval(int interval) => _glfw.SwapInterval(interval);
        public void SwapBuffers() => _glfw.SwapBuffers(_glfwWindow);
        public void MakeCurrent() => _glfw.MakeContextCurrent(_glfwWindow);
        public void Clear() => _glfw.MakeContextCurrent(null);

        public VkHandle Create<T>(VkHandle instance, T* allocator) where T : unmanaged
        {
            var surface = stackalloc VkHandle[1];
            int ec;
            if ((ec = _glfw.CreateWindowSurface(instance, _glfwWindow, allocator, surface)) != 0)
            {
                throw new GlfwException("Failed to create surface, error code " + ec);
            }

            GLFW.Glfw.ThrowExceptions();
            return surface[0];
        }

        public char** GetRequiredExtensions(out uint count) => (char**) _glfw.GetRequiredInstanceExtensions(out count);
    }
}
