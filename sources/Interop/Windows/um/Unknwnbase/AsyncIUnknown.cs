// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Unknwnbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000E0000-0000-0000-C000-000000000046")]
    public unsafe partial struct AsyncIUnknown
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((AsyncIUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Begin_QueryInterface([NativeTypeName("const IID &")] Guid* riid)
        {
            return lpVtbl->Begin_QueryInterface((AsyncIUnknown*)Unsafe.AsPointer(ref this), riid);
        }

        [return: NativeTypeName("HRESULT")]
        public int Finish_QueryInterface([NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->Finish_QueryInterface((AsyncIUnknown*)Unsafe.AsPointer(ref this), ppvObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int Begin_AddRef()
        {
            return lpVtbl->Begin_AddRef((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Finish_AddRef()
        {
            return lpVtbl->Finish_AddRef((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Begin_Release()
        {
            return lpVtbl->Begin_Release((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Finish_Release()
        {
            return lpVtbl->Finish_Release((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIUnknown*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIUnknown*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIUnknown*, uint> Release;

            [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIUnknown*, Guid*, int> Begin_QueryInterface;

            [NativeTypeName("HRESULT (void **) __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIUnknown*, void**, int> Finish_QueryInterface;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIUnknown*, int> Begin_AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIUnknown*, uint> Finish_AddRef;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIUnknown*, int> Begin_Release;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<AsyncIUnknown*, uint> Finish_Release;
        }
    }
}