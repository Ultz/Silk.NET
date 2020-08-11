﻿// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Text;
using Silk.NET.Core;
using Silk.NET.SDL;
using Point = System.Drawing.Point;
using RawImage = Silk.NET.Core.RawImage;
using Size = System.Drawing.Size;

namespace Silk.NET.Windowing.Sdl
{
    internal unsafe class SdlWindow : SdlView, IWindow
    {
        private WindowOptions _extendedOptionsCache;
        private List<string> _droppedFiles = new List<string>();

        public SdlWindow(WindowOptions opts, SdlView? parent, SdlMonitor? monitor)
            : base(new ViewOptions(opts), parent, monitor)
        {
            _extendedOptionsCache = opts;
        }

        public bool IsVisible
        {
            get => !IsInitialized
                ? _extendedOptionsCache.IsVisible
                : ((WindowFlags) Sdl.GetWindowFlags(SdlWindow) & WindowFlags.WindowShown) != 0;
            set
            {
                _extendedOptionsCache.IsVisible = value;
                if (!IsInitialized)
                {
                    return;
                }

                if (value)
                {
                    Sdl.ShowWindow(SdlWindow);
                }
                else
                {
                    Sdl.HideWindow(SdlWindow);
                }
            }
        }

        public Point Position
        {
            get
            {
                if (IsInitialized)
                {
                    var ret = stackalloc int[2];
                    Sdl.GetWindowPosition(SdlWindow, ret, &ret[1]);
                    return *(Point*) ret;
                }
                else
                {
                    return _extendedOptionsCache.Position;
                }
            }
            set
            {
                _extendedOptionsCache.Position = value;
                if (!IsInitialized)
                {
                    return;
                }

                Sdl.SetWindowPosition(SdlWindow, value.X, value.Y);
            }
        }

        public new Size Size
        {
            get => _extendedOptionsCache.Size = base.Size;
            set
            {
                _extendedOptionsCache.Size = value;
                if (!IsInitialized)
                {
                    return;
                }

                Sdl.SetWindowSize(SdlWindow, value.Width, value.Height);
            }
        }

        public string Title
        {
            get => IsInitialized
                ? _extendedOptionsCache.Title = Sdl.GetWindowTitleS(SdlWindow)
                : _extendedOptionsCache.Title;
            set
            {
                _extendedOptionsCache.Title = value;
                if (!IsInitialized)
                {
                    return;
                }

                Sdl.SetWindowTitle(SdlWindow, value);
            }
        }

        public WindowState WindowState
        {
            get => IsInitialized
                ? _extendedOptionsCache.WindowState = ToWindowState((WindowFlags) Sdl.GetWindowFlags(SdlWindow))
                : _extendedOptionsCache.WindowState;
            set
            {
                if (IsInitialized)
                {
                    switch (value)
                    {
                        case WindowState.Normal:
                        {
                            Sdl.RestoreWindow(SdlWindow);
                            break;
                        }
                        case WindowState.Minimized:
                        {
                            Sdl.MinimizeWindow(SdlWindow);
                            break;
                        }
                        case WindowState.Maximized:
                        {
                            Sdl.MaximizeWindow(SdlWindow);
                            break;
                        }
                        case WindowState.Fullscreen:
                        {
                            Sdl.SetWindowFullscreen(SdlWindow, (uint) WindowFlags.WindowFullscreen);
                            break;
                        }
                        default:
                        {
                            throw new ArgumentOutOfRangeException(nameof(value), value, null);
                        }
                    }
                }

                _extendedOptionsCache.WindowState = value;
            }
        }

        public WindowBorder WindowBorder
        {
            get => IsInitialized
                ? _extendedOptionsCache.WindowBorder = ToWindowBorder((WindowFlags) Sdl.GetWindowFlags(SdlWindow))
                : _extendedOptionsCache.WindowBorder;
            set
            {
                _extendedOptionsCache.WindowBorder = value;
                if (!IsInitialized)
                {
                    return;
                }

                switch (value)
                {
                    case WindowBorder.Resizable:
                    {
                        Sdl.SetWindowBordered(SdlWindow, SdlBool.True);
                        Sdl.SetWindowResizable(SdlWindow, SdlBool.True);
                        break;
                    }
                    case WindowBorder.Fixed:
                    {
                        Sdl.SetWindowBordered(SdlWindow, SdlBool.True);
                        Sdl.SetWindowResizable(SdlWindow, SdlBool.False);
                        break;
                    }
                    case WindowBorder.Hidden:
                    {
                        Sdl.SetWindowBordered(SdlWindow, SdlBool.False);
                        Sdl.SetWindowResizable(SdlWindow, SdlBool.False);
                        break;
                    }
                    default:
                    {
                        throw new ArgumentOutOfRangeException(nameof(value), value, null);
                    }
                }
            }
        }

        public bool TransparentFramebuffer => false; // doesn't look like SDL doesn't support this
        public IWindow CreateWindow(WindowOptions opts) => new SdlWindow(opts, this, null);

        public IWindowHost? Parent => (IWindowHost?) ParentView ?? Monitor;

        public IMonitor? Monitor
        {
            get
            {
                if (!IsInitialized)
                {
                    return InitialMonitor;
                }

                var monitor = Sdl.GetWindowDisplayIndex(SdlWindow);
                if (monitor < 0)
                {
                    if (WindowState != WindowState.Fullscreen)
                    {
                        var monitors = Sdl.GetNumVideoDisplays();
                        if (monitors < 0)
                        {
                            throw new PlatformException(Sdl.GetErrorAsException());
                        }

                        // Determine which monitor this window is on. [6 marks]
                        for (var i = 0; i < monitors; i++)
                        {
                            var pos = Position;
                            var size = Size;
                            Rectangle bounds;
                            Sdl.GetDisplayUsableBounds(i, (Rect*) &bounds);
                            if (bounds.Contains(new Point(pos.X + size.Width / 2, pos.Y + size.Height / 2)))
                            {
                                return new SdlMonitor(i);
                            }
                        }
                    }
                }

                return monitor < 0
                    ? null
                    : new SdlMonitor(monitor);
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

                Position = value.Bounds.Location;
            }
        }

        public new bool IsClosing
        {
            get => base.IsClosing;
            set => IsClosingVal = value;
        }

        public event Action<Point>? Move;
        public event Action<WindowState>? StateChanged;
        public event Action<string[]>? FileDrop;

        public void SetWindowIcon(ReadOnlySpan<RawImage> icons)
        {
            var icon = icons[0];
            var surface = Sdl.CreateRGBSurfaceFrom
            (
                icon.Pixels.Span, icon.Width, icon.Height, 32, icon.Width * 4, 0xff000000, 0x00ff0000, 0x0000ff00,
                0x000000ff
            );
            Sdl.SetWindowIcon(SdlWindow, surface);
            Sdl.FreeSurface(surface);
        }

        private static WindowState ToWindowState(WindowFlags flags)
        {
            if ((flags & (WindowFlags.WindowFullscreen | WindowFlags.WindowFullscreenDesktop)) != 0)
            {
                return WindowState.Fullscreen;
            }

            if ((flags & WindowFlags.WindowMaximized) != 0)
            {
                return WindowState.Maximized;
            }

            if ((flags & WindowFlags.WindowMinimized) != 0)
            {
                return WindowState.Minimized;
            }

            return WindowState.Normal;
        }

        private static WindowBorder ToWindowBorder(WindowFlags flags)
        {
            if ((flags & WindowFlags.WindowResizable) != 0)
            {
                return WindowBorder.Resizable;
            }

            return (flags & WindowFlags.WindowBorderless) != 0
                ? WindowBorder.Hidden
                : WindowBorder.Fixed;
        }

        [SuppressMessage("ReSharper", "SwitchStatementHandlesSomeKnownEnumValuesWithDefault")]
        public override void ProcessEvents()
        {
            base.ProcessEvents();
            var i = 0;
            var c = Events.Count;
            for (var j = 0; j < c; j++)
            {
                var @event = Events[i];
                var skipped = false;
                switch ((EventType) @event.Type)
                {
                    case EventType.Windowevent:
                    {
                        switch ((WindowEventID) @event.Window.Type)
                        {
                            //case WindowEventID.WindoweventNone:
                            //    break;
                            //case WindowEventID.WindoweventShown:
                            //    break;
                            //case WindowEventID.WindoweventHidden:
                            //    break;
                            //case WindowEventID.WindoweventExposed:
                            //    break;
                            case WindowEventID.WindoweventMoved:
                            {
                                Move?.Invoke(new Point(@event.Window.Data1, @event.Window.Data2));
                                break;
                            }
                            case WindowEventID.WindoweventResized:
                                break;
                            case WindowEventID.WindoweventSizeChanged:
                                break;
                            case WindowEventID.WindoweventMinimized:
                            {
                                StateChanged?.Invoke(WindowState.Minimized);
                                break;
                            }
                            case WindowEventID.WindoweventMaximized:
                            {
                                StateChanged?.Invoke(WindowState.Maximized);
                                break;
                            }
                            case WindowEventID.WindoweventRestored:
                            {
                                StateChanged?.Invoke(WindowState.Normal);
                                break;
                            }
                            //case WindowEventID.WindoweventEnter:
                            //    break;
                            //case WindowEventID.WindoweventLeave:
                            //    break;
                            //case WindowEventID.WindoweventFocusGained:
                            //    break;
                            //case WindowEventID.WindoweventFocusLost:
                            //    break;
                            //case WindowEventID.WindoweventClose:
                            //    break;
                            //case WindowEventID.WindoweventTakeFocus:
                            //    break;
                            //case WindowEventID.WindoweventHitTest:
                            //    break;
                            default:
                            {
                                i++;
                                skipped = true;
                                break;
                            }
                        }
                        break;
                    }
                    case EventType.Dropfile:
                    {
                        _droppedFiles.Add(new string((sbyte*) @event.Drop.File));
                        break;
                    }
                    default:
                    {
                        i++;
                        skipped = true;
                        break;
                    }
                }
                
                if (!skipped)
                {
                    Events.RemoveAt(i);
                }
            }

            if (_droppedFiles.Count > 0)
            {
                FileDrop?.Invoke(_droppedFiles.ToArray());
                _droppedFiles.Clear();
            }
        }
    }
}
