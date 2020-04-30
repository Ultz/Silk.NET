// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct QueueFamilyProperties2
    {
        public QueueFamilyProperties2
        (
            StructureType sType = StructureType.QueueFamilyProperties2,
            void* pNext = default,
            QueueFamilyProperties queueFamilyProperties = default
        )
        {
           SType = sType;
           PNext = pNext;
           QueueFamilyProperties = queueFamilyProperties;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public QueueFamilyProperties QueueFamilyProperties;
    }
}
