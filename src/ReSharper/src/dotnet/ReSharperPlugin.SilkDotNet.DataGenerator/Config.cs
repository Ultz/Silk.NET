// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using ReSharperPlugin.SilkDotNet.DataGenerator.Jobs;
using static ReSharperPlugin.SilkDotNet.DataGenerator.Program;

namespace ReSharperPlugin.SilkDotNet.DataGenerator
{
    public static class Config
    {
        public const string OutputNamespace = "ReSharperPlugin.SilkDotNet";
        public const string OutputClass = "Data";
        public static readonly string OutputPath = RelativeToConfigFile("../ReSharperPlugin.SilkDotNet/Data.gen.cs");

        public const string LicenseHeader = "Licensed to the .NET Foundation under one or more agreements.\n" +
                                            "The .NET Foundation licenses this file to you under the MIT license.";

        public static readonly Dictionary<string, IJob[]> Jobs = new()
        {
            {
                "Silk.NET.Vulkan",
                new IJob[]
                {
                    new BasicKhronosIndexJob
                    (
                        "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/",
                        "Vulkan"
                    ),
                    new KhronosXmlJob
                    (
                        "https://raw.githubusercontent.com/KhronosGroup/Vulkan-Docs/main/xml/vk.xml",
                        "vulkan"
                    )
                }
            },
            {
                "Silk.NET.OpenXR",
                new IJob[]
                {
                    new BasicKhronosIndexJob
                    (
                        "https://www.khronos.org/registry/OpenXR/specs/1.0/man/html/",
                        "OpenXR"
                    ),
                    new KhronosXmlJob
                    (
                        "https://raw.githubusercontent.com/KhronosGroup/OpenXR-SDK-Source/master/specification/" +
                        "registry/xr.xml",
                        "openxr"
                    )
                }
            },
            {
                "Silk.NET.OpenGL",
                new IJob[]
                {
                    new OpenGLRefpagesJob
                    (
                        "https://github.com/KhronosGroup/OpenGL-Refpages/archive/refs/heads/master.zip",
                        "OpenGL-Refpages-master/gl4",
                        "https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/"
                    ),
                    new KhronosXmlJob
                    (
                        "https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/master/xml/gl.xml",
                        "gl"
                    )
                }
            },
            {
                "Silk.NET.OpenGL.Legacy",
                new IJob[]
                {
                    new OpenGLRefpagesJob
                    (
                        "https://github.com/KhronosGroup/OpenGL-Refpages/archive/refs/heads/master.zip",
                        "OpenGL-Refpages-master/gl4",
                        "https://www.khronos.org/registry/OpenGL-Refpages/gl4/html/"
                    ),
                    new KhronosXmlJob
                    (
                        "https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/master/xml/gl.xml",
                        "gl"
                    )
                }
            },
            {
                "Silk.NET.OpenGLES",
                new IJob[]
                {
                    new OpenGLRefpagesJob
                    (
                        "https://github.com/KhronosGroup/OpenGL-Refpages/archive/refs/heads/master.zip",
                        "OpenGL-Refpages-master/es3.1",
                        "https://www.khronos.org/registry/OpenGL-Refpages/es3.1/html/"
                    ),
                    new KhronosXmlJob
                    (
                        "https://raw.githubusercontent.com/KhronosGroup/OpenGL-Registry/master/xml/gl.xml",
                        "gles2"
                    )
                }
            },
            {
                "Silk.NET.OpenCL",
                new IJob[]
                {
                    new KhronosXmlJob
                    (
                        "https://raw.githubusercontent.com/KhronosGroup/OpenCL-Docs/master/xml/cl.xml",
                        "opencl"
                    )
                }
            }
        };
    }
}
