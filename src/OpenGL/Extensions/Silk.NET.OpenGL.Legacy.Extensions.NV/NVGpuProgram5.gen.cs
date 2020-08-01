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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_gpu_program5")]
    public abstract unsafe partial class NVGpuProgram5 : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_gpu_program5";
        [NativeApi(EntryPoint = "glGetProgramSubroutineParameteruivNV")]
        public abstract unsafe void GetProgramSubroutineParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] uint* param);

        [NativeApi(EntryPoint = "glGetProgramSubroutineParameteruivNV")]
        public abstract void GetProgramSubroutineParameter([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out uint param);

        [NativeApi(EntryPoint = "glProgramSubroutineParametersuivNV")]
        public abstract unsafe void ProgramSubroutineParameters([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glProgramSubroutineParametersuivNV")]
        public abstract void ProgramSubroutineParameters([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> @params);

        public NVGpuProgram5(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

