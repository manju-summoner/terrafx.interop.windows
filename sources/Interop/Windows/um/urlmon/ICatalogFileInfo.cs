// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("711C7600-6B48-11D1-B403-00AA00B92AF1")]
    public unsafe partial struct ICatalogFileInfo
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ICatalogFileInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ICatalogFileInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ICatalogFileInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCatalogFile([NativeTypeName("LPSTR *")] sbyte** ppszCatalogFile)
        {
            return lpVtbl->GetCatalogFile((ICatalogFileInfo*)Unsafe.AsPointer(ref this), ppszCatalogFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetJavaTrust([NativeTypeName("void **")] void** ppJavaTrust)
        {
            return lpVtbl->GetJavaTrust((ICatalogFileInfo*)Unsafe.AsPointer(ref this), ppJavaTrust);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ICatalogFileInfo*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ICatalogFileInfo*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ICatalogFileInfo*, uint> Release;

            [NativeTypeName("HRESULT (LPSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<ICatalogFileInfo*, sbyte**, int> GetCatalogFile;

            [NativeTypeName("HRESULT (void **) __attribute__((stdcall))")]
            public delegate* stdcall<ICatalogFileInfo*, void**, int> GetJavaTrust;
        }
    }
}