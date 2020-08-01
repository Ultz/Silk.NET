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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_blend_func_extended")]
    public abstract unsafe partial class ExtBlendFuncExtended : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_blend_func_extended";
        [NativeApi(EntryPoint = "glBindFragDataLocationEXT")]
        public abstract unsafe void BindFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint color, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glBindFragDataLocationEXT")]
        public abstract void BindFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint color, [Count(Computed = "name"), Flow(FlowDirection.In)] ref byte name);

        [NativeApi(EntryPoint = "glBindFragDataLocationIndexedEXT")]
        public abstract unsafe void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glBindFragDataLocationIndexedEXT")]
        public abstract void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetFragDataIndexEXT")]
        public abstract unsafe int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetFragDataIndexEXT")]
        public abstract int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndexEXT")]
        public abstract unsafe int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndexEXT")]
        public abstract int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ref byte name);

        [NativeApi(EntryPoint = "glBindFragDataLocationEXT")]
        public abstract void BindFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint color, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glBindFragDataLocationIndexedEXT")]
        public abstract void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetFragDataIndexEXT")]
        public abstract int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndexEXT")]
        public abstract int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name);

        public ExtBlendFuncExtended(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

