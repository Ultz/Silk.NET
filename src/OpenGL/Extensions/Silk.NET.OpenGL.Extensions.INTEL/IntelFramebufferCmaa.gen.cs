// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.INTEL
{
    [Extension("INTEL_framebuffer_CMAA")]
    public abstract unsafe partial class IntelFramebufferCmaa : NativeExtension<GL>
    {
        public const string ExtensionName = "INTEL_framebuffer_CMAA";
        [NativeApi(EntryPoint = "glApplyFramebufferAttachmentCMAAINTEL")]
        public abstract void ApplyFramebufferAttachmentCmaa();

        public IntelFramebufferCmaa(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

