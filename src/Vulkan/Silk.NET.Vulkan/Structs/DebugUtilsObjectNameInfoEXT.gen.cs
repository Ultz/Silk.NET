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
    [NativeName("Name", "VkDebugUtilsObjectNameInfoEXT")]
    public unsafe partial struct DebugUtilsObjectNameInfoEXT
    {
        public DebugUtilsObjectNameInfoEXT
        (
            StructureType? sType = StructureType.DebugUtilsObjectNameInfoExt,
            void* pNext = null,
            ObjectType? objectType = null,
            ulong? objectHandle = null,
            byte* pObjectName = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (objectType is not null)
            {
                ObjectType = objectType.Value;
            }

            if (objectHandle is not null)
            {
                ObjectHandle = objectHandle.Value;
            }

            if (pObjectName is not null)
            {
                PObjectName = pObjectName;
            }
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
        [NativeName("Type", "VkObjectType")]
        [NativeName("Type.Name", "VkObjectType")]
        [NativeName("Name", "objectType")]
        public ObjectType ObjectType;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "objectHandle")]
        public ulong ObjectHandle;
/// <summary></summary>
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "pObjectName")]
        public byte* PObjectName;
    }
}
