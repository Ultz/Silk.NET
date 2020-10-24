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
    [NativeName("Name", "VkPhysicalDeviceMultiviewFeaturesKHR")]
    public unsafe partial struct PhysicalDeviceMultiviewFeaturesKHR
    {
        public PhysicalDeviceMultiviewFeaturesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceMultiviewFeatures,
            void* pNext = null,
            Bool32? multiview = null,
            Bool32? multiviewGeometryShader = null,
            Bool32? multiviewTessellationShader = null
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

            if (multiview is not null)
            {
                Multiview = multiview.Value;
            }

            if (multiviewGeometryShader is not null)
            {
                MultiviewGeometryShader = multiviewGeometryShader.Value;
            }

            if (multiviewTessellationShader is not null)
            {
                MultiviewTessellationShader = multiviewTessellationShader.Value;
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
