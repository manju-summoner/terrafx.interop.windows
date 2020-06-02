// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_ALPHA_MODE;
using static TerraFX.Interop.D2D1_BITMAP_INTERPOLATION_MODE;
using static TerraFX.Interop.D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS;
using static TerraFX.Interop.D2D1_COMPOSITE_MODE;
using static TerraFX.Interop.D2D1_DRAW_TEXT_OPTIONS;
using static TerraFX.Interop.D2D1_EXTEND_MODE;
using static TerraFX.Interop.D2D1_GAMMA;
using static TerraFX.Interop.D2D1_IMAGE_SOURCE_LOADING_OPTIONS;
using static TerraFX.Interop.D2D1_INTERPOLATION_MODE;
using static TerraFX.Interop.DWRITE_MEASURING_MODE;

namespace TerraFX.Interop
{
    [Guid("394EA6A3-0C34-4321-950B-6CA20F0BE6C7")]
    public unsafe partial struct ID2D1DeviceContext2
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap([NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [NativeTypeName("const D2D1_BITMAP_PROPERTIES &")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return CreateBitmap(size, null, 0, bitmapProperties, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromWicBitmap([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return CreateBitmapFromWicBitmap(wicBitmapSource, null, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("ID2D1BitmapBrush **")] ID2D1BitmapBrush** bitmapBrush)
        {
            return CreateBitmapBrush(bitmap, null, null, bitmapBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES &")] D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, [NativeTypeName("ID2D1BitmapBrush **")] ID2D1BitmapBrush** bitmapBrush)
        {
            return CreateBitmapBrush(bitmap, bitmapBrushProperties, null, bitmapBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSolidColorBrush([NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* color, [NativeTypeName("ID2D1SolidColorBrush **")] ID2D1SolidColorBrush** solidColorBrush)
        {
            return CreateSolidColorBrush(color, null, solidColorBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGradientStopCollection([NativeTypeName("const D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount, [NativeTypeName("ID2D1GradientStopCollection **")] ID2D1GradientStopCollection** gradientStopCollection)
        {
            return CreateGradientStopCollection(gradientStops, gradientStopsCount, D2D1_GAMMA_2_2, D2D1_EXTEND_MODE_CLAMP, gradientStopCollection);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLinearGradientBrush([NativeTypeName("const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES &")] D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, [NativeTypeName("ID2D1GradientStopCollection *")] ID2D1GradientStopCollection* gradientStopCollection, [NativeTypeName("ID2D1LinearGradientBrush **")] ID2D1LinearGradientBrush** linearGradientBrush)
        {
            return CreateLinearGradientBrush(linearGradientBrushProperties, null, gradientStopCollection, linearGradientBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRadialGradientBrush([NativeTypeName("const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES &")] D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, [NativeTypeName("ID2D1GradientStopCollection *")] ID2D1GradientStopCollection* gradientStopCollection, [NativeTypeName("ID2D1RadialGradientBrush **")] ID2D1RadialGradientBrush** radialGradientBrush)
        {
            return CreateRadialGradientBrush(radialGradientBrushProperties, null, gradientStopCollection, radialGradientBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return CreateCompatibleRenderTarget(null, null, null, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE, bitmapRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F desiredSize, [NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return CreateCompatibleRenderTarget(&desiredSize, null, null, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE, bitmapRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F desiredSize, [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U desiredPixelSize, [NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return CreateCompatibleRenderTarget(&desiredSize, &desiredPixelSize, null, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE, bitmapRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F desiredSize, [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U desiredPixelSize, D2D1_PIXEL_FORMAT desiredFormat, [NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return CreateCompatibleRenderTarget(&desiredSize, &desiredPixelSize, &desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE, bitmapRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F desiredSize, [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U desiredPixelSize, D2D1_PIXEL_FORMAT desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, [NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return CreateCompatibleRenderTarget(&desiredSize, &desiredPixelSize, &desiredFormat, options, bitmapRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLayer([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F size, [NativeTypeName("ID2D1Layer **")] ID2D1Layer** layer)
        {
            return CreateLayer(&size, layer);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLayer([NativeTypeName("ID2D1Layer **")] ID2D1Layer** layer)
        {
            return CreateLayer(null, layer);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromWicBitmap([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, [NativeTypeName("ID2D1Bitmap1 **")] ID2D1Bitmap1** bitmap)
        {
            return CreateBitmapFromWicBitmap(wicBitmapSource, null, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateImageBrush([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("const D2D1_IMAGE_BRUSH_PROPERTIES &")] D2D1_IMAGE_BRUSH_PROPERTIES* imageBrushProperties, [NativeTypeName("ID2D1ImageBrush **")] ID2D1ImageBrush** imageBrush)
        {
            return CreateImageBrush(image, imageBrushProperties, null, imageBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("ID2D1BitmapBrush1 **")] ID2D1BitmapBrush1** bitmapBrush)
        {
            return CreateBitmapBrush(bitmap, null, null, bitmapBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES1 &")] D2D1_BITMAP_BRUSH_PROPERTIES1* bitmapBrushProperties, [NativeTypeName("ID2D1BitmapBrush1 **")] ID2D1BitmapBrush1** bitmapBrush)
        {
            return CreateBitmapBrush(bitmap, bitmapBrushProperties, null, bitmapBrush);
        }

        public void DrawImage([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* imageRectangle = null, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            ID2D1Image* output = null;

            effect->GetOutput(&output);
            DrawImage(output, targetOffset, imageRectangle, interpolationMode, compositeMode);
            output->Release();
        }

        public void DrawImage([NativeTypeName("ID2D1Image *")] ID2D1Image* image, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(image, null, null, interpolationMode, compositeMode);
        }

        public void DrawImage([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(effect, null, null, interpolationMode, compositeMode);
        }

        public void DrawImage([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(image, &targetOffset, null, interpolationMode, compositeMode);
        }

        public void DrawImage([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(effect, &targetOffset, null, interpolationMode, compositeMode);
        }

        public void DrawImage([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset, [NativeTypeName("const D2D1_RECT_F &")] D2D_RECT_F* imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(image, &targetOffset, imageRectangle, interpolationMode, compositeMode);
        }

        public void DrawImage([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset, [NativeTypeName("const D2D1_RECT_F &")] D2D_RECT_F* imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(effect, &targetOffset, imageRectangle, interpolationMode, compositeMode);
        }

        public void DrawGdiMetafile([NativeTypeName("ID2D1GdiMetafile *")] ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset)
        {
            DrawGdiMetafile(gdiMetafile, &targetOffset);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateImageSourceFromWic([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, D2D1_IMAGE_SOURCE_LOADING_OPTIONS loadingOptions, [NativeTypeName("ID2D1ImageSourceFromWic **")] ID2D1ImageSourceFromWic** imageSource)
        {
            return CreateImageSourceFromWic(wicBitmapSource, loadingOptions, D2D1_ALPHA_MODE_UNKNOWN, imageSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateImageSourceFromWic([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, [NativeTypeName("ID2D1ImageSourceFromWic **")] ID2D1ImageSourceFromWic** imageSource)
        {
            return CreateImageSourceFromWic(wicBitmapSource, D2D1_IMAGE_SOURCE_LOADING_OPTIONS_NONE, D2D1_ALPHA_MODE_UNKNOWN, imageSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap([NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [NativeTypeName("const void *")] void* srcData, [NativeTypeName("UINT32")] uint pitch, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return lpVtbl->CreateBitmap((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), size, srcData, pitch, bitmapProperties, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromWicBitmap([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return lpVtbl->CreateBitmapFromWicBitmap((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), wicBitmapSource, bitmapProperties, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSharedBitmap([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void *")] void* data, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, [NativeTypeName("ID2D1Bitmap **")] ID2D1Bitmap** bitmap)
        {
            return lpVtbl->CreateSharedBitmap((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), riid, data, bitmapProperties, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES *")] D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1BitmapBrush **")] ID2D1BitmapBrush** bitmapBrush)
        {
            return lpVtbl->CreateBitmapBrush((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSolidColorBrush([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1SolidColorBrush **")] ID2D1SolidColorBrush** solidColorBrush)
        {
            return lpVtbl->CreateSolidColorBrush((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), color, brushProperties, solidColorBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGradientStopCollection([NativeTypeName("const D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, [NativeTypeName("ID2D1GradientStopCollection **")] ID2D1GradientStopCollection** gradientStopCollection)
        {
            return lpVtbl->CreateGradientStopCollection((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLinearGradientBrush([NativeTypeName("const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES *")] D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1GradientStopCollection *")] ID2D1GradientStopCollection* gradientStopCollection, [NativeTypeName("ID2D1LinearGradientBrush **")] ID2D1LinearGradientBrush** linearGradientBrush)
        {
            return lpVtbl->CreateLinearGradientBrush((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRadialGradientBrush([NativeTypeName("const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES *")] D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1GradientStopCollection *")] ID2D1GradientStopCollection* gradientStopCollection, [NativeTypeName("ID2D1RadialGradientBrush **")] ID2D1RadialGradientBrush** radialGradientBrush)
        {
            return lpVtbl->CreateRadialGradientBrush((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCompatibleRenderTarget([NativeTypeName("const D2D1_SIZE_F *")] D2D_SIZE_F* desiredSize, [NativeTypeName("const D2D1_SIZE_U *")] D2D_SIZE_U* desiredPixelSize, [NativeTypeName("const D2D1_PIXEL_FORMAT *")] D2D1_PIXEL_FORMAT* desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, [NativeTypeName("ID2D1BitmapRenderTarget **")] ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return lpVtbl->CreateCompatibleRenderTarget((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLayer([NativeTypeName("const D2D1_SIZE_F *")] D2D_SIZE_F* size, [NativeTypeName("ID2D1Layer **")] ID2D1Layer** layer)
        {
            return lpVtbl->CreateLayer((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), size, layer);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateMesh([NativeTypeName("ID2D1Mesh **")] ID2D1Mesh** mesh)
        {
            return lpVtbl->CreateMesh((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), mesh);
        }

        public void DrawLine([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            lpVtbl->DrawLine((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), point0, point1, brush, strokeWidth, strokeStyle);
        }

        public void DrawRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            lpVtbl->DrawRectangle((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), rect, brush, strokeWidth, strokeStyle);
        }

        public void FillRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            lpVtbl->FillRectangle((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), rect, brush);
        }

        public void DrawRoundedRectangle([NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            lpVtbl->DrawRoundedRectangle((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), roundedRect, brush, strokeWidth, strokeStyle);
        }

        public void FillRoundedRectangle([NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            lpVtbl->FillRoundedRectangle((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), roundedRect, brush);
        }

        public void DrawEllipse([NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            lpVtbl->DrawEllipse((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), ellipse, brush, strokeWidth, strokeStyle);
        }

        public void FillEllipse([NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            lpVtbl->FillEllipse((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), ellipse, brush);
        }

        public void DrawGeometry([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("FLOAT")] float strokeWidth = 1.0f, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle = null)
        {
            lpVtbl->DrawGeometry((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), geometry, brush, strokeWidth, strokeStyle);
        }

        public void FillGeometry([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* opacityBrush = null)
        {
            lpVtbl->FillGeometry((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), geometry, brush, opacityBrush);
        }

        public void FillMesh([NativeTypeName("ID2D1Mesh *")] ID2D1Mesh* mesh, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            lpVtbl->FillMesh((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), mesh, brush);
        }

        public void FillOpacityMask([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* opacityMask, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, D2D1_OPACITY_MASK_CONTENT content, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null)
        {
            lpVtbl->FillOpacityMask((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), opacityMask, brush, content, destinationRectangle, sourceRectangle);
        }

        public void DrawBitmap([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("FLOAT")] float opacity = 1.0f, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null)
        {
            lpVtbl->DrawBitmap((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle);
        }

        public void DrawText([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, [NativeTypeName("IDWriteTextFormat *")] IDWriteTextFormat* textFormat, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* layoutRect, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            lpVtbl->DrawText((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
        }

        public void DrawTextLayout([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F origin, [NativeTypeName("IDWriteTextLayout *")] IDWriteTextLayout* textLayout, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE)
        {
            lpVtbl->DrawTextLayout((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), origin, textLayout, defaultFillBrush, options);
        }

        public void DrawGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            lpVtbl->DrawGlyphRun((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, foregroundBrush, measuringMode);
        }

        public void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            lpVtbl->SetTransform((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), transform);
        }

        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            lpVtbl->GetTransform((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), transform);
        }

        public void SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode)
        {
            lpVtbl->SetAntialiasMode((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), antialiasMode);
        }

        public D2D1_ANTIALIAS_MODE GetAntialiasMode()
        {
            return lpVtbl->GetAntialiasMode((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this));
        }

        public void SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode)
        {
            lpVtbl->SetTextAntialiasMode((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), textAntialiasMode);
        }

        public D2D1_TEXT_ANTIALIAS_MODE GetTextAntialiasMode()
        {
            return lpVtbl->GetTextAntialiasMode((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this));
        }

        public void SetTextRenderingParams([NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* textRenderingParams = null)
        {
            lpVtbl->SetTextRenderingParams((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        public void GetTextRenderingParams([NativeTypeName("IDWriteRenderingParams **")] IDWriteRenderingParams** textRenderingParams)
        {
            lpVtbl->GetTextRenderingParams((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        public void SetTags([NativeTypeName("D2D1_TAG")] ulong tag1, [NativeTypeName("D2D1_TAG")] ulong tag2)
        {
            lpVtbl->SetTags((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        public void GetTags([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
        {
            lpVtbl->GetTags((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        public void PushLayer([NativeTypeName("const D2D1_LAYER_PARAMETERS *")] D2D1_LAYER_PARAMETERS* layerParameters, [NativeTypeName("ID2D1Layer *")] ID2D1Layer* layer)
        {
            lpVtbl->PushLayer((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), layerParameters, layer);
        }

        public void PopLayer()
        {
            lpVtbl->PopLayer((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Flush([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
        {
            return lpVtbl->Flush((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        public void SaveDrawingState([NativeTypeName("ID2D1DrawingStateBlock *")] ID2D1DrawingStateBlock* drawingStateBlock)
        {
            lpVtbl->SaveDrawingState((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), drawingStateBlock);
        }

        public void RestoreDrawingState([NativeTypeName("ID2D1DrawingStateBlock *")] ID2D1DrawingStateBlock* drawingStateBlock)
        {
            lpVtbl->RestoreDrawingState((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), drawingStateBlock);
        }

        public void PushAxisAlignedClip([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
        {
            lpVtbl->PushAxisAlignedClip((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), clipRect, antialiasMode);
        }

        public void PopAxisAlignedClip()
        {
            lpVtbl->PopAxisAlignedClip((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this));
        }

        public void Clear([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* clearColor = null)
        {
            lpVtbl->Clear((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), clearColor);
        }

        public void BeginDraw()
        {
            lpVtbl->BeginDraw((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EndDraw([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
        {
            return lpVtbl->EndDraw((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        public D2D1_PIXEL_FORMAT GetPixelFormat()
        {
            D2D1_PIXEL_FORMAT result;
            return *lpVtbl->GetPixelFormat((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), &result);
        }

        public void SetDpi([NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY)
        {
            lpVtbl->SetDpi((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        public void GetDpi([NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY)
        {
            lpVtbl->GetDpi((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [return: NativeTypeName("D2D1_SIZE_F")]
        public D2D_SIZE_F GetSize()
        {
            D2D_SIZE_F result;
            return *lpVtbl->GetSize((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("D2D1_SIZE_U")]
        public D2D_SIZE_U GetPixelSize()
        {
            D2D_SIZE_U result;
            return *lpVtbl->GetPixelSize((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetMaximumBitmapSize()
        {
            return lpVtbl->GetMaximumBitmapSize((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsSupported([NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties)
        {
            return lpVtbl->IsSupported((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), renderTargetProperties);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmap([NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [NativeTypeName("const void *")] void* sourceData, [NativeTypeName("UINT32")] uint pitch, [NativeTypeName("const D2D1_BITMAP_PROPERTIES1 *")] D2D1_BITMAP_PROPERTIES1* bitmapProperties, [NativeTypeName("ID2D1Bitmap1 **")] ID2D1Bitmap1** bitmap)
        {
            return lpVtbl->CreateBitmap1((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), size, sourceData, pitch, bitmapProperties, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromWicBitmap([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, [NativeTypeName("const D2D1_BITMAP_PROPERTIES1 *")] D2D1_BITMAP_PROPERTIES1* bitmapProperties, [NativeTypeName("ID2D1Bitmap1 **")] ID2D1Bitmap1** bitmap)
        {
            return lpVtbl->CreateBitmapFromWicBitmap1((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), wicBitmapSource, bitmapProperties, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContext(D2D1_COLOR_SPACE space, [NativeTypeName("const BYTE *")] byte* profile, [NativeTypeName("UINT32")] uint profileSize, [NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext)
        {
            return lpVtbl->CreateColorContext((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), space, profile, profileSize, colorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContextFromFilename([NativeTypeName("PCWSTR")] ushort* filename, [NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext)
        {
            return lpVtbl->CreateColorContextFromFilename((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), filename, colorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateColorContextFromWicColorContext([NativeTypeName("IWICColorContext *")] IWICColorContext* wicColorContext, [NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext)
        {
            return lpVtbl->CreateColorContextFromWicColorContext((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), wicColorContext, colorContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapFromDxgiSurface([NativeTypeName("IDXGISurface *")] IDXGISurface* surface, [NativeTypeName("const D2D1_BITMAP_PROPERTIES1 *")] D2D1_BITMAP_PROPERTIES1* bitmapProperties, [NativeTypeName("ID2D1Bitmap1 **")] ID2D1Bitmap1** bitmap)
        {
            return lpVtbl->CreateBitmapFromDxgiSurface((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), surface, bitmapProperties, bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEffect([NativeTypeName("const IID &")] Guid* effectId, [NativeTypeName("ID2D1Effect **")] ID2D1Effect** effect)
        {
            return lpVtbl->CreateEffect((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), effectId, effect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGradientStopCollection([NativeTypeName("const D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* straightAlphaGradientStops, [NativeTypeName("UINT32")] uint straightAlphaGradientStopsCount, D2D1_COLOR_SPACE preInterpolationSpace, D2D1_COLOR_SPACE postInterpolationSpace, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_EXTEND_MODE extendMode, D2D1_COLOR_INTERPOLATION_MODE colorInterpolationMode, [NativeTypeName("ID2D1GradientStopCollection1 **")] ID2D1GradientStopCollection1** gradientStopCollection1)
        {
            return lpVtbl->CreateGradientStopCollection1((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), straightAlphaGradientStops, straightAlphaGradientStopsCount, preInterpolationSpace, postInterpolationSpace, bufferPrecision, extendMode, colorInterpolationMode, gradientStopCollection1);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateImageBrush([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("const D2D1_IMAGE_BRUSH_PROPERTIES *")] D2D1_IMAGE_BRUSH_PROPERTIES* imageBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1ImageBrush **")] ID2D1ImageBrush** imageBrush)
        {
            return lpVtbl->CreateImageBrush((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), image, imageBrushProperties, brushProperties, imageBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBitmapBrush([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES1 *")] D2D1_BITMAP_BRUSH_PROPERTIES1* bitmapBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, [NativeTypeName("ID2D1BitmapBrush1 **")] ID2D1BitmapBrush1** bitmapBrush)
        {
            return lpVtbl->CreateBitmapBrush1((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCommandList([NativeTypeName("ID2D1CommandList **")] ID2D1CommandList** commandList)
        {
            return lpVtbl->CreateCommandList((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), commandList);
        }

        [return: NativeTypeName("BOOL")]
        public int IsDxgiFormatSupported(DXGI_FORMAT format)
        {
            return lpVtbl->IsDxgiFormatSupported((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), format);
        }

        [return: NativeTypeName("BOOL")]
        public int IsBufferPrecisionSupported(D2D1_BUFFER_PRECISION bufferPrecision)
        {
            return lpVtbl->IsBufferPrecisionSupported((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), bufferPrecision);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetImageLocalBounds([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* localBounds)
        {
            return lpVtbl->GetImageLocalBounds((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), image, localBounds);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetImageWorldBounds([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* worldBounds)
        {
            return lpVtbl->GetImageWorldBounds((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), image, worldBounds);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphRunWorldBounds([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
        {
            return lpVtbl->GetGlyphRunWorldBounds((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, measuringMode, bounds);
        }

        public void GetDevice([NativeTypeName("ID2D1Device **")] ID2D1Device** device)
        {
            lpVtbl->GetDevice((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), device);
        }

        public void SetTarget([NativeTypeName("ID2D1Image *")] ID2D1Image* image)
        {
            lpVtbl->SetTarget((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), image);
        }

        public void GetTarget([NativeTypeName("ID2D1Image **")] ID2D1Image** image)
        {
            lpVtbl->GetTarget((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), image);
        }

        public void SetRenderingControls([NativeTypeName("const D2D1_RENDERING_CONTROLS *")] D2D1_RENDERING_CONTROLS* renderingControls)
        {
            lpVtbl->SetRenderingControls((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), renderingControls);
        }

        public void GetRenderingControls([NativeTypeName("D2D1_RENDERING_CONTROLS *")] D2D1_RENDERING_CONTROLS* renderingControls)
        {
            lpVtbl->GetRenderingControls((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), renderingControls);
        }

        public void SetPrimitiveBlend(D2D1_PRIMITIVE_BLEND primitiveBlend)
        {
            lpVtbl->SetPrimitiveBlend((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), primitiveBlend);
        }

        public D2D1_PRIMITIVE_BLEND GetPrimitiveBlend()
        {
            return lpVtbl->GetPrimitiveBlend((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this));
        }

        public void SetUnitMode(D2D1_UNIT_MODE unitMode)
        {
            lpVtbl->SetUnitMode((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), unitMode);
        }

        public D2D1_UNIT_MODE GetUnitMode()
        {
            return lpVtbl->GetUnitMode((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this));
        }

        public void DrawGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            lpVtbl->DrawGlyphRun1((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, glyphRunDescription, foregroundBrush, measuringMode);
        }

        public void DrawImage([NativeTypeName("ID2D1Image *")] ID2D1Image* image, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* imageRectangle = null, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            lpVtbl->DrawImage((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), image, targetOffset, imageRectangle, interpolationMode, compositeMode);
        }

        public void DrawGdiMetafile([NativeTypeName("ID2D1GdiMetafile *")] ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset = null)
        {
            lpVtbl->DrawGdiMetafile((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), gdiMetafile, targetOffset);
        }

        public void DrawBitmap([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, [NativeTypeName("FLOAT")] float opacity, D2D1_INTERPOLATION_MODE interpolationMode, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null, [NativeTypeName("const D2D1_MATRIX_4X4_F *")] D2D_MATRIX_4X4_F* perspectiveTransform = null)
        {
            lpVtbl->DrawBitmap1((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
        }

        public void PushLayer([NativeTypeName("const D2D1_LAYER_PARAMETERS1 *")] D2D1_LAYER_PARAMETERS1* layerParameters, [NativeTypeName("ID2D1Layer *")] ID2D1Layer* layer)
        {
            lpVtbl->PushLayer1((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), layerParameters, layer);
        }

        [return: NativeTypeName("HRESULT")]
        public int InvalidateEffectInputRectangle([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("UINT32")] uint input, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* inputRectangle)
        {
            return lpVtbl->InvalidateEffectInputRectangle((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), effect, input, inputRectangle);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEffectInvalidRectangleCount([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("UINT32 *")] uint* rectangleCount)
        {
            return lpVtbl->GetEffectInvalidRectangleCount((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), effect, rectangleCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEffectInvalidRectangles([NativeTypeName("ID2D1Effect *")] ID2D1Effect* effect, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* rectangles, [NativeTypeName("UINT32")] uint rectanglesCount)
        {
            return lpVtbl->GetEffectInvalidRectangles((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), effect, rectangles, rectanglesCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEffectRequiredInputRectangles([NativeTypeName("ID2D1Effect *")] ID2D1Effect* renderEffect, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* renderImageRectangle, [NativeTypeName("const D2D1_EFFECT_INPUT_DESCRIPTION *")] D2D1_EFFECT_INPUT_DESCRIPTION* inputDescriptions, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* requiredInputRects, [NativeTypeName("UINT32")] uint inputCount)
        {
            return lpVtbl->GetEffectRequiredInputRectangles((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), renderEffect, renderImageRectangle, inputDescriptions, requiredInputRects, inputCount);
        }

        public void FillOpacityMask([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* opacityMask, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null)
        {
            lpVtbl->FillOpacityMask1((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), opacityMask, brush, destinationRectangle, sourceRectangle);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFilledGeometryRealization([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("ID2D1GeometryRealization **")] ID2D1GeometryRealization** geometryRealization)
        {
            return lpVtbl->CreateFilledGeometryRealization((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), geometry, flatteningTolerance, geometryRealization);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateStrokedGeometryRealization([NativeTypeName("ID2D1Geometry *")] ID2D1Geometry* geometry, [NativeTypeName("FLOAT")] float flatteningTolerance, [NativeTypeName("FLOAT")] float strokeWidth, [NativeTypeName("ID2D1StrokeStyle *")] ID2D1StrokeStyle* strokeStyle, [NativeTypeName("ID2D1GeometryRealization **")] ID2D1GeometryRealization** geometryRealization)
        {
            return lpVtbl->CreateStrokedGeometryRealization((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), geometry, flatteningTolerance, strokeWidth, strokeStyle, geometryRealization);
        }

        public void DrawGeometryRealization([NativeTypeName("ID2D1GeometryRealization *")] ID2D1GeometryRealization* geometryRealization, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush)
        {
            lpVtbl->DrawGeometryRealization((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), geometryRealization, brush);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInk([NativeTypeName("const D2D1_INK_POINT *")] D2D1_INK_POINT* startPoint, [NativeTypeName("ID2D1Ink **")] ID2D1Ink** ink)
        {
            return lpVtbl->CreateInk((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), startPoint, ink);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInkStyle([NativeTypeName("const D2D1_INK_STYLE_PROPERTIES *")] D2D1_INK_STYLE_PROPERTIES* inkStyleProperties, [NativeTypeName("ID2D1InkStyle **")] ID2D1InkStyle** inkStyle)
        {
            return lpVtbl->CreateInkStyle((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), inkStyleProperties, inkStyle);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGradientMesh([NativeTypeName("const D2D1_GRADIENT_MESH_PATCH *")] D2D1_GRADIENT_MESH_PATCH* patches, [NativeTypeName("UINT32")] uint patchesCount, [NativeTypeName("ID2D1GradientMesh **")] ID2D1GradientMesh** gradientMesh)
        {
            return lpVtbl->CreateGradientMesh((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), patches, patchesCount, gradientMesh);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateImageSourceFromWic([NativeTypeName("IWICBitmapSource *")] IWICBitmapSource* wicBitmapSource, D2D1_IMAGE_SOURCE_LOADING_OPTIONS loadingOptions, D2D1_ALPHA_MODE alphaMode, [NativeTypeName("ID2D1ImageSourceFromWic **")] ID2D1ImageSourceFromWic** imageSource)
        {
            return lpVtbl->CreateImageSourceFromWic((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), wicBitmapSource, loadingOptions, alphaMode, imageSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateLookupTable3D(D2D1_BUFFER_PRECISION precision, [NativeTypeName("const UINT32 *")] uint* extents, [NativeTypeName("const BYTE *")] byte* data, [NativeTypeName("UINT32")] uint dataCount, [NativeTypeName("const UINT32 *")] uint* strides, [NativeTypeName("ID2D1LookupTable3D **")] ID2D1LookupTable3D** lookupTable)
        {
            return lpVtbl->CreateLookupTable3D((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), precision, extents, data, dataCount, strides, lookupTable);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateImageSourceFromDxgi([NativeTypeName("IDXGISurface **")] IDXGISurface** surfaces, [NativeTypeName("UINT32")] uint surfaceCount, DXGI_COLOR_SPACE_TYPE colorSpace, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS options, [NativeTypeName("ID2D1ImageSource **")] ID2D1ImageSource** imageSource)
        {
            return lpVtbl->CreateImageSourceFromDxgi((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), surfaces, surfaceCount, colorSpace, options, imageSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGradientMeshWorldBounds([NativeTypeName("ID2D1GradientMesh *")] ID2D1GradientMesh* gradientMesh, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* pBounds)
        {
            return lpVtbl->GetGradientMeshWorldBounds((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), gradientMesh, pBounds);
        }

        public void DrawInk([NativeTypeName("ID2D1Ink *")] ID2D1Ink* ink, [NativeTypeName("ID2D1Brush *")] ID2D1Brush* brush, [NativeTypeName("ID2D1InkStyle *")] ID2D1InkStyle* inkStyle)
        {
            lpVtbl->DrawInk((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), ink, brush, inkStyle);
        }

        public void DrawGradientMesh([NativeTypeName("ID2D1GradientMesh *")] ID2D1GradientMesh* gradientMesh)
        {
            lpVtbl->DrawGradientMesh((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), gradientMesh);
        }

        public void DrawGdiMetafile([NativeTypeName("ID2D1GdiMetafile *")] ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null)
        {
            lpVtbl->DrawGdiMetafile1((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), gdiMetafile, destinationRectangle, sourceRectangle);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTransformedImageSource([NativeTypeName("ID2D1ImageSource *")] ID2D1ImageSource* imageSource, [NativeTypeName("const D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES *")] D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties, [NativeTypeName("ID2D1TransformedImageSource **")] ID2D1TransformedImageSource** transformedImageSource)
        {
            return lpVtbl->CreateTransformedImageSource((ID2D1DeviceContext2*)Unsafe.AsPointer(ref this), imageSource, properties, transformedImageSource);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("HRESULT (D2D1_SIZE_U, const void *, UINT32, const D2D1_BITMAP_PROPERTIES *, ID2D1Bitmap **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D_SIZE_U, void*, uint, D2D1_BITMAP_PROPERTIES*, ID2D1Bitmap**, int> CreateBitmap;

            [NativeTypeName("HRESULT (IWICBitmapSource *, const D2D1_BITMAP_PROPERTIES *, ID2D1Bitmap **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, IWICBitmapSource*, D2D1_BITMAP_PROPERTIES*, ID2D1Bitmap**, int> CreateBitmapFromWicBitmap;

            [NativeTypeName("HRESULT (const IID &, void *, const D2D1_BITMAP_PROPERTIES *, ID2D1Bitmap **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, Guid*, void*, D2D1_BITMAP_PROPERTIES*, ID2D1Bitmap**, int> CreateSharedBitmap;

            [NativeTypeName("HRESULT (ID2D1Bitmap *, const D2D1_BITMAP_BRUSH_PROPERTIES *, const D2D1_BRUSH_PROPERTIES *, ID2D1BitmapBrush **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Bitmap*, D2D1_BITMAP_BRUSH_PROPERTIES*, D2D1_BRUSH_PROPERTIES*, ID2D1BitmapBrush**, int> CreateBitmapBrush;

            [NativeTypeName("HRESULT (const D2D1_COLOR_F *, const D2D1_BRUSH_PROPERTIES *, ID2D1SolidColorBrush **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, DXGI_RGBA*, D2D1_BRUSH_PROPERTIES*, ID2D1SolidColorBrush**, int> CreateSolidColorBrush;

            [NativeTypeName("HRESULT (const D2D1_GRADIENT_STOP *, UINT32, D2D1_GAMMA, D2D1_EXTEND_MODE, ID2D1GradientStopCollection **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_GRADIENT_STOP*, uint, D2D1_GAMMA, D2D1_EXTEND_MODE, ID2D1GradientStopCollection**, int> CreateGradientStopCollection;

            [NativeTypeName("HRESULT (const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES *, const D2D1_BRUSH_PROPERTIES *, ID2D1GradientStopCollection *, ID2D1LinearGradientBrush **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES*, D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int> CreateLinearGradientBrush;

            [NativeTypeName("HRESULT (const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES *, const D2D1_BRUSH_PROPERTIES *, ID2D1GradientStopCollection *, ID2D1RadialGradientBrush **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*, D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int> CreateRadialGradientBrush;

            [NativeTypeName("HRESULT (const D2D1_SIZE_F *, const D2D1_SIZE_U *, const D2D1_PIXEL_FORMAT *, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS, ID2D1BitmapRenderTarget **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D_SIZE_F*, D2D_SIZE_U*, D2D1_PIXEL_FORMAT*, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS, ID2D1BitmapRenderTarget**, int> CreateCompatibleRenderTarget;

            [NativeTypeName("HRESULT (const D2D1_SIZE_F *, ID2D1Layer **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D_SIZE_F*, ID2D1Layer**, int> CreateLayer;

            [NativeTypeName("HRESULT (ID2D1Mesh **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Mesh**, int> CreateMesh;

            [NativeTypeName("void (D2D1_POINT_2F, D2D1_POINT_2F, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D_POINT_2F, D2D_POINT_2F, ID2D1Brush*, float, ID2D1StrokeStyle*, void> DrawLine;

            [NativeTypeName("void (const D2D1_RECT_F *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D_RECT_F*, ID2D1Brush*, float, ID2D1StrokeStyle*, void> DrawRectangle;

            [NativeTypeName("void (const D2D1_RECT_F *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D_RECT_F*, ID2D1Brush*, void> FillRectangle;

            [NativeTypeName("void (const D2D1_ROUNDED_RECT *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_ROUNDED_RECT*, ID2D1Brush*, float, ID2D1StrokeStyle*, void> DrawRoundedRectangle;

            [NativeTypeName("void (const D2D1_ROUNDED_RECT *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_ROUNDED_RECT*, ID2D1Brush*, void> FillRoundedRectangle;

            [NativeTypeName("void (const D2D1_ELLIPSE *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_ELLIPSE*, ID2D1Brush*, float, ID2D1StrokeStyle*, void> DrawEllipse;

            [NativeTypeName("void (const D2D1_ELLIPSE *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_ELLIPSE*, ID2D1Brush*, void> FillEllipse;

            [NativeTypeName("void (ID2D1Geometry *, ID2D1Brush *, FLOAT, ID2D1StrokeStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void> DrawGeometry;

            [NativeTypeName("void (ID2D1Geometry *, ID2D1Brush *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void> FillGeometry;

            [NativeTypeName("void (ID2D1Mesh *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Mesh*, ID2D1Brush*, void> FillMesh;

            [NativeTypeName("void (ID2D1Bitmap *, ID2D1Brush *, D2D1_OPACITY_MASK_CONTENT, const D2D1_RECT_F *, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Bitmap*, ID2D1Brush*, D2D1_OPACITY_MASK_CONTENT, D2D_RECT_F*, D2D_RECT_F*, void> FillOpacityMask;

            [NativeTypeName("void (ID2D1Bitmap *, const D2D1_RECT_F *, FLOAT, D2D1_BITMAP_INTERPOLATION_MODE, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Bitmap*, D2D_RECT_F*, float, D2D1_BITMAP_INTERPOLATION_MODE, D2D_RECT_F*, void> DrawBitmap;

            [NativeTypeName("void (const WCHAR *, UINT32, IDWriteTextFormat *, const D2D1_RECT_F *, ID2D1Brush *, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ushort*, uint, IDWriteTextFormat*, D2D_RECT_F*, ID2D1Brush*, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE, void> DrawText;

            [NativeTypeName("void (D2D1_POINT_2F, IDWriteTextLayout *, ID2D1Brush *, D2D1_DRAW_TEXT_OPTIONS) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D_POINT_2F, IDWriteTextLayout*, ID2D1Brush*, D2D1_DRAW_TEXT_OPTIONS, void> DrawTextLayout;

            [NativeTypeName("void (D2D1_POINT_2F, const DWRITE_GLYPH_RUN *, ID2D1Brush *, DWRITE_MEASURING_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, ID2D1Brush*, DWRITE_MEASURING_MODE, void> DrawGlyphRun;

            [NativeTypeName("void (const D2D1_MATRIX_3X2_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D_MATRIX_3X2_F*, void> SetTransform;

            [NativeTypeName("void (D2D1_MATRIX_3X2_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D_MATRIX_3X2_F*, void> GetTransform;

            [NativeTypeName("void (D2D1_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_ANTIALIAS_MODE, void> SetAntialiasMode;

            [NativeTypeName("D2D1_ANTIALIAS_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_ANTIALIAS_MODE> GetAntialiasMode;

            [NativeTypeName("void (D2D1_TEXT_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_TEXT_ANTIALIAS_MODE, void> SetTextAntialiasMode;

            [NativeTypeName("D2D1_TEXT_ANTIALIAS_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_TEXT_ANTIALIAS_MODE> GetTextAntialiasMode;

            [NativeTypeName("void (IDWriteRenderingParams *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, IDWriteRenderingParams*, void> SetTextRenderingParams;

            [NativeTypeName("void (IDWriteRenderingParams **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, IDWriteRenderingParams**, void> GetTextRenderingParams;

            [NativeTypeName("void (D2D1_TAG, D2D1_TAG) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ulong, ulong, void> SetTags;

            [NativeTypeName("void (D2D1_TAG *, D2D1_TAG *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ulong*, ulong*, void> GetTags;

            [NativeTypeName("void (const D2D1_LAYER_PARAMETERS *, ID2D1Layer *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_LAYER_PARAMETERS*, ID2D1Layer*, void> PushLayer;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, void> PopLayer;

            [NativeTypeName("HRESULT (D2D1_TAG *, D2D1_TAG *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ulong*, ulong*, int> Flush;

            [NativeTypeName("void (ID2D1DrawingStateBlock *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1DrawingStateBlock*, void> SaveDrawingState;

            [NativeTypeName("void (ID2D1DrawingStateBlock *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1DrawingStateBlock*, void> RestoreDrawingState;

            [NativeTypeName("void (const D2D1_RECT_F *, D2D1_ANTIALIAS_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D_RECT_F*, D2D1_ANTIALIAS_MODE, void> PushAxisAlignedClip;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, void> PopAxisAlignedClip;

            [NativeTypeName("void (const D2D1_COLOR_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, DXGI_RGBA*, void> Clear;

            [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, void> BeginDraw;

            [NativeTypeName("HRESULT (D2D1_TAG *, D2D1_TAG *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ulong*, ulong*, int> EndDraw;

            [NativeTypeName("D2D1_PIXEL_FORMAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_PIXEL_FORMAT*, D2D1_PIXEL_FORMAT*> GetPixelFormat;

            [NativeTypeName("void (FLOAT, FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, float, float, void> SetDpi;

            [NativeTypeName("void (FLOAT *, FLOAT *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, float*, float*, void> GetDpi;

            [NativeTypeName("D2D1_SIZE_F () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D_SIZE_F*, D2D_SIZE_F*> GetSize;

            [NativeTypeName("D2D1_SIZE_U () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D_SIZE_U*, D2D_SIZE_U*> GetPixelSize;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, uint> GetMaximumBitmapSize;

            [NativeTypeName("BOOL (const D2D1_RENDER_TARGET_PROPERTIES *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_RENDER_TARGET_PROPERTIES*, int> IsSupported;

            [NativeTypeName("HRESULT (D2D1_SIZE_U, const void *, UINT32, const D2D1_BITMAP_PROPERTIES1 *, ID2D1Bitmap1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D_SIZE_U, void*, uint, D2D1_BITMAP_PROPERTIES1*, ID2D1Bitmap1**, int> CreateBitmap1;

            [NativeTypeName("HRESULT (IWICBitmapSource *, const D2D1_BITMAP_PROPERTIES1 *, ID2D1Bitmap1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, IWICBitmapSource*, D2D1_BITMAP_PROPERTIES1*, ID2D1Bitmap1**, int> CreateBitmapFromWicBitmap1;

            [NativeTypeName("HRESULT (D2D1_COLOR_SPACE, const BYTE *, UINT32, ID2D1ColorContext **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_COLOR_SPACE, byte*, uint, ID2D1ColorContext**, int> CreateColorContext;

            [NativeTypeName("HRESULT (PCWSTR, ID2D1ColorContext **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ushort*, ID2D1ColorContext**, int> CreateColorContextFromFilename;

            [NativeTypeName("HRESULT (IWICColorContext *, ID2D1ColorContext **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, IWICColorContext*, ID2D1ColorContext**, int> CreateColorContextFromWicColorContext;

            [NativeTypeName("HRESULT (IDXGISurface *, const D2D1_BITMAP_PROPERTIES1 *, ID2D1Bitmap1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, IDXGISurface*, D2D1_BITMAP_PROPERTIES1*, ID2D1Bitmap1**, int> CreateBitmapFromDxgiSurface;

            [NativeTypeName("HRESULT (const IID &, ID2D1Effect **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, Guid*, ID2D1Effect**, int> CreateEffect;

            [NativeTypeName("HRESULT (const D2D1_GRADIENT_STOP *, UINT32, D2D1_COLOR_SPACE, D2D1_COLOR_SPACE, D2D1_BUFFER_PRECISION, D2D1_EXTEND_MODE, D2D1_COLOR_INTERPOLATION_MODE, ID2D1GradientStopCollection1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_GRADIENT_STOP*, uint, D2D1_COLOR_SPACE, D2D1_COLOR_SPACE, D2D1_BUFFER_PRECISION, D2D1_EXTEND_MODE, D2D1_COLOR_INTERPOLATION_MODE, ID2D1GradientStopCollection1**, int> CreateGradientStopCollection1;

            [NativeTypeName("HRESULT (ID2D1Image *, const D2D1_IMAGE_BRUSH_PROPERTIES *, const D2D1_BRUSH_PROPERTIES *, ID2D1ImageBrush **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Image*, D2D1_IMAGE_BRUSH_PROPERTIES*, D2D1_BRUSH_PROPERTIES*, ID2D1ImageBrush**, int> CreateImageBrush;

            [NativeTypeName("HRESULT (ID2D1Bitmap *, const D2D1_BITMAP_BRUSH_PROPERTIES1 *, const D2D1_BRUSH_PROPERTIES *, ID2D1BitmapBrush1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Bitmap*, D2D1_BITMAP_BRUSH_PROPERTIES1*, D2D1_BRUSH_PROPERTIES*, ID2D1BitmapBrush1**, int> CreateBitmapBrush1;

            [NativeTypeName("HRESULT (ID2D1CommandList **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1CommandList**, int> CreateCommandList;

            [NativeTypeName("BOOL (DXGI_FORMAT) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, DXGI_FORMAT, int> IsDxgiFormatSupported;

            [NativeTypeName("BOOL (D2D1_BUFFER_PRECISION) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_BUFFER_PRECISION, int> IsBufferPrecisionSupported;

            [NativeTypeName("HRESULT (ID2D1Image *, D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Image*, D2D_RECT_F*, int> GetImageLocalBounds;

            [NativeTypeName("HRESULT (ID2D1Image *, D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Image*, D2D_RECT_F*, int> GetImageWorldBounds;

            [NativeTypeName("HRESULT (D2D1_POINT_2F, const DWRITE_GLYPH_RUN *, DWRITE_MEASURING_MODE, D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, DWRITE_MEASURING_MODE, D2D_RECT_F*, int> GetGlyphRunWorldBounds;

            [NativeTypeName("void (ID2D1Device **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Device**, void> GetDevice;

            [NativeTypeName("void (ID2D1Image *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Image*, void> SetTarget;

            [NativeTypeName("void (ID2D1Image **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Image**, void> GetTarget;

            [NativeTypeName("void (const D2D1_RENDERING_CONTROLS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_RENDERING_CONTROLS*, void> SetRenderingControls;

            [NativeTypeName("void (D2D1_RENDERING_CONTROLS *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_RENDERING_CONTROLS*, void> GetRenderingControls;

            [NativeTypeName("void (D2D1_PRIMITIVE_BLEND) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_PRIMITIVE_BLEND, void> SetPrimitiveBlend;

            [NativeTypeName("D2D1_PRIMITIVE_BLEND () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_PRIMITIVE_BLEND> GetPrimitiveBlend;

            [NativeTypeName("void (D2D1_UNIT_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_UNIT_MODE, void> SetUnitMode;

            [NativeTypeName("D2D1_UNIT_MODE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_UNIT_MODE> GetUnitMode;

            [NativeTypeName("void (D2D1_POINT_2F, const DWRITE_GLYPH_RUN *, const DWRITE_GLYPH_RUN_DESCRIPTION *, ID2D1Brush *, DWRITE_MEASURING_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, ID2D1Brush*, DWRITE_MEASURING_MODE, void> DrawGlyphRun1;

            [NativeTypeName("void (ID2D1Image *, const D2D1_POINT_2F *, const D2D1_RECT_F *, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Image*, D2D_POINT_2F*, D2D_RECT_F*, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE, void> DrawImage;

            [NativeTypeName("void (ID2D1GdiMetafile *, const D2D1_POINT_2F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1GdiMetafile*, D2D_POINT_2F*, void> DrawGdiMetafile;

            [NativeTypeName("void (ID2D1Bitmap *, const D2D1_RECT_F *, FLOAT, D2D1_INTERPOLATION_MODE, const D2D1_RECT_F *, const D2D1_MATRIX_4X4_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Bitmap*, D2D_RECT_F*, float, D2D1_INTERPOLATION_MODE, D2D_RECT_F*, D2D_MATRIX_4X4_F*, void> DrawBitmap1;

            [NativeTypeName("void (const D2D1_LAYER_PARAMETERS1 *, ID2D1Layer *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_LAYER_PARAMETERS1*, ID2D1Layer*, void> PushLayer1;

            [NativeTypeName("HRESULT (ID2D1Effect *, UINT32, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Effect*, uint, D2D_RECT_F*, int> InvalidateEffectInputRectangle;

            [NativeTypeName("HRESULT (ID2D1Effect *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Effect*, uint*, int> GetEffectInvalidRectangleCount;

            [NativeTypeName("HRESULT (ID2D1Effect *, D2D1_RECT_F *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Effect*, D2D_RECT_F*, uint, int> GetEffectInvalidRectangles;

            [NativeTypeName("HRESULT (ID2D1Effect *, const D2D1_RECT_F *, const D2D1_EFFECT_INPUT_DESCRIPTION *, D2D1_RECT_F *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Effect*, D2D_RECT_F*, D2D1_EFFECT_INPUT_DESCRIPTION*, D2D_RECT_F*, uint, int> GetEffectRequiredInputRectangles;

            [NativeTypeName("void (ID2D1Bitmap *, ID2D1Brush *, const D2D1_RECT_F *, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Bitmap*, ID2D1Brush*, D2D_RECT_F*, D2D_RECT_F*, void> FillOpacityMask1;

            [NativeTypeName("HRESULT (ID2D1Geometry *, FLOAT, ID2D1GeometryRealization **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Geometry*, float, ID2D1GeometryRealization**, int> CreateFilledGeometryRealization;

            [NativeTypeName("HRESULT (ID2D1Geometry *, FLOAT, FLOAT, ID2D1StrokeStyle *, ID2D1GeometryRealization **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Geometry*, float, float, ID2D1StrokeStyle*, ID2D1GeometryRealization**, int> CreateStrokedGeometryRealization;

            [NativeTypeName("void (ID2D1GeometryRealization *, ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1GeometryRealization*, ID2D1Brush*, void> DrawGeometryRealization;

            [NativeTypeName("HRESULT (const D2D1_INK_POINT *, ID2D1Ink **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_INK_POINT*, ID2D1Ink**, int> CreateInk;

            [NativeTypeName("HRESULT (const D2D1_INK_STYLE_PROPERTIES *, ID2D1InkStyle **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_INK_STYLE_PROPERTIES*, ID2D1InkStyle**, int> CreateInkStyle;

            [NativeTypeName("HRESULT (const D2D1_GRADIENT_MESH_PATCH *, UINT32, ID2D1GradientMesh **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_GRADIENT_MESH_PATCH*, uint, ID2D1GradientMesh**, int> CreateGradientMesh;

            [NativeTypeName("HRESULT (IWICBitmapSource *, D2D1_IMAGE_SOURCE_LOADING_OPTIONS, D2D1_ALPHA_MODE, ID2D1ImageSourceFromWic **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, IWICBitmapSource*, D2D1_IMAGE_SOURCE_LOADING_OPTIONS, D2D1_ALPHA_MODE, ID2D1ImageSourceFromWic**, int> CreateImageSourceFromWic;

            [NativeTypeName("HRESULT (D2D1_BUFFER_PRECISION, const UINT32 *, const BYTE *, UINT32, const UINT32 *, ID2D1LookupTable3D **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, D2D1_BUFFER_PRECISION, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int> CreateLookupTable3D;

            [NativeTypeName("HRESULT (IDXGISurface **, UINT32, DXGI_COLOR_SPACE_TYPE, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS, ID2D1ImageSource **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, IDXGISurface**, uint, DXGI_COLOR_SPACE_TYPE, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS, ID2D1ImageSource**, int> CreateImageSourceFromDxgi;

            [NativeTypeName("HRESULT (ID2D1GradientMesh *, D2D1_RECT_F *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1GradientMesh*, D2D_RECT_F*, int> GetGradientMeshWorldBounds;

            [NativeTypeName("void (ID2D1Ink *, ID2D1Brush *, ID2D1InkStyle *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, void> DrawInk;

            [NativeTypeName("void (ID2D1GradientMesh *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1GradientMesh*, void> DrawGradientMesh;

            [NativeTypeName("void (ID2D1GdiMetafile *, const D2D1_RECT_F *, const D2D1_RECT_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1GdiMetafile*, D2D_RECT_F*, D2D_RECT_F*, void> DrawGdiMetafile1;

            [NativeTypeName("HRESULT (ID2D1ImageSource *, const D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES *, ID2D1TransformedImageSource **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1DeviceContext2*, ID2D1ImageSource*, D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES*, ID2D1TransformedImageSource**, int> CreateTransformedImageSource;
        }
    }
}