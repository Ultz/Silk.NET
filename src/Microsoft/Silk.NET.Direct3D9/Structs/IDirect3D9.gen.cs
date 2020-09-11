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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "IDirect3D9")]
    public unsafe partial struct IDirect3D9
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3D9 val)
            => Unsafe.As<IDirect3D9, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDirect3D9* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDirect3D9
        (
            char* version = default,
            void** lpVtbl = default
        )
        {
            Version = version;
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "Version")]
        public char* Version;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3D9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDirect3D9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDirect3D9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDirect3D9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDirect3D9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3D9*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDirect3D9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3D9*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RegisterSoftwareDevice(void* pInitializeFunction)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3D9*, void*, int>)LpVtbl[3])(@this, pInitializeFunction);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int RegisterSoftwareDevice<T0>(ref T0 pInitializeFunction) where T0 : unmanaged
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                fixed (T0* pInitializeFunctionPtr = &pInitializeFunction)
                {
                    ret = ((delegate* cdecl<IDirect3D9*, T0*, int>)LpVtbl[3])(@this, pInitializeFunctionPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetAdapterCount()
        {
            fixed (IDirect3D9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3D9*, uint>)LpVtbl[4])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetAdapterIdentifier(uint Adapter, uint Flags, AdapterIdentifier9* pIdentifier)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3D9*, uint, uint, AdapterIdentifier9*, int>)LpVtbl[5])(@this, Adapter, Flags, pIdentifier);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetAdapterIdentifier(uint Adapter, uint Flags, ref AdapterIdentifier9 pIdentifier)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                fixed (AdapterIdentifier9* pIdentifierPtr = &pIdentifier)
                {
                    ret = ((delegate* cdecl<IDirect3D9*, uint, uint, AdapterIdentifier9*, int>)LpVtbl[5])(@this, Adapter, Flags, pIdentifierPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetAdapterModeCount(uint Adapter, Format Format)
        {
            fixed (IDirect3D9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3D9*, uint, Format, uint>)LpVtbl[6])(@this, Adapter, Format);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int EnumAdapterModes(uint Adapter, Format Format, uint Mode, Displaymode* pMode)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3D9*, uint, Format, uint, Displaymode*, int>)LpVtbl[7])(@this, Adapter, Format, Mode, pMode);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int EnumAdapterModes(uint Adapter, Format Format, uint Mode, ref Displaymode pMode)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                fixed (Displaymode* pModePtr = &pMode)
                {
                    ret = ((delegate* cdecl<IDirect3D9*, uint, Format, uint, Displaymode*, int>)LpVtbl[7])(@this, Adapter, Format, Mode, pModePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetAdapterDisplayMode(uint Adapter, Displaymode* pMode)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3D9*, uint, Displaymode*, int>)LpVtbl[8])(@this, Adapter, pMode);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetAdapterDisplayMode(uint Adapter, ref Displaymode pMode)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                fixed (Displaymode* pModePtr = &pMode)
                {
                    ret = ((delegate* cdecl<IDirect3D9*, uint, Displaymode*, int>)LpVtbl[8])(@this, Adapter, pModePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int CheckDeviceType(uint iAdapter, Devtype DevType, Format DisplayFormat, Format BackBufferFormat, int bWindowed)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3D9*, uint, Devtype, Format, Format, int, int>)LpVtbl[9])(@this, iAdapter, DevType, DisplayFormat, BackBufferFormat, bWindowed);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int CheckDeviceFormat(uint Adapter, Devtype DeviceType, Format AdapterFormat, uint Usage, Resourcetype RType, Format CheckFormat)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3D9*, uint, Devtype, Format, uint, Resourcetype, Format, int>)LpVtbl[10])(@this, Adapter, DeviceType, AdapterFormat, Usage, RType, CheckFormat);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckDeviceMultiSampleType(uint Adapter, Devtype DeviceType, Format SurfaceFormat, int Windowed, MultisampleType MultiSampleType, uint* pQualityLevels)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3D9*, uint, Devtype, Format, int, MultisampleType, uint*, int>)LpVtbl[11])(@this, Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevels);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int CheckDeviceMultiSampleType(uint Adapter, Devtype DeviceType, Format SurfaceFormat, int Windowed, MultisampleType MultiSampleType, ref uint pQualityLevels)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                fixed (uint* pQualityLevelsPtr = &pQualityLevels)
                {
                    ret = ((delegate* cdecl<IDirect3D9*, uint, Devtype, Format, int, MultisampleType, uint*, int>)LpVtbl[11])(@this, Adapter, DeviceType, SurfaceFormat, Windowed, MultiSampleType, pQualityLevelsPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int CheckDepthStencilMatch(uint Adapter, Devtype DeviceType, Format AdapterFormat, Format RenderTargetFormat, Format DepthStencilFormat)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3D9*, uint, Devtype, Format, Format, Format, int>)LpVtbl[12])(@this, Adapter, DeviceType, AdapterFormat, RenderTargetFormat, DepthStencilFormat);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int CheckDeviceFormatConversion(uint Adapter, Devtype DeviceType, Format SourceFormat, Format TargetFormat)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3D9*, uint, Devtype, Format, Format, int>)LpVtbl[13])(@this, Adapter, DeviceType, SourceFormat, TargetFormat);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDeviceCaps(uint Adapter, Devtype DeviceType, Caps9* pCaps)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3D9*, uint, Devtype, Caps9*, int>)LpVtbl[14])(@this, Adapter, DeviceType, pCaps);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDeviceCaps(uint Adapter, Devtype DeviceType, ref Caps9 pCaps)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                fixed (Caps9* pCapsPtr = &pCaps)
                {
                    ret = ((delegate* cdecl<IDirect3D9*, uint, Devtype, Caps9*, int>)LpVtbl[14])(@this, Adapter, DeviceType, pCapsPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public IntPtr GetAdapterMonitor(uint Adapter)
        {
            fixed (IDirect3D9* @this = &this)
            {
                IntPtr ret = default;
                ret = ((delegate* cdecl<IDirect3D9*, uint, IntPtr>)LpVtbl[15])(@this, Adapter);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateDevice(uint Adapter, Devtype DeviceType, IntPtr hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, IDirect3DDevice9** ppReturnedDeviceInterface)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3D9*, uint, Devtype, IntPtr, uint, PresentParameters*, IDirect3DDevice9**, int>)LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ppReturnedDeviceInterface);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateDevice(uint Adapter, Devtype DeviceType, IntPtr hFocusWindow, uint BehaviorFlags, PresentParameters* pPresentationParameters, ref IDirect3DDevice9* ppReturnedDeviceInterface)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DDevice9** ppReturnedDeviceInterfacePtr = &ppReturnedDeviceInterface)
                {
                    ret = ((delegate* cdecl<IDirect3D9*, uint, Devtype, IntPtr, uint, PresentParameters*, IDirect3DDevice9**, int>)LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParameters, ppReturnedDeviceInterfacePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateDevice(uint Adapter, Devtype DeviceType, IntPtr hFocusWindow, uint BehaviorFlags, ref PresentParameters pPresentationParameters, IDirect3DDevice9** ppReturnedDeviceInterface)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
                {
                    ret = ((delegate* cdecl<IDirect3D9*, uint, Devtype, IntPtr, uint, PresentParameters*, IDirect3DDevice9**, int>)LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, ppReturnedDeviceInterface);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CreateDevice(uint Adapter, Devtype DeviceType, IntPtr hFocusWindow, uint BehaviorFlags, ref PresentParameters pPresentationParameters, ref IDirect3DDevice9* ppReturnedDeviceInterface)
        {
            fixed (IDirect3D9* @this = &this)
            {
                int ret = default;
                fixed (PresentParameters* pPresentationParametersPtr = &pPresentationParameters)
                {
                    fixed (IDirect3DDevice9** ppReturnedDeviceInterfacePtr = &ppReturnedDeviceInterface)
                    {
                        ret = ((delegate* cdecl<IDirect3D9*, uint, Devtype, IntPtr, uint, PresentParameters*, IDirect3DDevice9**, int>)LpVtbl[16])(@this, Adapter, DeviceType, hFocusWindow, BehaviorFlags, pPresentationParametersPtr, ppReturnedDeviceInterfacePtr);
                    }
                }
                return ret;
            }
        }

    }
}
