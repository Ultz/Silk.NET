// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Diagnostics;
using System.Threading.Tasks;
using Silk.NET.Core.Native;
using Xunit;
using Xunit.Sdk;

namespace Silk.NET.GLFW.Tests
{
    public unsafe class GammaTests
    {
        [Fact]
        public void Gamma()
        {
            var glfw = Glfw.GetApi();

            Assert.True(glfw.Init(), "Glfw failed to init");

            var monitor = glfw.GetPrimaryMonitor();
            
            var window = glfw.CreateWindow(200, 200, "Gamma Test", null, null);

            if (window == default)
            {
                glfw.Terminate();
                throw new XunitException("Failed to create window");
            }

            var ramp = glfw.GetGammaRamp(monitor);
            var size = (int)(ramp->Size * sizeof(short));

            var red = (short*)SilkMarshal.Allocate(size);
            var green = (short*)SilkMarshal.Allocate(size);
            var blue = (short*)SilkMarshal.Allocate(size);
            var origRamp = new GammaRamp
            {
                Red = red, Green = green, Blue = blue, Size = ramp->Size
            };

            for (int i = 0; i < ramp->Size; i++)
            {
                red[i] = ramp->Red[i];
                green[i] = ramp->Green[i];
                blue[i] = ramp->Blue[i];
            }
            
            glfw.MakeContextCurrent(window);
            glfw.SwapInterval(1);

            for (int i = 0; i <= 20; i++)
            {
                glfw.SetGamma(monitor, i / 20f);
                glfw.WaitEventsTimeout(0.01f);
            }

            glfw.SetGammaRamp(monitor, ref origRamp);
            glfw.SetGamma(monitor, 1.0f);
            glfw.WaitEventsTimeout(1.0f);
            
            glfw.SetWindowShouldClose(window, true);
            glfw.WaitEventsTimeout(1.0f);

            glfw.Terminate();
            Glfw.ThrowExceptions();
        }
    }
}
