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
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_INPUT")]
    public unsafe partial struct AuthenticatedchannelQueryoutputidInput
    {
        public AuthenticatedchannelQueryoutputidInput
        (
            AuthenticatedchannelQueryInput input = default,
            void* deviceHandle = default,
            void* cryptoSessionHandle = default,
            uint outputIDIndex = default
        )
        {
            Input = input;
            DeviceHandle = deviceHandle;
            CryptoSessionHandle = cryptoSessionHandle;
            OutputIDIndex = outputIDIndex;
        }


        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_QUERY_INPUT")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_QUERY_INPUT")]
        [NativeName("Name", "Input")]
        public AuthenticatedchannelQueryInput Input;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "DeviceHandle")]
        public void* DeviceHandle;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "CryptoSessionHandle")]
        public void* CryptoSessionHandle;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OutputIDIndex")]
        public uint OutputIDIndex;
    }
}
