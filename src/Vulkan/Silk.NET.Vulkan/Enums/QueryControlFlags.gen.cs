// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkQueryControlFlags")]
    public enum QueryControlFlags
    {
        [NativeName("Name", "VK_QUERY_CONTROL_PRECISE_BIT")]
        QueryControlPreciseBit = 1,
    }
}
