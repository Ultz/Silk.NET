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
    [NativeName("Name", "VkPipelineViewportCoarseSampleOrderStateCreateInfoNV")]
    public unsafe partial struct PipelineViewportCoarseSampleOrderStateCreateInfoNV
    {
        public PipelineViewportCoarseSampleOrderStateCreateInfoNV
        (
            StructureType sType = StructureType.PipelineViewportCoarseSampleOrderStateCreateInfoNV,
            void* pNext = default,
            CoarseSampleOrderTypeNV sampleOrderType = default,
            uint customSampleOrderCount = default,
            CoarseSampleOrderCustomNV* pCustomSampleOrders = default
        )
        {
            SType = sType;
            PNext = pNext;
            SampleOrderType = sampleOrderType;
            CustomSampleOrderCount = customSampleOrderCount;
            PCustomSampleOrders = pCustomSampleOrders;
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
        [NativeName("Type", "VkCoarseSampleOrderTypeNV")]
        [NativeName("Type.Name", "VkCoarseSampleOrderTypeNV")]
        [NativeName("Name", "sampleOrderType")]
        public CoarseSampleOrderTypeNV SampleOrderType;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "customSampleOrderCount")]
        public uint CustomSampleOrderCount;
/// <summary></summary>
        [NativeName("Type", "VkCoarseSampleOrderCustomNV*")]
        [NativeName("Type.Name", "VkCoarseSampleOrderCustomNV")]
        [NativeName("Name", "pCustomSampleOrders")]
        public CoarseSampleOrderCustomNV* PCustomSampleOrders;
    }
}
