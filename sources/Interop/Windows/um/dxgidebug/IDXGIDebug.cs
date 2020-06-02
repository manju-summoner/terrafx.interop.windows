// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("119E7452-DE9E-40FE-8806-88F90C12B441")]
    public unsafe partial struct IDXGIDebug
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDXGIDebug*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDXGIDebug*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDXGIDebug*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReportLiveObjects([NativeTypeName("GUID")] Guid apiid, DXGI_DEBUG_RLO_FLAGS flags)
        {
            return lpVtbl->ReportLiveObjects((IDXGIDebug*)Unsafe.AsPointer(ref this), apiid, flags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDebug*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDebug*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDebug*, uint> Release;

            [NativeTypeName("HRESULT (GUID, DXGI_DEBUG_RLO_FLAGS) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIDebug*, Guid, DXGI_DEBUG_RLO_FLAGS, int> ReportLiveObjects;
        }
    }
}