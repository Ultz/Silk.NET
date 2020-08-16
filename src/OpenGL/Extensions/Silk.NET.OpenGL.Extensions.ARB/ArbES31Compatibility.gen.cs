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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_ES3_1_compatibility")]
    public unsafe partial class ArbES31Compatibility : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_ES3_1_compatibility";
        [NativeApi(EntryPoint = "glMemoryBarrierByRegion")]
        public partial void MemoryBarrierByRegion([Flow(FlowDirection.In)] uint barriers);

        public ArbES31Compatibility(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

