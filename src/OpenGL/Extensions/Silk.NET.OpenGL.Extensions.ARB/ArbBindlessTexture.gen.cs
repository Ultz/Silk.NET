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
    [Extension("ARB_bindless_texture")]
    public abstract unsafe partial class ArbBindlessTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_bindless_texture";
        [NativeApi(EntryPoint = "glGetImageHandleARB")]
        public abstract ulong GetImageHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] ARB format);

        [NativeApi(EntryPoint = "glGetTextureHandleARB")]
        public abstract ulong GetTextureHandle([Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glGetTextureSamplerHandleARB")]
        public abstract ulong GetTextureSamplerHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glGetVertexAttribLui64vARB")]
        public abstract unsafe void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLui64vARB")]
        public abstract void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<ulong> @params);

        [NativeApi(EntryPoint = "glIsImageHandleResidentARB")]
        public abstract bool IsImageHandleResident([Flow(FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glIsTextureHandleResidentARB")]
        public abstract bool IsTextureHandleResident([Flow(FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glMakeImageHandleNonResidentARB")]
        public abstract void MakeImageHandleNonResident([Flow(FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glMakeImageHandleResidentARB")]
        public abstract void MakeImageHandleResident([Flow(FlowDirection.In)] ulong handle, [Flow(FlowDirection.In)] ARB access);

        [NativeApi(EntryPoint = "glMakeTextureHandleNonResidentARB")]
        public abstract void MakeTextureHandleNonResident([Flow(FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glMakeTextureHandleResidentARB")]
        public abstract void MakeTextureHandleResident([Flow(FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glProgramUniformHandleui64ARB")]
        public abstract void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong value);

        [NativeApi(EntryPoint = "glProgramUniformHandleui64vARB")]
        public abstract unsafe void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* values);

        [NativeApi(EntryPoint = "glProgramUniformHandleui64vARB")]
        public abstract void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> values);

        [NativeApi(EntryPoint = "glUniformHandleui64ARB")]
        public abstract void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong value);

        [NativeApi(EntryPoint = "glUniformHandleui64vARB")]
        public abstract unsafe void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glUniformHandleui64vARB")]
        public abstract void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<ulong> value);

        [NativeApi(EntryPoint = "glVertexAttribL1ui64ARB")]
        public abstract void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong x);

        [NativeApi(EntryPoint = "glVertexAttribL1ui64vARB")]
        public abstract unsafe void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong* v);

        [NativeApi(EntryPoint = "glVertexAttribL1ui64vARB")]
        public abstract void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Span<ulong> v);

        [NativeApi(EntryPoint = "glGetImageHandleARB")]
        public abstract ulong GetImageHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] PixelFormat format);

        [NativeApi(EntryPoint = "glGetVertexAttribLui64vARB")]
        public abstract unsafe void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLui64vARB")]
        public abstract void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Flow(FlowDirection.Out)] Span<ulong> @params);

        public ArbBindlessTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

