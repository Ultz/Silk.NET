// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkImageResolve")]
    public unsafe partial struct ImageResolve
    {
        public ImageResolve
        (
            ImageSubresourceLayers? srcSubresource = null,
            Offset3D? srcOffset = null,
            ImageSubresourceLayers? dstSubresource = null,
            Offset3D? dstOffset = null,
            Extent3D? extent = null
        ) : this()
        {
            if (srcSubresource is not null)
            {
                SrcSubresource = srcSubresource.Value;
            }

            if (srcOffset is not null)
            {
                SrcOffset = srcOffset.Value;
            }

            if (dstSubresource is not null)
            {
                DstSubresource = dstSubresource.Value;
            }

            if (dstOffset is not null)
            {
                DstOffset = dstOffset.Value;
            }

            if (extent is not null)
            {
                Extent = extent.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkImageSubresourceLayers")]
        [NativeName("Type.Name", "VkImageSubresourceLayers")]
        [NativeName("Name", "srcSubresource")]
        public ImageSubresourceLayers SrcSubresource;
/// <summary></summary>
        [NativeName("Type", "VkOffset3D")]
        [NativeName("Type.Name", "VkOffset3D")]
        [NativeName("Name", "srcOffset")]
        public Offset3D SrcOffset;
/// <summary></summary>
        [NativeName("Type", "VkImageSubresourceLayers")]
        [NativeName("Type.Name", "VkImageSubresourceLayers")]
        [NativeName("Name", "dstSubresource")]
        public ImageSubresourceLayers DstSubresource;
/// <summary></summary>
        [NativeName("Type", "VkOffset3D")]
        [NativeName("Type.Name", "VkOffset3D")]
        [NativeName("Name", "dstOffset")]
        public Offset3D DstOffset;
/// <summary></summary>
        [NativeName("Type", "VkExtent3D")]
        [NativeName("Type.Name", "VkExtent3D")]
        [NativeName("Name", "extent")]
        public Extent3D Extent;
    }
}
