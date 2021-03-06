// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_multi_draw_arrays")]
    public unsafe partial class ExtMultiDrawArrays : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_multi_draw_arrays";
        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        public unsafe partial void MultiDrawArrays([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        public unsafe partial void MultiDrawArrays([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        public unsafe partial void MultiDrawArrays([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        public partial void MultiDrawArrays([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        public unsafe partial void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        public unsafe partial void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        public unsafe partial void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        public partial void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public unsafe partial void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount);

        public ExtMultiDrawArrays(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

