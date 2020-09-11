// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "IDXGIDisplayControl")]
    public unsafe partial struct IDXGIDisplayControl
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIDisplayControl val)
            => Unsafe.As<IDXGIDisplayControl, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDXGIDisplayControl* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDXGIDisplayControl
        (
            void** lpVtbl = default
        )
        {
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (IDXGIDisplayControl* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDisplayControl*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDXGIDisplayControl* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDXGIDisplayControl*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDXGIDisplayControl* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGIDisplayControl*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDXGIDisplayControl* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDXGIDisplayControl*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDXGIDisplayControl* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIDisplayControl*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDXGIDisplayControl* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIDisplayControl*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int IsStereoEnabled()
        {
            fixed (IDXGIDisplayControl* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIDisplayControl*, int>)LpVtbl[3])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void SetStereoEnabled(int enabled)
        {
            fixed (IDXGIDisplayControl* @this = &this)
            {
                ((delegate* cdecl<IDXGIDisplayControl*, int, void>)LpVtbl[4])(@this, enabled);
            }
        }

    }
}
