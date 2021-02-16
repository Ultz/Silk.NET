// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Xunit;
using Xunit.Sdk;

namespace Silk.NET.GLFW.Tests
{
    public unsafe class ClipboardTests
    {
        [Fact]
        public void Clipboard()
        {
            var glfw = Glfw.GetApi();

            Assert.True(glfw.Init(), "Glfw failed to init");

            var window = glfw.CreateWindow(200, 200, "Clipboard Test", null, null);

            if (window == default)
            {
                glfw.Terminate();
                throw new XunitException("Failed to create window");
            }

            glfw.MakeContextCurrent(window);
            glfw.SwapInterval(1);

            const string testData = "English 日本語 русский язык 官話";
            for (int i = 0; i < 4; i++)
            {
                if (i == 1)
                    glfw.SetClipboardString(window, testData);

                if (i == 3)
                    Assert.Equal(testData, glfw.GetClipboardString(window));
                
                glfw.SwapBuffers(window);
                glfw.WaitEvents();
            }
            
            glfw.SetWindowShouldClose(window, true);
            glfw.WaitEventsTimeout(1.0f);
            
            glfw.Terminate();
            Glfw.ThrowExceptions();
        }
    }
}
