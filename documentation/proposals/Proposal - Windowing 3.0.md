# Summary

Cross-platform windowing for Silk.NET rebuilt from the ground-up.

# Contributors
- Dylan Perks (@Perksey)
- Kai Jellinghaus (@HurricanKai)

# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions
- This proposal assumes no knowledge of any previous iterations of Silk.NET Windowing.
- This is a complete rethink of Silk.NET Windowing built from the ground up to account for our goal of "write once run everywhere" for .NET 6 and Silk.NET 3.0.
- In this proposal, there are three parties:
   - **User**: the person using the Silk.NET Windowing library and by extension a platform implementation.
   - **Platform Implementor**: the party providing an implementation of the Silk.NET Windowing abstractions (abstractions such as the "Surface" as defined later in this proposal). This implementation will be referred to herein as the **Platform Implementation** (or the **Platform** for short)
   - **Library Implementor**: the party providing the plubming around the surface abstraction (such as the platform selection mechanisms and accompanying source generators). This will be referred to herein as the **Library Implementation** (or the **Library** for short)


# Platforms

There will be a number of "reference" implementations for the APIs laid out in this proposal. These are:
- For `net6.0` and `net6.0-windows`: GLFW.
- For `net6.0-ios`, `net6.0-tvos` and `net6.0-maccatalyst`: UIKit. (NB: The latter two will be a target for Silk.NET 3.X) 
- For `net6.0-macos`: AppKit (NB: This will be a target for Silk.NET 3.X, it is recommended developers targeting macOS use the regular `net6.0` TFM)
- For `net6.0-android`: EGL and ANativeWindow.
- For `net6.0-tizen`: TZSH. (NB: This will be a target for Silk.NET 3.X)

The decision has been made to drop SDL due to complications and the fact that all non-desktop targets are distinctly unique in their own right. We believe that in creating platform-specific code for each of these will result in significantly more robust support for each of these platforms. 

- **QUESTION:** Should we drop our SDL bindings too?
- **MAINTAINERS' ANSWER:** Yes, it's no longer used by us and a library such as SDL is a large amount of maintenance weight to carry. Akin to us dropping EGL in the 1.X-2.0 transition, we will be dropping our SDL answer.

All of the above is informative text, however, and no reference implementations are required or guaranteed to use these APIs under-the-hood.

Unlike previous iterations, one reference implementation **MUST** be bundled with the main Silk.NET.Windowing assembly. Given that we can easily use platform-specific TFMs there's no reason to keep the fragmentation of different implentations across different assemblies.

The reference implementation will be accessed through the static `Surface` class.
- `IsPlatformSupported` **MAY** return false if there is no reference implementation available for the given environment.
- `GetOrCreate` **MUST NOT** return `null`. It **MUST** always return a valid `ISurface` if `IsPlatformSupported` is true and no exceptions or errors ocurred during surface creation. This method **MUST** always return the same `ISurface` instance.
- `CreateNew` **MUST NOT** return the same `ISurface` object, and **MUST NOT** return `null`. It **MUST** always return a valid `ISurface` if `IsPlatformSupported` is true and no exceptions or errors ocurred during surface creation.
- `ClearCurrentContexts` **MUST** call `ClearCurrent` on all `IGLSurface` or `IGlesSurface` instances this reference implementation has created. 

For the reader's benefit, this `Surface` class isn't really intended for general consumption though it must be public for those applications don't fit into the model defined in the "Windowing Entry Points" section.

# Surface

In this proposal, a plane upon which graphics can be rendered on is represented by an `ISurface`. `ISurface` defines a minimal subset of basic APIs which **MUST** all be present on an **Platform Implementation**. The idea is `ISurface` just provides the bare necessities for rendering a game or application without knowing too much about the form factor, better encouraging cross-platform/"write once run everywhere" code. For a description of what this entials, see the defined API and the documentation comments therein.

`ISurface` **Platform Implementations** **SHOULD** also implement any extension interfaces that it can support for a given platform. Through these extension interfaces, if user code needs to access APIs which are more specific to certain form factors or platforms, they should use casts to get a more specific surface.

The "core `ISurface` API" is as minimalistic as possible to allow easy use in integrations into UI frameworks or other environments. For example, at some point in the future we'd like to make `ISurface` implementations atop WPF, MAUI, Avalonia, and more; as well as atop Blazor WASM (and by extension HTML5 and WebGL)

# Windowing Entry Points

Even with the platform selection mechanism, there is a lot of plumbing required to get to the stage of acquiring a surface on the various platforms. In Silk.NET 3.0, the **Library** **MAY** decide to expose a Roslyn source generator (the "**Gluer**" as used herein) to assist with this. If it doesn't, this section and its requirements can be discarded.

The **Gluer** **MUST** be distributed in package/namespace `Silk.NET.Windowing.Roslyn`.

The Gluer operates on **User** methods that:
- **MUST** be static
- **MUST** return `void`
- **MUST** have a single parameter of type `ISurface` or a type that inherits from `ISurface`. If the latter, the Glue **MUST** assert that the `ISurface` created is assignable to the parameter type or throw an exception if this is not the case. This allows applications to use `IDesktopSurface` only if that's their jam.
- **MUST** have the attribute `SilkEntryPoint`

The idea is the Gluer will generate `Main` methods on .NET, `Activity`s on .NET for Android, etc... The **Gluer**, if generating **MUST** generate the necessary APIs to ensure that the method in question is called on application start-up (the "Glue"). If any of the above User requirements aren't met, the **Gluer** **MUST NOT** generate Glue. If a method is found with the `SilkEntryPoint` attribute but fails to meet one of the other requirements, the **Gluer** **MUST** generate a compiler error; otherwise it **MUST NOT** impact the compilation whatsoever.

If multiple methods are found with `SilkEntryPoint`, the **Gluer** **MUST** generate a compiler error. All attributes **MUST** only be name matched by the **Gluer**.

The Gluer **MUST NOT** modify the original type (i.e. all Glue must be defined in its own self-contained type)

The **User** **MUST NOT** define their own application entry point (such as a static `Main` method in the case of regular .NET) if they are using the Gluer, though the Gluer does not have to enforce this.

The method **MAY** be called multiple times throughout the lifetime of an application. This is because of operating system restrictions - the only way to definitively know whether this method is being called for the last time is the `IsTerminating` property or `Terminating` event on `ISurface`.

The Glue is purposely left undefined as this is operating system &amp; platform specific, and would not reflect any future platforms we decide to add.

A model example of what this looks like:
```cs
public class MyGame
{
    [SilkEntryPoint]
    public static void RunGame(ISurface surface)
    {
        // do things with your surface
        surface.Run();
    }
}
```

# Optional Features
## Desktop Surface

A more rich set of APIs intended for use on desktop-style window management systems. For a description of what this entials, see the defined API and the documentation comments therein.

## OpenGL Surface

Enables OpenGL context creation atop a native surface. For a description of what this entials, see the defined API and the documentation comments therein.

## OpenGLES Surface

Enables OpenGLES context creation atop a native surface. For a description of what this entials, see the defined API and the documentation comments therein.

## Vulkan Surface

Enables Vulkan surface creation atop a native surface. For a description of what this entials, see the defined API and the documentation comments therein.

## OpenGL Surface with Framebuffer Transparency

Framebuffer transparency is an optional feature, and therefore has its own interface. This allows the a window to be created where the content area is transparent. For a description of what this entials, see the defined API and the documentation comments therein.

NB: We've been discussing `IWebGLSurface` a lot recently, but this is left out of this proposal as this is a target for Silk.NET 3.X.

# Proposed API
- Here you do some code blocks, this is the heart and soul of the proposal. DON'T DO ANY IMPLEMENTATIONS! Just declarations.

## Delegates

NB: instead of generic delegates like we've used in previous iterations, we use named delegates instead so the parameter names are auto-filled out by IDEs with indicative names, instead of `obj` or `argN`.

```cs
public delegate void Vector2DAction(Vector2D<int> newValue);
public delegate void DeltaAction(double deltaTime);
public delegate void WindowStateAction(WindowState newState);
public delegate void FilePathsAction(string[] filePaths);
public delegate void ToggleAction(bool newValue);
```

## `ISurface`
```cs
namespace Silk.NET.Windowing
{
    public interface ISurface : IDisposable
    {
        /// <summary>
        /// Determines whether the surface is being destroyed by the platform.
        /// </summary>
        bool IsTerminating { get; }
        
        /// <summary>
        /// Determines whether the surface is being paused by the platform.
        /// </summary>
        bool IsPausing { get; }

        /// <summary>
        /// Elapsed time in seconds since the Run method last started.
        /// </summary>
        double Time { get; }

        /// <summary>
        /// Gets the native platform the surface is running on.
        /// </summary>
        INativePlatform Native { get; }

        /// <summary>
        /// The size of the surface's inner framebuffer. May differ from the surface size.
        /// </summary>
        // NB: This is not OpenGL specific and is valid in any case where there's a high DPI monitor.
        Vector2D<int> FramebufferSize { get; }

        /// <summary>
        /// The size of the surface.
        /// </summary>
        Vector2D<int> Size { get; }

        /// <summary>
        /// The number of rendering operations to run every second.
        /// </summary>
        double FramesPerSecond { get; set; }

        /// <summary>
        /// The number of update operations to run every second.
        /// </summary>
        double UpdatesPerSecond { get; set; }

        /// <summary>
        /// Raised when the surface is resized.
        /// </summary>
        event Vector2DAction? Resize;

        /// <summary>
        /// Raised when the surface's framebuffer is resized.
        /// </summary>
        event Vector2DAction? FramebufferResize;

        /// <summary>
        /// Raised when the surface is being terminated.
        /// </summary>
        event Action? Terminating;

        /// <summary>
        /// Raised when the surface is running low on memory.
        /// </summary>
        event Action? LowMemory;

        /// <summary>
        /// Raised when the surface is about to pause. This is a good indicator that the Run method is about to exit, though this may not necessarily be the case, but the surface isn't terminating yet.
        /// </summary>
        event Action? Pausing;

        /// <summary>
        /// Raised when the surface is about to resume. This is a good indicator to expect the entry point to be called again, though this may not necessarily be the case. 
        /// </summary>
        event Action? Resuming;

        /// <summary>
        /// Raised when the surface is initialized for the first time.
        /// </summary>
        event Action? Created;

        /// <summary>
        /// Raised when an update should be run.
        /// </summary>
        event DeltaAction? Update;

        /// <summary>
        /// Raised when a frame should be rendered.
        /// </summary>
        event DeltaAction? Render;

        /// <summary>
        /// Creates the surface on the underlying platform.
        /// </summary>
        void Initialize();

        /// <summary>
        /// Calls the Render event.
        /// </summary>
        void DoRender();

        /// <summary>
        /// Calls the Update event.
        /// </summary>
        void DoUpdate();

        /// <summary>
        /// Polls the underlying platform for events.
        /// </summary>
        void DoEvents();

        /// <summary>
        /// Unloads the surface on the underlying platform.
        /// </summary>
        void Reset();

        /// <summary>
        /// Terminates this surface.
        /// </summary>
        void Terminate();

        /// <summary>
        /// Converts this point to framebuffer coordinates.
        /// </summary>
        /// <param name="point">The point to transform.</param>
        /// <returns>The transformed point.</returns>
        /// <remarks>Expects client coordinates as input.</remarks>
        Vector2D<int> PointToFramebuffer(Vector2D<int> point);

        /// <summary>
        /// Initiates a render loop in which the given callback is called as fast as the underlying platform can manage.
        /// </summary>
        /// <param name="onFrame">The callback to run each frame.</param>
        void Run(Action onFrame);
    }
}
```

## `IDesktopSurface`

```cs
namespace Silk.NET.Windowing
{
    /// <summary>
    /// A surface which wraps a Desktop Window.
    /// </summary>
    public interface IDesktopSurface : ISurface
    {
        /// <summary>
        /// Whether or not the window is visible.
        /// </summary>
        bool IsVisible { get; set; }

        /// <summary>
        /// The position of the window. If set to -1, use the backend default.
        /// </summary>
        Vector2D<int> Position { get; set; }

        /// <summary>
        /// The size of the window in pixels.
        /// </summary>
        new Vector2D<int> Size { get; set; }

        /// <summary>
        /// The window title.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// The window state.
        /// </summary>
        WindowState WindowState { get; set; }

        /// <summary>
        /// The window border.
        /// </summary>
        WindowBorder WindowBorder { get; set; }

        /// <summary>
        /// The video mode.
        /// </summary>
        VideoMode VideoMode { get; set; }
    
        /// <summary>
        /// Gets the screen on which this window is active.
        /// </summary>
        IScreen? CurrentScreen { get; set; }

        /// <summary>
        /// Gets the available screens for this surface.
        /// </summary>
        IEnumerable<IScreen>? AvailableScreens { get; }

        /// <summary>
        /// Gets or sets whether the window waits for an event to be posted before existing <see cref="DoEvents" />.
        /// </summary>
        bool IsEventDriven { get; set; }

        /// <summary>
        /// Gets or sets whether the window has been requested to close.
        /// </summary>
        bool IsCloseRequested { get; set; }

        /// <summary>
        /// Gets whether the window is focused or not.
        /// </summary>
        bool IsFocused { get; }

        /// <summary>
        /// Gets the distances in screen coordinates from the edges of the content area to the corresponding edges of
        /// the full window.
        /// </summary>
        /// <remarks>
        /// Because these are distances and not coordinates, they are always zero or positive.
        /// </remarks>
        /// <seealso cref="WindowExtensions.GetFullSize"/>
        Rectangle<int> BorderSize { get; }
        
        /// <summary>
        /// Raised when the window has been requested to close.
        /// </summary>
        event Action CloseRequested;

        /// <summary>
        /// Raised when the window is moved.
        /// </summary>
        event Vector2DAction? Move;

        /// <summary>
        /// Raised when the window state is changed.
        /// </summary>
        event WindowStateAction? StateChanged;

        /// <summary>
        /// Raised when the user drops files onto the window.
        /// </summary>
        event FilePathsAction? FileDrop;

        /// <summary>
        /// Raised when the window focus changes.
        /// </summary>
        event ToggleAction? FocusChanged;

        /// <summary>
        /// Sets the window icons.
        /// </summary>
        /// <param name="icons">Either a collection of window icons, or null to set to the default icon.</param>
        void SetWindowIcon(ReadOnlySpan<RawImage> icons);

        /// <summary>
        /// When using <see cref="WindowOptions.IsEventDriven"/> = true, wakes the main thread from
        /// its blocking wait on incoming events.  Can be called from any thread.
        /// </summary>
        void ContinueEvents();

        /// <summary>
        /// Converts this point to client coordinates.
        /// </summary>
        /// <param name="point">The point to transform.</param>
        /// <returns>The transformed point.</returns>
        /// <remarks>Expects screen coordinates as input.</remarks>
        Vector2D<int> PointToClient(Vector2D<int> point);

        /// <summary>
        /// Converts this point to screen coordinates.
        /// </summary>
        /// <param name="point">The point to transform.</param>
        /// <returns>The transformed point.</returns>
        /// <remarks>Expects client coordinates as input.</remarks>
        Vector2D<int> PointToScreen(Vector2D<int> point);
    }
}
```

## `INativeGLSurface`

```cs
namespace Silk.NET.Windowing
{
    public interface INativeGLSurface : ISurface
    {
        nint Handle { get; }
        bool IsContextCurrent { get; set; }
        bool ShouldSwapAutomatically { get; set; }
        
        /// <summary>
        /// Sets the number of vertical blanks to wait between calling <see cref="SwapBuffers" /> and presenting the image,
        /// a.k.a vertical synchronization (V-Sync). Set to <c>1</c> to enable V-Sync.
        /// </summary>
        /// <remarks>
        /// Due to platform restrictions, this value can only be set and not retrieved.
        /// </remarks>
        int SwapInterval { set; }

        /// <summary>
        /// Preferred depth buffer bits of the window's framebuffer.
        /// </summary>
        /// <remarks>
        /// Pass <c>null</c> or <c>-1</c> to use the system default. 
        /// </remarks>
        int? PreferredDepthBufferBits { get; set; }

        /// <summary>
        /// Preferred stencil buffer bits of the window's framebuffer.
        /// </summary>
        /// <remarks>
        /// Pass <c>null</c> or <c>-1</c> to use the system default. 
        /// </remarks>
        int? PreferredStencilBufferBits { get; set; }
        
        /// <summary>
        /// Preferred red, green, blue, and alpha bits of the window's framebuffer.
        /// </summary>
        /// <remarks>
        /// Pass <c>null</c> or <c>-1</c> for any of the channels to use the system default. 
        /// </remarks>
        Vector4D<int>? PreferredBitDepth { get; set; }
        
        /// <summary>
        /// The API version to use.
        /// </summary>
        Version32? ApiVersion { get; set; }

        nint? GetProcAddress(string proc);
        void SwapBuffers();
    }
}
```

## `IGLSurface`

```cs
namespace Silk.NET.Windowing
{
    public interface IGLSurface : INativeGLSurface
    {
        ContextFlags ContextFlags { get; set; }
        ContextProfile ContextProfile { get; set; }
        IGLSurface? SharedContext { get; set; }
    
        /// <summary>
        /// Enables OpenGL support for this surface. This will create a surface upon initialization.
        /// </summary>
        bool TryEnableOpenGL();
    }
}
```

## `IGlesSurface`

```cs
namespace Silk.NET.Windowing
{
    public interface IGlesSurface : INativeGLSurface
    {
        IGlesSurface? SharedContext { get; set; }
        /// <summary>
        /// Enables OpenGLES support for this surface. This will create a surface upon initialization.
        /// </summary>
        bool TryEnableOpenGLES();
    }
}
```

## `IVkSurface`

```cs
namespace Silk.NET.Windowing
{
    public interface IVkSurface : ISurface
    {
        /// <summary>Enables Vulkan support for this surface.</summary>
        bool TryEnableVulkan();

        /// <summary>
        /// Create a Vulkan surface.
        /// </summary>
        /// <param name="instance">The Vulkan instance to create a surface for.</param>
        /// <param name="allocator">A custom Vulkan allocator. Can be omitted by passing null.</param>
        /// <returns>A handle to the Vulkan surface created</returns>
        unsafe ulong Create(nint instance, void* allocator);

        /// <summary>
        /// Get the extensions required for Vulkan to work on this platform.
        /// </summary>
        /// <param name="count">The number of extensions in the returned array</param>
        /// <returns>An array of strings, containing names for all required extensions</returns>
        unsafe byte** GetRequiredExtensions(out uint count);
    }
}
```

## `IGLDesktopSurface`

```cs
namespace Silk.NET.Windowing
{
    public interface IGLDesktopSurface : IDesktopSurface, IGLSurface { }
}
```


## `IGlesDesktopSurface`

```cs
namespace Silk.NET.Windowing
{
    public interface IGlesDesktopSurface : IDesktopSurface, IGlesSurface { }
}
```

## `IVkDesktopSurface`

```cs
namespace Silk.NET.Windowing
{
    public interface IVkDesktopSurface : IDesktopSurface, IVkSurface { }
}
```

## `IGLTransparentFramebufferSurface`

```cs
namespace Silk.NET.Windowing
{
    public interface IGLTransparentFramebuffer : INativeGLSurface
    {
        bool TransparentFramebuffer { get; set; }
    }
}
```

## `ContextFlags`

```cs
namespace Silk.NET.Windowing
{
    /// <summary>
    /// Represents flags related to the OpenGL context.
    /// </summary>
    [Flags]
    public enum ContextFlags
    {
        /// <summary>
        /// No flags enabled.
        /// </summary>
        Default = 0,

        /// <summary>
        /// Enables debug context; debug contexts provide more debugging info, but can run slower.
        /// </summary>
        Debug = 1,

        /// <summary>
        /// Enables forward compatability; this context won't support anything marked as deprecated in the current
        /// version.
        /// </summary>
        /// <remarks>On OpenGL contexts older than 3.0, this flag does nothing.</remarks>
        ForwardCompatible = 2
    }
}
```

## `ContextProfile`

```cs
namespace Silk.NET.Windowing
{
    /// <summary>
    /// Represents the context profile OpenGL should use.
    /// </summary>
    public enum ContextProfile
    {
        /// <summary>
        /// Uses a core OpenGL context, which removes some deprecated functionality.
        /// </summary>
        Core = 0,

        /// <summary>
        /// Uses a compatability OpenGL context, allowing for some deprecated functionality. This should only ever be
        /// used for maintaining legacy code; no newly-written software should use this.
        /// </summary>
        Compatability
    }
}
```

## `WindowBorder`

```cs
namespace Silk.NET.Windowing
{
    /// <summary>
    /// Represents the window border.
    /// </summary>
    public enum WindowBorder
    {
        /// <summary>
        /// The window can be resized by clicking and dragging its border.
        /// </summary>
        Resizable = 0,

        /// <summary>
        /// The window border is visible, but cannot be resized. All window-resizings must happen solely in the code.
        /// </summary>
        Fixed,

        /// <summary>
        /// The window border is hidden.
        /// </summary>
        Hidden
    }
}
```

## `WindowState`

```cs
namespace Silk.NET.Windowing
{
    /// <summary>
    /// Represents the current state of the window.
    /// </summary>
    public enum WindowState
    {
        /// <summary>
        /// The window is in its regular configuration.
        /// </summary>
        Normal = 0,

        /// <summary>
        /// The window has been minimized to the task bar.
        /// </summary>
        Minimized,

        /// <summary>
        /// The window has been maximized, covering the entire desktop, but not the taskbar.
        /// </summary>
        Maximized,

        /// <summary>
        /// The window has been fullscreened, covering the entire surface of the monitor.
        /// </summary>
        Fullscreen
    }
}
```

## `IScreen`

```cs
namespace Silk.NET.Windowing
{
    /// <summary>
    /// An interface representing a screen.
    /// </summary>
    public interface IScreen
    {
        /// <summary>
        /// The name of this screen.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The index of this screen.
        /// </summary>
        int Index { get; }

        /// <summary>
        /// The workarea of this screen.
        /// </summary>
        Rectangle<int> WorkArea { get; }

        /// <summary>
        /// The current video mode of this monitor.
        /// </summary>
        VideoMode VideoMode { get; }

        /// <summary>
        /// This screen's gamma correction.
        /// </summary>
        /// <remarks>
        /// Only supported by GLFW, has no effect on SDL.
        /// </remarks>
        float Gamma { get; set; }

        /// <summary>
        /// Get all video modes that this screen supports.
        /// </summary>
        /// <returns>An array of all video modes.</returns>
        IEnumerable<VideoMode> GetAllVideoModes();
    }
}
```

## `VideoMode`

```cs
namespace Silk.NET.Windowing
{
    public readonly struct VideoMode
    {
        public VideoMode(Vector2D<int>? resolution = null, int? refreshRate = null);
        public VideoMode(int? refreshRate);

        /// <summary>
        /// Resolution of the full screen window.
        /// </summary>
        public Vector2D<int>? Resolution { get; init; }

        /// <summary>
        /// Refresh rate of the full screen window in Hz.
        /// </summary>
        public int? RefreshRate { get; init; }

        /// <summary>
        /// The default video mode. This uses the window size for resolution and doesn't care about other values.
        /// </summary>
        public static VideoMode Default { get; }
    }
}
```

## `Surface`

```cs
namespace Silk.NET.Windowing
{
    public static class Surface
    {
        public static bool IsPlatformSupported { get; }
        public static ISurface GetOrCreate();
        public static ISurface CreateNew();
        public static void ClearCurrentContexts();
    }
}
```

## `SurfaceExtensions`

```cs
namespace Silk.NET.Windowing
{
    /// <summary>
    /// Extensions for ISurface
    /// </summary>
    public static class SurfaceExtensions
    {
        /// <summary>
        /// Start the default event loop on this surface.
        /// </summary>
        /// <param name="view">The surface to begin the loop on.</param>
        public static void Run(this ISurface surface);
        
        /// <summary>
        /// Gets the full size of the given window including its borders.
        /// </summary>
        /// <param name="window">The window to get size information from.</param>
        /// <returns>The full size of the window (including both content area and borders)</returns>
        public static Vector2D<int> GetFullSize(this IDesktopSurface window);
        
        /// <summary>
        /// Centers this window to the given monitor or, if null, the current monitor the window's on.
        /// </summary>
        /// <param name="window">The window to center.</param>
        /// <param name="screen">The specific screen to center the window to, if any.</param>
        public static void Center(this IDesktopSurface window, IScreen? screen = null);
        
        /// <summary>
        /// Sets the window icon to default on the given window.
        /// </summary>
        /// <param name="window">The window.</param>
        public static void SetDefaultIcon(this IDesktopWindow window);

        /// <summary>
        /// Sets a single window icon on the given window.
        /// </summary>
        /// <param name="window">The window.</param>
        /// <param name="icon">The icon to set.</param>
        public static void SetWindowIcon(this IDesktopSurface window, ref RawImage icon);
    }
}
```

## `Version32`

```cs
namespace Silk.NET.Core
{
    /// <summary>
    /// A 32-bit version structure.
    /// </summary>
    public readonly struct Version32
    {
        /// <summary>
        /// The underlying Vulkan-compatible 32-bit version integer.
        /// </summary>
        public uint Value { get; }
        
        /// <summary>
        /// Creates a Vulkan version structure from the given major, minor, and patch values.
        /// </summary>
        /// <param name="major">The major value.</param>
        /// <param name="minor">The minor value.</param>
        /// <param name="patch">The patch value.</param>
        public Version32(uint major, uint minor, uint patch);
        
        /// <summary>
        /// Creates a Vulkan version structure from the given Vulkan-compatible value.
        /// </summary>
        /// <param name="value">The value.</param>
        private Version32(uint value);
        
        /// <summary>
        /// Gets the major component of this version structure.
        /// </summary>
        public uint Major { get; }
        
        /// <summary>
        /// Gets the minor component of this version structure.
        /// </summary>
        public uint Minor { get; }
        
        /// <summary>
        /// Gets the patch component of this version structure.
        /// </summary>
        public uint Patch { get; }
        
        /// <summary>
        /// Creates a 32-bit version structure from the given 32-bit unsigned integer.
        /// </summary>
        /// <param name="val">The uint value.</param>
        /// <returns>The 32-bit version structure.</returns>
        public static explicit operator Version32(uint val);

        /// <summary>
        /// Creates a 32-bit version structure from the given managed version class.
        /// </summary>
        /// <param name="version">The version instance.</param>
        /// <returns>The 32-bit version structure.</returns>
        public static implicit operator Version32(Version version);

        /// <summary>
        /// Gets the 32-bit unsigned integer representation for this 32-bit version structure.
        /// </summary>
        /// <param name="version">The 32-bit version structure.</param>
        /// <returns>The 32-bit unsigned integer.</returns>
        public static implicit operator uint(Version32 version);

        /// <summary>
        /// Converts this 32-bit version structure to a managed version class.
        /// </summary>
        /// <param name="version">The 32-bit version structure.</param>
        /// <returns>The managed representation.</returns>
        public static implicit operator Version(Version32 version);
    }
}
```

## `RawImage`

```cs
namespace Silk.NET.Core
{
    /// <summary>
    /// Represents loaded, uncompressed, processed image data.
    /// </summary>
    public readonly struct RawImage : IEquatable<RawImage>
    {
        /// <summary>
        /// Creates a <see cref="RawImage"/> given pixel data and pixel dimensions.
        /// </summary>
        /// <param name="width">The width of the image.</param>
        /// <param name="height">The height of the image.</param>
        /// <param name="rgbaPixels">The image daqta.</param>
        public RawImage(int width, int height, Memory<byte> rgbaPixels);

        /// <summary>
        /// The width of the image in pixels
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// The height of the image in pixels.
        /// </summary>
        public int Height { get; }

        /// <summary>
        /// The image data.
        /// </summary>
        public Memory<byte> Pixels { get; }

        /// <summary>
        /// Checks whether the two given <see cref="RawImage"/>s are equal.
        /// </summary>
        /// <param name="left">The first raw image.</param>
        /// <param name="right">The second raw image to compare the first against.</param>
        /// <returns>True if they are equal, false otherwise.</returns>
        /// <remarks>
        /// This does not check whether the byte arrays are equal, only whether their references are the same.
        /// </remarks>  
        public static bool operator ==(RawImage left, RawImage right);

        /// <summary>
        /// Checks whether the two given <see cref="RawImage"/>s are not equal.
        /// </summary>
        /// <param name="left">The first raw image.</param>
        /// <param name="right">The second raw image to compare the first against.</param>
        /// <returns>True if they are not equal, false otherwise.</returns>
        /// <remarks>
        /// This does not check whether the byte arrays are equal, only whether their references are the same.
        /// </remarks>
        public static bool operator !=(RawImage left, RawImage right);

        /// <summary>
        /// Checks whether the given <see cref="RawImage"/> is equal to this one.
        /// </summary>
        /// <param name="other">The raw image to compare this raw image against.</param>
        /// <returns>True if they are equal, false otherwise.</returns>
        /// <remarks>
        /// This does not check whether the byte arrays have equal, only whether their references are the same.
        /// </remarks>  
        public bool Equals(RawImage other);

        /// <inheritdoc />
        public override bool Equals(object obj);

        /// <inheritdoc />
        public override int GetHashCode();
    }
}
```

## `INativeInfo`

```cs
namespace Silk.NET.Windowing
{
    public interface INativePlatformData
    {
        string PlatformName { get; }
    }
}
```

## `IWin32PlatformData`

```cs
namespace Silk.NET.Windowing
{
    public interface IWin32PlatformData : INativePlatformData
    {
        nint Hwnd { get; }
        nint HDC { get; }
        nint HInstance { get; }
    }
}
```

## `IX11PlatformData`

```cs
namespace Silk.NET.Windowing
{
    public interface IX11PlatformData : INativePlatformData
    {
        nint Display { get; }
        nint Window { get; }
    }
}
```

## `ICocoaPlatformData`

```cs
namespace Silk.NET.Windowing
{
    public interface ICocoaPlatformData : INativePlatformData
    {
        nint Window { get; }
    }
}
```

## `IWaylandPlatformData`

```cs
namespace Silk.NET.Windowing
{
    public interface IWaylandPlatformData : INativePlatformData
    {
        nint Display { get; }
        nint Surface { get; }
    }
}
```

## `IUIKitPlatformData`

Will be defined in a future proposal closer to implementation time, as we don't know what this entails yet (we may not do the same things SDL did)

## `IGlfwPlatformData`

```cs
namespace Silk.NET.Windowing
{
    public interface IGlfwPlatformData : INativePlatformData
    {
        nint Window { get; }
    }
}
```

## `IAndroidPlatformData`

Will be defined in a future proposal closer to implementation time, as we don't know what this entails yet (we may not do the same things SDL did)

**NOTE:** Vivante handles have not been revived for 3.0, this is a niche platform that we can't commit to having first-party support for.
