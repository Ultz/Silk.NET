using System;
using Silk.NET.Core.Native;
using Silk.NET.GLFW;

namespace GammaFun
{
    unsafe class Program
    {
        static void Main(string[] args)
        {
            var glfw = Glfw.GetApi();

            glfw.Init();

            var monitor = glfw.GetPrimaryMonitor();
            
            var window = glfw.CreateWindow(200, 200, "Gamma Test", null, null);

            if (window == default)
            {
                glfw.Terminate();
                return;
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

            for (int i = 0; i <= 200; i++)
            {
                glfw.SetGamma(monitor, (i / 10) / 20f);

                glfw.SwapBuffers(window);
                glfw.WaitEvents();
            }

            glfw.SetGammaRamp(monitor, ref origRamp);

            glfw.SetWindowShouldClose(window, true);
            
            glfw.Terminate();
        }
    }
}
