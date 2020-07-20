// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceExternalBufferInfoKHR")]
    public unsafe partial struct PhysicalDeviceExternalBufferInfoKHR
    {
        public PhysicalDeviceExternalBufferInfoKHR
        (
            StructureType sType = StructureType.PhysicalDeviceExternalBufferInfo,
            void* pNext = default,
            BufferCreateFlags flags = default,
            BufferUsageFlags usage = default,
            ExternalMemoryHandleTypeFlags handleType = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            Usage = usage;
            HandleType = handleType;
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkBufferCreateFlags")]
        [NativeName("Type.Name", "VkBufferCreateFlags")]
        [NativeName("Name", "flags")]
        public BufferCreateFlags Flags;
/// <summary></summary>
        [NativeName("Type", "VkBufferUsageFlags")]
        [NativeName("Type.Name", "VkBufferUsageFlags")]
        [NativeName("Name", "usage")]
        public BufferUsageFlags Usage;
/// <summary></summary>
        [NativeName("Type", "VkExternalMemoryHandleTypeFlagBits")]
        [NativeName("Type.Name", "VkExternalMemoryHandleTypeFlagBits")]
        [NativeName("Name", "handleType")]
        public ExternalMemoryHandleTypeFlags HandleType;
    }
}
