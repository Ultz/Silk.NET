// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using Silk.NET.Maths;

namespace Silk.NET.Windowing
{
    public interface IViewProperties
    {
        /// <summary>
        /// If true, SwapBuffers will be called automatically at the end of each Render event.
        /// </summary>
        bool ShouldSwapAutomatically { get; }

        /// <summary>
        /// If true, instead of executing the Update and Render events at a fixed interval, they will only be executed
        /// once there are events waiting to be processed.
        /// </summary>
        /// <remarks>
        /// The <see cref="UpdatesPerSecond"/> and <see cref="FramesPerSecond"/> will still be respected and treated as
        /// the "maximum" number of frames per second. Typically, the time between events is greater than the frame
        /// period, however.
        /// </remarks>
        bool IsEventDriven { get; set; }

        /// <summary>
        /// The size of the window in pixels.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This will be replaced with an integer vector once System.Numerics supports them.
        /// </para>
        /// </remarks>
        Vector2D<int> Size { get; }

        /// <summary>
        /// The number of rendering operations to run every second.
        /// </summary>
        /// <remarks>This value is ignored if <see cref="VSync">VSync</see> is set to <see langref="true"/>.</remarks>
        double FramesPerSecond { get; set; }

        /// <summary>
        /// The number of update operations to run every second.
        /// </summary>
        double UpdatesPerSecond { get; set; }

        /// <summary>
        /// The graphics API to use, and associated configurations.
        /// </summary>
        GraphicsAPI API { get; }

        /// <summary>
        /// Whether or not VSync is enabled for this view.
        /// </summary>
        /// <remarks>This value will set the SwapInterval for OpenGL, but on other frameworks (e.g. Vulkan) you will need to turn on
        /// VSync manually.  Whilst <see langref="true"/>, the value of <see cref="FramesPerSecond"/> is ignored, to prevent frame skipping.</remarks>
        bool VSync { get; set; }

        /// <summary>
        /// The video mode.
        /// </summary>
        VideoMode VideoMode { get; }

        /// <summary>
        /// Preferred depth buffer bits of the window's framebuffer.
        /// </summary>
        /// <remarks>
        /// Pass <c>null</c> or <c>-1</c> to use the system default. 
        /// </remarks>
        int? PreferredDepthBufferBits { get; }

        /// <summary>
        /// Preferred stencil buffer bits of the window's framebuffer.
        /// </summary>
        /// <remarks>
        /// Pass <c>null</c> or <c>-1</c> to use the system default. 
        /// </remarks>
        int? PreferredStencilBufferBits { get; }
        
        /// <summary>
        /// Preferred red, green, blue, and alpha bits of the window's framebuffer.
        /// </summary>
        /// <remarks>
        /// Pass <c>null</c> or <c>-1</c> for any of the axes to use the system default. 
        /// </remarks>
        Vector4D<int>? PreferredBitDepth { get; }
    }
}
