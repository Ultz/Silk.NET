// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGI
{
    [Extension("SGI_color_table")]
    public unsafe partial class SgiColorTable : NativeExtension<GL>
    {
        public const string ExtensionName = "SGI_color_table";
        [NativeApi(EntryPoint = "glColorTableSGI")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public unsafe partial void ColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public partial void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] in T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI")]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI")]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI")]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI")]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI")]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI")]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI")]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI")]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI")]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI")]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI")]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI")]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI")]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI")]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI")]
        public unsafe partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI")]
        public partial void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glCopyColorTableSGI")]
        public partial void CopyColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyColorTableSGI")]
        public partial void CopyColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyColorTableSGI")]
        public partial void CopyColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glCopyColorTableSGI")]
        public partial void CopyColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        public unsafe partial void GetColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        public partial void GetColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI")]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI")]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI")]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI")]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI")]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI")]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI")]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI")]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI")]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI")]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI")]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI")]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI")]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI")]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI")]
        public unsafe partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI")]
        public partial void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        public SgiColorTable(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

