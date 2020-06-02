// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000102-0000-0000-C000-000000000046")]
    public unsafe partial struct IEnumMoniker
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IEnumMoniker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IEnumMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IEnumMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("IMoniker **")] IMoniker** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return lpVtbl->Next((IEnumMoniker*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return lpVtbl->Skip((IEnumMoniker*)Unsafe.AsPointer(ref this), celt);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return lpVtbl->Reset((IEnumMoniker*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumMoniker **")] IEnumMoniker** ppenum)
        {
            return lpVtbl->Clone((IEnumMoniker*)Unsafe.AsPointer(ref this), ppenum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumMoniker*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IEnumMoniker*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IEnumMoniker*, uint> Release;

            [NativeTypeName("HRESULT (ULONG, IMoniker **, ULONG *) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumMoniker*, uint, IMoniker**, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumMoniker*, uint, int> Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IEnumMoniker*, int> Reset;

            [NativeTypeName("HRESULT (IEnumMoniker **) __attribute__((stdcall))")]
            public delegate* stdcall<IEnumMoniker*, IEnumMoniker**, int> Clone;
        }
    }
}