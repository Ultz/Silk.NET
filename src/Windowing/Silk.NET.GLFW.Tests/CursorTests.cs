// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Xunit;
using Xunit.Sdk;

namespace Silk.NET.GLFW.Tests
{
    public unsafe class CursorTests
    {
        [Fact]
        public void CursorPosition()
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

            const double x = 100.0;
            const double y = 150.0;
            for (int i = 0; i < 4; i++)
            {
                if (i == 1)
                    glfw.SetCursorPos(window, x, y);

                if (i == 2)
                {
                    glfw.GetCursorPos(window, out var actualX, out var actualY);
                    Assert.Equal(x, actualX);
                    Assert.Equal(y, actualY);
                }

                glfw.SwapBuffers(window);
                glfw.WaitEvents();
            }

            glfw.SetCursorPos(window, 0, 0);
            
            glfw.SetWindowShouldClose(window, true);
            glfw.WaitEventsTimeout(1.0f);
            
            glfw.Terminate();
            Glfw.ThrowExceptions();
        }
    }
}
