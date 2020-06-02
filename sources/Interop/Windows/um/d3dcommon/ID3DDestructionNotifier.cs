// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A06EB39A-50DA-425B-8C31-4EECD6C270F3")]
    public unsafe partial struct ID3DDestructionNotifier
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterDestructionCallback([NativeTypeName("PFN_DESTRUCTION_CALLBACK")] delegate* stdcall<void*, void> callbackFn, [NativeTypeName("void *")] void* pData, [NativeTypeName("UINT *")] uint* pCallbackID)
        {
            return lpVtbl->RegisterDestructionCallback((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), callbackFn, pData, pCallbackID);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterDestructionCallback([NativeTypeName("UINT")] uint callbackID)
        {
            return lpVtbl->UnregisterDestructionCallback((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), callbackID);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3DDestructionNotifier*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3DDestructionNotifier*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3DDestructionNotifier*, uint> Release;

            [NativeTypeName("HRESULT (PFN_DESTRUCTION_CALLBACK, void *, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3DDestructionNotifier*, delegate* stdcall<void*, void>, void*, uint*, int> RegisterDestructionCallback;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3DDestructionNotifier*, uint, int> UnregisterDestructionCallback;
        }
    }
}