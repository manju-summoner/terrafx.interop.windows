// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2CD906AA-12E2-11DC-9FED-001143A055F9")]
    public unsafe partial struct ID2D1BitmapBrush
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), factory);
        }

        public void SetOpacity([NativeTypeName("FLOAT")] float opacity)
        {
            lpVtbl->SetOpacity((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), opacity);
        }

        public void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            lpVtbl->SetTransform((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), transform);
        }

        [return: NativeTypeName("FLOAT")]
        public float GetOpacity()
        {
            return lpVtbl->GetOpacity((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this));
        }

        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            lpVtbl->GetTransform((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), transform);
        }

        public void SetExtendModeX(D2D1_EXTEND_MODE extendModeX)
        {
            lpVtbl->SetExtendModeX((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), extendModeX);
        }

        public void SetExtendModeY(D2D1_EXTEND_MODE extendModeY)
        {
            lpVtbl->SetExtendModeY((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), extendModeY);
        }

        public void SetInterpolationMode(D2D1_BITMAP_INTERPOLATION_MODE interpolationMode)
        {
            lpVtbl->SetInterpolationMode((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), interpolationMode);
        }

        public void SetBitmap([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap)
        {
            lpVtbl->SetBitmap((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), bitmap);
        }

        public D2D1_EXTEND_MODE GetExtendModeX()
        {
            return lpVtbl->GetExtendModeX((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this));
        }

        public D2D1_EXTEND_MODE GetExtendModeY()
        {
            return lpVtbl->GetExtendModeY((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this));
        }

        public D2D1_BITMAP_INTERPOLATION_MODE GetInterpolationMode()
        {
            return lpVtbl->GetInterpolationMode((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this));
        }

        public void GetBitmap([NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            lpVtbl->GetBitmap((ID2D1BitmapBrush*)Unsafe.AsPointer(ref this), bitmap);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BitmapBrush*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BitmapBrush*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BitmapBrush*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BitmapBrush*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("void (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BitmapBrush*, float, void> SetOpacity;

            [NativeTypeName("void (const D2D1_MATRIX_3X2_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BitmapBrush*, D2D_MATRIX_3X2_F*, void> SetTransform;

            [NativeTypeName("FLOAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BitmapBrush*, float> GetOpacity;

            [NativeTypeName("void (D2D1_MATRIX_3X2_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BitmapBrush*, D2D_MATRIX_3X2_F*, void> GetTransform;

            [NativeTypeName("void (D2D1_EXTEND_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BitmapBrush*, D2D1_EXTEND_MODE, void> SetExtendModeX;

            [NativeTypeName("void (D2D1_EXTEND_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BitmapBrush*, D2D1_EXTEND_MODE, void> SetExtendModeY;

            [NativeTypeName("void (D2D1_BITMAP_INTERPOLATION_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BitmapBrush*, D2D1_BITMAP_INTERPOLATION_MODE, void> SetInterpolationMode;

            [NativeTypeName("void (ID2D1Bitmap *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BitmapBrush*, ID2D1Bitmap*, void> SetBitmap;

            [NativeTypeName("D2D1_EXTEND_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BitmapBrush*, D2D1_EXTEND_MODE> GetExtendModeX;

            [NativeTypeName("D2D1_EXTEND_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BitmapBrush*, D2D1_EXTEND_MODE> GetExtendModeY;

            [NativeTypeName("D2D1_BITMAP_INTERPOLATION_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BitmapBrush*, D2D1_BITMAP_INTERPOLATION_MODE> GetInterpolationMode;

            [NativeTypeName("void (ID2D1Bitmap **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1BitmapBrush*, ID2D1Bitmap**, void> GetBitmap;
        }
    }
}