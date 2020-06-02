// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9EB-BAF9-11CE-8C82-00AA004BA90B")]
    public unsafe partial struct IInternetPriority
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IInternetPriority*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IInternetPriority*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IInternetPriority*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPriority([NativeTypeName("LONG")] int nPriority)
        {
            return lpVtbl->SetPriority((IInternetPriority*)Unsafe.AsPointer(ref this), nPriority);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPriority([NativeTypeName("LONG *")] int* pnPriority)
        {
            return lpVtbl->GetPriority((IInternetPriority*)Unsafe.AsPointer(ref this), pnPriority);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetPriority*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IInternetPriority*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IInternetPriority*, uint> Release;

            [NativeTypeName("HRESULT (LONG) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetPriority*, int, int> SetPriority;

            [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IInternetPriority*, int*, int> GetPriority;
        }
    }
}