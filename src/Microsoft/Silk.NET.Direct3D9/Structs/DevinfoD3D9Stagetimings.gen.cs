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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DDEVINFO_D3D9STAGETIMINGS")]
    public unsafe partial struct DevinfoD3D9Stagetimings
    {
        public DevinfoD3D9Stagetimings
        (
            float memoryProcessingPercent = default,
            float computationProcessingPercent = default
        )
        {
            MemoryProcessingPercent = memoryProcessingPercent;
            ComputationProcessingPercent = computationProcessingPercent;
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MemoryProcessingPercent")]
        public float MemoryProcessingPercent;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "ComputationProcessingPercent")]
        public float ComputationProcessingPercent;
    }
}
