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
    [NativeName("Name", "VkPipelineExecutableStatisticKHR")]
    public unsafe partial struct PipelineExecutableStatisticKHR
    {
        public PipelineExecutableStatisticKHR
        (
            StructureType? sType = StructureType.PipelineExecutableStatisticKhr,
            void* pNext = null,
            PipelineExecutableStatisticFormatKHR? format = null,
            PipelineExecutableStatisticValueKHR? value = null
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

            if (format is not null)
            {
                Format = format.Value;
            }

            if (value is not null)
            {
                Value = value.Value;
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
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "name")]
        public fixed byte Name[256];
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "description")]
        public fixed byte Description[256];
/// <summary></summary>
        [NativeName("Type", "VkPipelineExecutableStatisticFormatKHR")]
        [NativeName("Type.Name", "VkPipelineExecutableStatisticFormatKHR")]
        [NativeName("Name", "format")]
        public PipelineExecutableStatisticFormatKHR Format;
/// <summary></summary>
        [NativeName("Type", "VkPipelineExecutableStatisticValueKHR")]
        [NativeName("Type.Name", "VkPipelineExecutableStatisticValueKHR")]
        [NativeName("Name", "value")]
        public PipelineExecutableStatisticValueKHR Value;
    }
}
