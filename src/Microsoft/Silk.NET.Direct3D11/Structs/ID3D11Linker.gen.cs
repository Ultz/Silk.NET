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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "ID3D11Linker")]
    public unsafe partial struct ID3D11Linker
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11Linker val)
            => Unsafe.As<ID3D11Linker, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (ID3D11Linker* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public ID3D11Linker
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
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Linker*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3D11Linker*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3D11Linker*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3D11Linker* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11Linker*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3D11Linker* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3D11Linker*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
                    ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
                    fixed (byte* pTargetNamePtr = &pTargetName)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
                    fixed (byte* pTargetNamePtr = &pTargetName)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
                    fixed (byte* pTargetNamePtr = &pTargetName)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                        {
                            ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
                    fixed (byte* pTargetNamePtr = &pTargetName)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                        {
                            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                            {
                                ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                    ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                    }
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                    }
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                        }
                    }
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                        }
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
                    ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
                    fixed (byte* pTargetNamePtr = &pTargetName)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
                    fixed (byte* pTargetNamePtr = &pTargetName)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
                    fixed (byte* pTargetNamePtr = &pTargetName)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                        {
                            ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
                    fixed (byte* pTargetNamePtr = &pTargetName)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                        {
                            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                            {
                                ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                    ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                    }
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                    }
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                        }
                    }
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
                    fixed (byte* pEntryNamePtr = &pEntryName)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
                    fixed (byte* pEntryNamePtr = &pEntryName)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
                    fixed (byte* pEntryNamePtr = &pEntryName)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                        {
                            ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
                    fixed (byte* pEntryNamePtr = &pEntryName)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                        {
                            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                            {
                                ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
                    fixed (byte* pEntryNamePtr = &pEntryName)
                    {
                        fixed (byte* pTargetNamePtr = &pTargetName)
                        {
                            ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
                    fixed (byte* pEntryNamePtr = &pEntryName)
                    {
                        fixed (byte* pTargetNamePtr = &pTargetName)
                        {
                            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                            {
                                ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
                    fixed (byte* pEntryNamePtr = &pEntryName)
                    {
                        fixed (byte* pTargetNamePtr = &pTargetName)
                        {
                            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                            {
                                ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
                    fixed (byte* pEntryNamePtr = &pEntryName)
                    {
                        fixed (byte* pTargetNamePtr = &pTargetName)
                        {
                            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                            {
                                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                                {
                                    ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                                }
                            }
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
                    fixed (byte* pEntryNamePtr = &pEntryName)
                    {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
                    fixed (byte* pEntryNamePtr = &pEntryName)
                    {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                        }
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
                    fixed (byte* pEntryNamePtr = &pEntryName)
                    {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                        {
                            ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                        }
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
                    fixed (byte* pEntryNamePtr = &pEntryName)
                    {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                        {
                            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                            {
                                ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                            }
                        }
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                    ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
                    }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                    }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                        }
                    }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                    fixed (byte* pTargetNamePtr = &pTargetName)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
                    }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                    fixed (byte* pTargetNamePtr = &pTargetName)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                        }
                    }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                    fixed (byte* pTargetNamePtr = &pTargetName)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                        {
                            ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                        }
                    }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                    fixed (byte* pTargetNamePtr = &pTargetName)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                        {
                            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                            {
                                ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                            }
                        }
                    }
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                    ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                    }
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                    }
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
                {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                        }
                    }
            Marshal.FreeHGlobal((IntPtr)pTargetNamePtr);
            Marshal.FreeHGlobal((IntPtr)pEntryNamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int UseLibrary(ID3D11ModuleInstance* pLibraryMI)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, int>)LpVtbl[4])(@this, pLibraryMI);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int UseLibrary(ref ID3D11ModuleInstance pLibraryMI)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                fixed (ID3D11ModuleInstance* pLibraryMIPtr = &pLibraryMI)
                {
                    ret = ((delegate* cdecl<ID3D11Linker*, ID3D11ModuleInstance*, int>)LpVtbl[4])(@this, pLibraryMIPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int AddClipPlaneFromCBuffer(uint uCBufferSlot, uint uCBufferEntry)
        {
            fixed (ID3D11Linker* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3D11Linker*, uint, uint, int>)LpVtbl[5])(@this, uCBufferSlot, uCBufferEntry);
                return ret;
            }
        }

    }
}
