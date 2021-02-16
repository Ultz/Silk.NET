// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

//========================================================================
// UTF-8 window title test
// Copyright (c) Camilla Löwy <elmindreda@glfw.org>
//
// This software is provided 'as-is', without any express or implied
// warranty. In no event will the authors be held liable for any damages
// arising from the use of this software.
//
// Permission is granted to anyone to use this software for any purpose,
// including commercial applications, and to alter it and redistribute it
// freely, subject to the following restrictions:
//
// 1. The origin of this software must not be misrepresented; you must not
//    claim that you wrote the original software. If you use this software
//    in a product, an acknowledgment in the product documentation would
//    be appreciated but is not required.
//
// 2. Altered source versions must be plainly marked as such, and must not
//    be misrepresented as being the original software.
//
// 3. This notice may not be removed or altered from any source
//    distribution.
//
//========================================================================

// ported from https://github.com/glfw/glfw/blob/master/tests/title.c

using System;
using System.IO;
using System.Reflection;
using Xunit;
using Xunit.Sdk;

namespace Silk.NET.GLFW.Tests
{
    public unsafe class TitleTests
    {
        
        [Fact]
        public void Title()
        {
            Directory.SetCurrentDirectory(Directory.GetDirectoryRoot(Assembly.GetExecutingAssembly().Location));
            using var glfw = Glfw.GetApi();

            Assert.True(glfw.Init(), "GLFW failed to init");

            var window = glfw.CreateWindow(400, 400, "English 日本語 русский язык 官話", null, null);
            if (window == default)
            {
                glfw.Terminate();
                throw new XunitException("Failed to create a window");
            }

            glfw.MakeContextCurrent(window);
            // gladLoadGL call in official version
            glfw.SwapInterval(1);

            for (int i = 0; i < 4; i++)
            {
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
