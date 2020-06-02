// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8A6BB301-7E7E-41F4-A8E0-5B32F7F99B18")]
    public unsafe partial struct IDXGIOutput3
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDXGIOutput3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDXGIOutput3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDXGIOutput3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((IDXGIOutput3*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return lpVtbl->SetPrivateDataInterface((IDXGIOutput3*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((IDXGIOutput3*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return lpVtbl->GetParent((IDXGIOutput3*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("DXGI_OUTPUT_DESC *")] DXGI_OUTPUT_DESC* pDesc)
        {
            return lpVtbl->GetDesc((IDXGIOutput3*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayModeList(DXGI_FORMAT EnumFormat, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT *")] uint* pNumModes, [NativeTypeName("DXGI_MODE_DESC *")] DXGI_MODE_DESC* pDesc)
        {
            return lpVtbl->GetDisplayModeList((IDXGIOutput3*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindClosestMatchingMode([NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pModeToMatch, [NativeTypeName("DXGI_MODE_DESC *")] DXGI_MODE_DESC* pClosestMatch, [NativeTypeName("IUnknown *")] IUnknown* pConcernedDevice)
        {
            return lpVtbl->FindClosestMatchingMode((IDXGIOutput3*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitForVBlank()
        {
            return lpVtbl->WaitForVBlank((IDXGIOutput3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int TakeOwnership([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("BOOL")] int Exclusive)
        {
            return lpVtbl->TakeOwnership((IDXGIOutput3*)Unsafe.AsPointer(ref this), pDevice, Exclusive);
        }

        public void ReleaseOwnership()
        {
            lpVtbl->ReleaseOwnership((IDXGIOutput3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGammaControlCapabilities([NativeTypeName("DXGI_GAMMA_CONTROL_CAPABILITIES *")] DXGI_GAMMA_CONTROL_CAPABILITIES* pGammaCaps)
        {
            return lpVtbl->GetGammaControlCapabilities((IDXGIOutput3*)Unsafe.AsPointer(ref this), pGammaCaps);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGammaControl([NativeTypeName("const DXGI_GAMMA_CONTROL *")] DXGI_GAMMA_CONTROL* pArray)
        {
            return lpVtbl->SetGammaControl((IDXGIOutput3*)Unsafe.AsPointer(ref this), pArray);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGammaControl([NativeTypeName("DXGI_GAMMA_CONTROL *")] DXGI_GAMMA_CONTROL* pArray)
        {
            return lpVtbl->GetGammaControl((IDXGIOutput3*)Unsafe.AsPointer(ref this), pArray);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDisplaySurface([NativeTypeName("IDXGISurface *")] IDXGISurface* pScanoutSurface)
        {
            return lpVtbl->SetDisplaySurface((IDXGIOutput3*)Unsafe.AsPointer(ref this), pScanoutSurface);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplaySurfaceData([NativeTypeName("IDXGISurface *")] IDXGISurface* pDestination)
        {
            return lpVtbl->GetDisplaySurfaceData((IDXGIOutput3*)Unsafe.AsPointer(ref this), pDestination);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameStatistics([NativeTypeName("DXGI_FRAME_STATISTICS *")] DXGI_FRAME_STATISTICS* pStats)
        {
            return lpVtbl->GetFrameStatistics((IDXGIOutput3*)Unsafe.AsPointer(ref this), pStats);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayModeList1(DXGI_FORMAT EnumFormat, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("UINT *")] uint* pNumModes, [NativeTypeName("DXGI_MODE_DESC1 *")] DXGI_MODE_DESC1* pDesc)
        {
            return lpVtbl->GetDisplayModeList1((IDXGIOutput3*)Unsafe.AsPointer(ref this), EnumFormat, Flags, pNumModes, pDesc);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindClosestMatchingMode1([NativeTypeName("const DXGI_MODE_DESC1 *")] DXGI_MODE_DESC1* pModeToMatch, [NativeTypeName("DXGI_MODE_DESC1 *")] DXGI_MODE_DESC1* pClosestMatch, [NativeTypeName("IUnknown *")] IUnknown* pConcernedDevice)
        {
            return lpVtbl->FindClosestMatchingMode1((IDXGIOutput3*)Unsafe.AsPointer(ref this), pModeToMatch, pClosestMatch, pConcernedDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplaySurfaceData1([NativeTypeName("IDXGIResource *")] IDXGIResource* pDestination)
        {
            return lpVtbl->GetDisplaySurfaceData1((IDXGIOutput3*)Unsafe.AsPointer(ref this), pDestination);
        }

        [return: NativeTypeName("HRESULT")]
        public int DuplicateOutput([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("IDXGIOutputDuplication **")] IDXGIOutputDuplication** ppOutputDuplication)
        {
            return lpVtbl->DuplicateOutput((IDXGIOutput3*)Unsafe.AsPointer(ref this), pDevice, ppOutputDuplication);
        }

        [return: NativeTypeName("BOOL")]
        public int SupportsOverlays()
        {
            return lpVtbl->SupportsOverlays((IDXGIOutput3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckOverlaySupport(DXGI_FORMAT EnumFormat, [NativeTypeName("IUnknown *")] IUnknown* pConcernedDevice, [NativeTypeName("UINT *")] uint* pFlags)
        {
            return lpVtbl->CheckOverlaySupport((IDXGIOutput3*)Unsafe.AsPointer(ref this), EnumFormat, pConcernedDevice, pFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, Guid*, void**, int> GetParent;

            [NativeTypeName("HRESULT (DXGI_OUTPUT_DESC *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, DXGI_OUTPUT_DESC*, int> GetDesc;

            [NativeTypeName("HRESULT (DXGI_FORMAT, UINT, UINT *, DXGI_MODE_DESC *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, DXGI_FORMAT, uint, uint*, DXGI_MODE_DESC*, int> GetDisplayModeList;

            [NativeTypeName("HRESULT (const DXGI_MODE_DESC *, DXGI_MODE_DESC *, IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, DXGI_MODE_DESC*, DXGI_MODE_DESC*, IUnknown*, int> FindClosestMatchingMode;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, int> WaitForVBlank;

            [NativeTypeName("HRESULT (IUnknown *, BOOL) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, IUnknown*, int, int> TakeOwnership;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, void> ReleaseOwnership;

            [NativeTypeName("HRESULT (DXGI_GAMMA_CONTROL_CAPABILITIES *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, DXGI_GAMMA_CONTROL_CAPABILITIES*, int> GetGammaControlCapabilities;

            [NativeTypeName("HRESULT (const DXGI_GAMMA_CONTROL *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, DXGI_GAMMA_CONTROL*, int> SetGammaControl;

            [NativeTypeName("HRESULT (DXGI_GAMMA_CONTROL *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, DXGI_GAMMA_CONTROL*, int> GetGammaControl;

            [NativeTypeName("HRESULT (IDXGISurface *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, IDXGISurface*, int> SetDisplaySurface;

            [NativeTypeName("HRESULT (IDXGISurface *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, IDXGISurface*, int> GetDisplaySurfaceData;

            [NativeTypeName("HRESULT (DXGI_FRAME_STATISTICS *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, DXGI_FRAME_STATISTICS*, int> GetFrameStatistics;

            [NativeTypeName("HRESULT (DXGI_FORMAT, UINT, UINT *, DXGI_MODE_DESC1 *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, DXGI_FORMAT, uint, uint*, DXGI_MODE_DESC1*, int> GetDisplayModeList1;

            [NativeTypeName("HRESULT (const DXGI_MODE_DESC1 *, DXGI_MODE_DESC1 *, IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, DXGI_MODE_DESC1*, DXGI_MODE_DESC1*, IUnknown*, int> FindClosestMatchingMode1;

            [NativeTypeName("HRESULT (IDXGIResource *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, IDXGIResource*, int> GetDisplaySurfaceData1;

            [NativeTypeName("HRESULT (IUnknown *, IDXGIOutputDuplication **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, IUnknown*, IDXGIOutputDuplication**, int> DuplicateOutput;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, int> SupportsOverlays;

            [NativeTypeName("HRESULT (DXGI_FORMAT, IUnknown *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIOutput3*, DXGI_FORMAT, IUnknown*, uint*, int> CheckOverlaySupport;
        }
    }
}