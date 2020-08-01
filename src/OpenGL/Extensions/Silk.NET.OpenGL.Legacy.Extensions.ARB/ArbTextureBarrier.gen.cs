// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_texture_barrier")]
    public abstract unsafe partial class ArbTextureBarrier : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_texture_barrier";
        [NativeApi(EntryPoint = "glTextureBarrier")]
        public abstract void TextureBarrier();

        public ArbTextureBarrier(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

