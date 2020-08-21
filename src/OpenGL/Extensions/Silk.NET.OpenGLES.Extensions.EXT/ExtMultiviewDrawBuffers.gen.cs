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
    [Extension("EXT_multiview_draw_buffers")]
    public unsafe partial class ExtMultiviewDrawBuffers : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_multiview_draw_buffers";
        [NativeApi(EntryPoint = "glDrawBuffersIndexedEXT")]
        public unsafe partial void DrawBuffersIndexed([Flow(FlowDirection.In)] int n, [Count(Parameter = "n"), Flow(FlowDirection.In)] EXT* location, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* indices);

        [NativeApi(EntryPoint = "glDrawBuffersIndexedEXT")]
        public unsafe partial void DrawBuffersIndexed([Flow(FlowDirection.In)] int n, [Count(Parameter = "n"), Flow(FlowDirection.In)] EXT* location, [Count(Parameter = "n"), Flow(FlowDirection.In)] in int indices);

        [NativeApi(EntryPoint = "glDrawBuffersIndexedEXT")]
        public unsafe partial void DrawBuffersIndexed([Flow(FlowDirection.In)] int n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in EXT location, [Count(Parameter = "n"), Flow(FlowDirection.In)] int* indices);

        [NativeApi(EntryPoint = "glDrawBuffersIndexedEXT")]
        public partial void DrawBuffersIndexed([Flow(FlowDirection.In)] int n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in EXT location, [Count(Parameter = "n"), Flow(FlowDirection.In)] in int indices);

        [NativeApi(EntryPoint = "glGetIntegeri_vEXT")]
        public unsafe partial void GetInteger([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegeri_vEXT")]
        public partial void GetInteger([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glReadBufferIndexedEXT")]
        public partial void ReadBufferIndexed([Flow(FlowDirection.In)] EXT src, [Flow(FlowDirection.In)] int index);

        [NativeApi(EntryPoint = "glReadBufferIndexedEXT")]
        public partial void ReadBufferIndexed([Flow(FlowDirection.In)] ReadBufferMode src, [Flow(FlowDirection.In)] int index);

        public ExtMultiviewDrawBuffers(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

