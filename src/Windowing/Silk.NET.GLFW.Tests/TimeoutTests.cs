// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Xunit;
using Xunit.Sdk;

namespace Silk.NET.GLFW.Tests
{
    public unsafe class TimeoutTests
    {
        [Fact]
        public void Timeout()
        {
            var glfw = Glfw.GetApi();

            Assert.True(glfw.Init(), "Glfw failed to init");

            var window = glfw.CreateWindow(200, 200, "Cursor Test", null, null);

            if (window == default)
            {
                glfw.Terminate();
                throw new XunitException("Failed to create window");
            }

            glfw.MakeContextCurrent(window);
            glfw.SwapInterval(1);

            for (int i = 0; i < 4; i++)
            {
                glfw.SwapBuffers(window);
                glfw.WaitEventsTimeout(1f);
            }
            
            glfw.SetWindowShouldClose(window, true);
            glfw.WaitEventsTimeout(1.0f);
            
            glfw.Terminate(); 
            Glfw.ThrowExceptions();
        }
    }
}
