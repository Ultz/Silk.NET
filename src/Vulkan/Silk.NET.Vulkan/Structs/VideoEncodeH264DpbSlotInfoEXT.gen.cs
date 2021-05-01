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
    [NativeName("Name", "VkVideoEncodeH264DpbSlotInfoEXT")]
    public unsafe partial struct VideoEncodeH264DpbSlotInfoEXT
    {
        public VideoEncodeH264DpbSlotInfoEXT
        (
            StructureType? sType = StructureType.VideoEncodeH264DpbSlotInfoExt,
            void* pNext = null,
            int8_t? slotIndex = null,
            StdVideoEncodeH264PictureInfo* pStdPictureInfo = null
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

            if (slotIndex is not null)
            {
                SlotIndex = slotIndex.Value;
            }

            if (pStdPictureInfo is not null)
            {
                PStdPictureInfo = pStdPictureInfo;
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
        [NativeName("Type", "int8_t")]
        [NativeName("Type.Name", "int8_t")]
        [NativeName("Name", "slotIndex")]
        public int8_t SlotIndex;
/// <summary></summary>
        [NativeName("Type", "StdVideoEncodeH264PictureInfo*")]
        [NativeName("Type.Name", "StdVideoEncodeH264PictureInfo")]
        [NativeName("Name", "pStdPictureInfo")]
        public StdVideoEncodeH264PictureInfo* PStdPictureInfo;
    }
}
