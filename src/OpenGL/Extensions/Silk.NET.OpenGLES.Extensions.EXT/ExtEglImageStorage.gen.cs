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
    [Extension("EXT_EGL_image_storage")]
    public abstract unsafe partial class ExtEglImageStorage : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_EGL_image_storage";
        [NativeApi(EntryPoint = "glEGLImageTargetTexStorageEXT")]
        public abstract unsafe void EglimageTargetTexStorage([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "glEGLImageTargetTexStorageEXT")]
        public abstract void EglimageTargetTexStorage([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] Span<int> attrib_list);

        [NativeApi(EntryPoint = "glEGLImageTargetTextureStorageEXT")]
        public abstract unsafe void EglimageTargetTextureStorage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "glEGLImageTargetTextureStorageEXT")]
        public abstract void EglimageTargetTextureStorage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] Span<int> attrib_list);

        public unsafe void EglimageTargetTexStorage([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] int* attrib_list)
        {
            // IntPtrOverloader
            EglimageTargetTexStorage(target, new IntPtr(image), attrib_list);
        }

        public unsafe void EglimageTargetTexStorage([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] Span<int> attrib_list)
        {
            // IntPtrOverloader
            EglimageTargetTexStorage(target, new IntPtr(image), attrib_list);
        }

        public unsafe void EglimageTargetTextureStorage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] int* attrib_list)
        {
            // IntPtrOverloader
            EglimageTargetTextureStorage(texture, new IntPtr(image), attrib_list);
        }

        public unsafe void EglimageTargetTextureStorage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] Span<int> attrib_list)
        {
            // IntPtrOverloader
            EglimageTargetTextureStorage(texture, new IntPtr(image), attrib_list);
        }

        public ExtEglImageStorage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

