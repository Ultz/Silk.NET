// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_instanced_arrays")]
    public abstract unsafe partial class NVInstancedArrays : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_instanced_arrays";
        [NativeApi(EntryPoint = "glVertexAttribDivisorNV")]
        public abstract void VertexAttribDivisor([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint divisor);

        public NVInstancedArrays(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

