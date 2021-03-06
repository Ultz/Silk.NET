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

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "VkClearValue")]
    public unsafe partial struct ClearValue
    {
        public ClearValue
        (
            ClearColorValue? color = null,
            ClearDepthStencilValue? depthStencil = null
        ) : this()
        {
            if (color is not null)
            {
                Color = color.Value;
            }

            if (depthStencil is not null)
            {
                DepthStencil = depthStencil.Value;
            }
        }

/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkClearColorValue")]
        [NativeName("Type.Name", "VkClearColorValue")]
        [NativeName("Name", "color")]
        public ClearColorValue Color;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkClearDepthStencilValue")]
        [NativeName("Type.Name", "VkClearDepthStencilValue")]
        [NativeName("Name", "depthStencil")]
        public ClearDepthStencilValue DepthStencil;
    }
}
