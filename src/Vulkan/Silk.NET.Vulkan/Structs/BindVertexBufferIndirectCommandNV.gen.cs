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
    [NativeName("Name", "VkBindVertexBufferIndirectCommandNV")]
    public unsafe partial struct BindVertexBufferIndirectCommandNV
    {
        public BindVertexBufferIndirectCommandNV
        (
            ulong? bufferAddress = null,
            uint? size = null,
            uint? stride = null
        ) : this()
        {
            if (bufferAddress is not null)
            {
                BufferAddress = bufferAddress.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (stride is not null)
            {
                Stride = stride.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "bufferAddress")]
        public ulong BufferAddress;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "size")]
        public uint Size;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stride")]
        public uint Stride;
    }
}
