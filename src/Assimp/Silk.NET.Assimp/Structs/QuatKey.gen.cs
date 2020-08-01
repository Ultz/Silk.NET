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

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiQuatKey")]
    public unsafe partial struct QuatKey
    {
        public QuatKey
        (
            double mTime = default,
            System.Numerics.Quaternion mValue = default
        )
        {
            MTime = mTime;
            MValue = mValue;
        }


        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "mTime")]
        public double MTime;

        [NativeName("Type", "aiQuaternion")]
        [NativeName("Type.Name", "aiQuaternion")]
        [NativeName("Name", "mValue")]
        public System.Numerics.Quaternion MValue;
    }
}
