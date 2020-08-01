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

namespace Silk.NET.OpenGL.Legacy.Extensions.IBM
{
    [Extension("IBM_multimode_draw_arrays")]
    public abstract unsafe partial class IbmMultimodeDrawArrays : NativeExtension<GL>
    {
        public const string ExtensionName = "IBM_multimode_draw_arrays";
        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        public abstract unsafe void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        public abstract void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] ref IBM mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref int first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public abstract unsafe void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public abstract unsafe void MultiModeDrawElements<T0>([Count(Computed = "primcount"), Flow(FlowDirection.In)] ref IBM mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        public abstract unsafe void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        public abstract void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] ref PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref int first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public abstract unsafe void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public abstract unsafe void MultiModeDrawElements<T0>([Count(Computed = "primcount"), Flow(FlowDirection.In)] ref PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride) where T0 : unmanaged;

        public IbmMultimodeDrawArrays(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

