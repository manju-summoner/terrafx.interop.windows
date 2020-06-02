// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9CD-BAF9-11CE-8C82-00AA004BA90B")]
    public unsafe partial struct IBindProtocol
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IBindProtocol*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IBindProtocol*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IBindProtocol*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBinding([NativeTypeName("LPCWSTR")] ushort* szUrl, [NativeTypeName("IBindCtx *")] IBindCtx* pbc, [NativeTypeName("IBinding **")] IBinding** ppb)
        {
            return lpVtbl->CreateBinding((IBindProtocol*)Unsafe.AsPointer(ref this), szUrl, pbc, ppb);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IBindProtocol*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IBindProtocol*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IBindProtocol*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, IBindCtx *, IBinding **) __attribute__((stdcall))")]
            public delegate* stdcall<IBindProtocol*, ushort*, IBindCtx*, IBinding**, int> CreateBinding;
        }
    }
}