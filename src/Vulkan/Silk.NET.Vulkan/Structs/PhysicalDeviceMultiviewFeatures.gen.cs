// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceMultiviewFeatures")]
    public unsafe partial struct PhysicalDeviceMultiviewFeatures
    {
        public PhysicalDeviceMultiviewFeatures
        (
            StructureType sType = StructureType.PhysicalDeviceMultiviewFeatures,
            void* pNext = default,
            Bool32 multiview = default,
            Bool32 multiviewGeometryShader = default,
            Bool32 multiviewTessellationShader = default
        )
        {
            SType = sType;
            PNext = pNext;
            Multiview = multiview;
            MultiviewGeometryShader = multiviewGeometryShader;
            MultiviewTessellationShader = multiviewTessellationShader;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "multiview")]
        public Bool32 Multiview;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "multiviewGeometryShader")]
        public Bool32 MultiviewGeometryShader;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "multiviewTessellationShader")]
        public Bool32 MultiviewTessellationShader;
    }
}
