// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FD882D06-8ABA-4FB8-B849-8BE8B73E14DE")]
    public unsafe partial struct IDWriteFontFallbackBuilder
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddMapping([NativeTypeName("const DWRITE_UNICODE_RANGE *")] DWRITE_UNICODE_RANGE* ranges, [NativeTypeName("UINT32")] uint rangesCount, [NativeTypeName("const WCHAR **")] ushort** targetFamilyNames, [NativeTypeName("UINT32")] uint targetFamilyNamesCount, [NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* fontCollection = null, [NativeTypeName("const WCHAR *")] ushort* localeName = null, [NativeTypeName("const WCHAR *")] ushort* baseFamilyName = null, [NativeTypeName("FLOAT")] float scale = 1.0f)
        {
            return lpVtbl->AddMapping((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this), ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddMappings([NativeTypeName("IDWriteFontFallback *")] IDWriteFontFallback* fontFallback)
        {
            return lpVtbl->AddMappings((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this), fontFallback);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFallback([NativeTypeName("IDWriteFontFallback **")] IDWriteFontFallback** fontFallback)
        {
            return lpVtbl->CreateFontFallback((IDWriteFontFallbackBuilder*)Unsafe.AsPointer(ref this), fontFallback);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFallbackBuilder*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFallbackBuilder*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFallbackBuilder*, uint> Release;

            [NativeTypeName("HRESULT (const DWRITE_UNICODE_RANGE *, UINT32, const WCHAR **, UINT32, IDWriteFontCollection *, const WCHAR *, const WCHAR *, FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFallbackBuilder*, DWRITE_UNICODE_RANGE*, uint, ushort**, uint, IDWriteFontCollection*, ushort*, ushort*, float, int> AddMapping;

            [NativeTypeName("HRESULT (IDWriteFontFallback *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFallbackBuilder*, IDWriteFontFallback*, int> AddMappings;

            [NativeTypeName("HRESULT (IDWriteFontFallback **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFallbackBuilder*, IDWriteFontFallback**, int> CreateFontFallback;
        }
    }
}