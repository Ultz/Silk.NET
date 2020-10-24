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
    [NativeName("Name", "VkPerformanceValueINTEL")]
    public unsafe partial struct PerformanceValueINTEL
    {
        public PerformanceValueINTEL
        (
            PerformanceValueTypeINTEL? type = null,
            PerformanceValueDataINTEL? data = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (data is not null)
            {
                Data = data.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkPerformanceValueTypeINTEL")]
        [NativeName("Type.Name", "VkPerformanceValueTypeINTEL")]
        [NativeName("Name", "type")]
        public PerformanceValueTypeINTEL Type;
/// <summary></summary>
        [NativeName("Type", "VkPerformanceValueDataINTEL")]
        [NativeName("Type.Name", "VkPerformanceValueDataINTEL")]
        [NativeName("Name", "data")]
        public PerformanceValueDataINTEL Data;
    }
}
