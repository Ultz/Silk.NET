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
    [Extension("ARB_color_buffer_float")]
    public unsafe partial class ArbColorBufferFloat : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_color_buffer_float";
        [NativeApi(EntryPoint = "glClampColorARB")]
        public partial void ClampColor([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB clamp);

        [NativeApi(EntryPoint = "glClampColorARB")]
        public partial void ClampColor([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ClampColorModeARB clamp);

        [NativeApi(EntryPoint = "glClampColorARB")]
        public partial void ClampColor([Flow(FlowDirection.In)] ClampColorTargetARB target, [Flow(FlowDirection.In)] ARB clamp);

        [NativeApi(EntryPoint = "glClampColorARB")]
        public partial void ClampColor([Flow(FlowDirection.In)] ClampColorTargetARB target, [Flow(FlowDirection.In)] ClampColorModeARB clamp);

        public ArbColorBufferFloat(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

