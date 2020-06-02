// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("27F2A904-4EB8-441D-9678-0563F53E3E2F")]
    public unsafe partial struct IDWriteFontFace4
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDWriteFontFace4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDWriteFontFace4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDWriteFontFace4*)Unsafe.AsPointer(ref this));
        }

        public new DWRITE_FONT_FACE_TYPE GetType()
        {
            return lpVtbl->GetType((IDWriteFontFace4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFiles([NativeTypeName("UINT32 *")] uint* numberOfFiles, [NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFiles)
        {
            return lpVtbl->GetFiles((IDWriteFontFace4*)Unsafe.AsPointer(ref this), numberOfFiles, fontFiles);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetIndex()
        {
            return lpVtbl->GetIndex((IDWriteFontFace4*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_SIMULATIONS GetSimulations()
        {
            return lpVtbl->GetSimulations((IDWriteFontFace4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsSymbolFont()
        {
            return lpVtbl->IsSymbolFont((IDWriteFontFace4*)Unsafe.AsPointer(ref this));
        }

        public void GetMetrics([NativeTypeName("DWRITE_FONT_METRICS *")] DWRITE_FONT_METRICS* fontFaceMetrics)
        {
            lpVtbl->GetMetrics((IDWriteFontFace4*)Unsafe.AsPointer(ref this), fontFaceMetrics);
        }

        [return: NativeTypeName("UINT16")]
        public ushort GetGlyphCount()
        {
            return lpVtbl->GetGlyphCount((IDWriteFontFace4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesignGlyphMetrics([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("DWRITE_GLYPH_METRICS *")] DWRITE_GLYPH_METRICS* glyphMetrics, [NativeTypeName("BOOL")] int isSideways = 0)
        {
            return lpVtbl->GetDesignGlyphMetrics((IDWriteFontFace4*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, glyphMetrics, isSideways);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphIndices([NativeTypeName("const UINT32 *")] uint* codePoints, [NativeTypeName("UINT32")] uint codePointCount, [NativeTypeName("UINT16 *")] ushort* glyphIndices)
        {
            return lpVtbl->GetGlyphIndices((IDWriteFontFace4*)Unsafe.AsPointer(ref this), codePoints, codePointCount, glyphIndices);
        }

        [return: NativeTypeName("HRESULT")]
        public int TryGetFontTable([NativeTypeName("UINT32")] uint openTypeTableTag, [NativeTypeName("const void **")] void** tableData, [NativeTypeName("UINT32 *")] uint* tableSize, [NativeTypeName("void **")] void** tableContext, [NativeTypeName("BOOL *")] int* exists)
        {
            return lpVtbl->TryGetFontTable((IDWriteFontFace4*)Unsafe.AsPointer(ref this), openTypeTableTag, tableData, tableSize, tableContext, exists);
        }

        public void ReleaseFontTable([NativeTypeName("void *")] void* tableContext)
        {
            lpVtbl->ReleaseFontTable((IDWriteFontFace4*)Unsafe.AsPointer(ref this), tableContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphRunOutline([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("const FLOAT *")] float* glyphAdvances, [NativeTypeName("const DWRITE_GLYPH_OFFSET *")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("IDWriteGeometrySink *")] ID2D1SimplifiedGeometrySink* geometrySink)
        {
            return lpVtbl->GetGlyphRunOutline((IDWriteFontFace4*)Unsafe.AsPointer(ref this), emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* renderingParams, [NativeTypeName("DWRITE_RENDERING_MODE *")] DWRITE_RENDERING_MODE* renderingMode)
        {
            return lpVtbl->GetRecommendedRenderingMode((IDWriteFontFace4*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleMetrics([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("DWRITE_FONT_METRICS *")] DWRITE_FONT_METRICS* fontFaceMetrics)
        {
            return lpVtbl->GetGdiCompatibleMetrics((IDWriteFontFace4*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontFaceMetrics);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleGlyphMetrics([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("DWRITE_GLYPH_METRICS *")] DWRITE_GLYPH_METRICS* glyphMetrics, [NativeTypeName("BOOL")] int isSideways = 0)
        {
            return lpVtbl->GetGdiCompatibleGlyphMetrics((IDWriteFontFace4*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
        }

        public void GetMetrics([NativeTypeName("DWRITE_FONT_METRICS1 *")] DWRITE_FONT_METRICS1* fontMetrics)
        {
            lpVtbl->GetMetrics1((IDWriteFontFace4*)Unsafe.AsPointer(ref this), fontMetrics);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleMetrics([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("DWRITE_FONT_METRICS1 *")] DWRITE_FONT_METRICS1* fontMetrics)
        {
            return lpVtbl->GetGdiCompatibleMetrics1((IDWriteFontFace4*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, fontMetrics);
        }

        public void GetCaretMetrics([NativeTypeName("DWRITE_CARET_METRICS *")] DWRITE_CARET_METRICS* caretMetrics)
        {
            lpVtbl->GetCaretMetrics((IDWriteFontFace4*)Unsafe.AsPointer(ref this), caretMetrics);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUnicodeRanges([NativeTypeName("UINT32")] uint maxRangeCount, [NativeTypeName("DWRITE_UNICODE_RANGE *")] DWRITE_UNICODE_RANGE* unicodeRanges, [NativeTypeName("UINT32 *")] uint* actualRangeCount)
        {
            return lpVtbl->GetUnicodeRanges((IDWriteFontFace4*)Unsafe.AsPointer(ref this), maxRangeCount, unicodeRanges, actualRangeCount);
        }

        [return: NativeTypeName("BOOL")]
        public int IsMonospacedFont()
        {
            return lpVtbl->IsMonospacedFont((IDWriteFontFace4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesignGlyphAdvances([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvances, [NativeTypeName("BOOL")] int isSideways = 0)
        {
            return lpVtbl->GetDesignGlyphAdvances((IDWriteFontFace4*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvances, isSideways);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleGlyphAdvances([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvances)
        {
            return lpVtbl->GetGdiCompatibleGlyphAdvances((IDWriteFontFace4*)Unsafe.AsPointer(ref this), emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetKerningPairAdjustments([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("INT32 *")] int* glyphAdvanceAdjustments)
        {
            return lpVtbl->GetKerningPairAdjustments((IDWriteFontFace4*)Unsafe.AsPointer(ref this), glyphCount, glyphIndices, glyphAdvanceAdjustments);
        }

        [return: NativeTypeName("BOOL")]
        public int HasKerningPairs()
        {
            return lpVtbl->HasKerningPairs((IDWriteFontFace4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode([NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("DWRITE_RENDERING_MODE *")] DWRITE_RENDERING_MODE* renderingMode)
        {
            return lpVtbl->GetRecommendedRenderingMode1((IDWriteFontFace4*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVerticalGlyphVariants([NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("const UINT16 *")] ushort* nominalGlyphIndices, [NativeTypeName("UINT16 *")] ushort* verticalGlyphIndices)
        {
            return lpVtbl->GetVerticalGlyphVariants((IDWriteFontFace4*)Unsafe.AsPointer(ref this), glyphCount, nominalGlyphIndices, verticalGlyphIndices);
        }

        [return: NativeTypeName("BOOL")]
        public int HasVerticalGlyphVariants()
        {
            return lpVtbl->HasVerticalGlyphVariants((IDWriteFontFace4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsColorFont()
        {
            return lpVtbl->IsColorFont((IDWriteFontFace4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetColorPaletteCount()
        {
            return lpVtbl->GetColorPaletteCount((IDWriteFontFace4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetPaletteEntryCount()
        {
            return lpVtbl->GetPaletteEntryCount((IDWriteFontFace4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPaletteEntries([NativeTypeName("UINT32")] uint colorPaletteIndex, [NativeTypeName("UINT32")] uint firstEntryIndex, [NativeTypeName("UINT32")] uint entryCount, [NativeTypeName("DWRITE_COLOR_F *")] DXGI_RGBA* paletteEntries)
        {
            return lpVtbl->GetPaletteEntries((IDWriteFontFace4*)Unsafe.AsPointer(ref this), colorPaletteIndex, firstEntryIndex, entryCount, paletteEntries);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode([NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* renderingParams, [NativeTypeName("DWRITE_RENDERING_MODE *")] DWRITE_RENDERING_MODE* renderingMode, [NativeTypeName("DWRITE_GRID_FIT_MODE *")] DWRITE_GRID_FIT_MODE* gridFitMode)
        {
            return lpVtbl->GetRecommendedRenderingMode2((IDWriteFontFace4*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingParams, renderingMode, gridFitMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFaceReference([NativeTypeName("IDWriteFontFaceReference **")] IDWriteFontFaceReference** fontFaceReference)
        {
            return lpVtbl->GetFontFaceReference((IDWriteFontFace4*)Unsafe.AsPointer(ref this), fontFaceReference);
        }

        public void GetPanose([NativeTypeName("DWRITE_PANOSE *")] DWRITE_PANOSE* panose)
        {
            lpVtbl->GetPanose((IDWriteFontFace4*)Unsafe.AsPointer(ref this), panose);
        }

        public DWRITE_FONT_WEIGHT GetWeight()
        {
            return lpVtbl->GetWeight((IDWriteFontFace4*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_STRETCH GetStretch()
        {
            return lpVtbl->GetStretch((IDWriteFontFace4*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_STYLE GetStyle()
        {
            return lpVtbl->GetStyle((IDWriteFontFace4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFamilyNames([NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** names)
        {
            return lpVtbl->GetFamilyNames((IDWriteFontFace4*)Unsafe.AsPointer(ref this), names);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFaceNames([NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** names)
        {
            return lpVtbl->GetFaceNames((IDWriteFontFace4*)Unsafe.AsPointer(ref this), names);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, [NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** informationalStrings, [NativeTypeName("BOOL *")] int* exists)
        {
            return lpVtbl->GetInformationalStrings((IDWriteFontFace4*)Unsafe.AsPointer(ref this), informationalStringID, informationalStrings, exists);
        }

        [return: NativeTypeName("BOOL")]
        public int HasCharacter([NativeTypeName("UINT32")] uint unicodeValue)
        {
            return lpVtbl->HasCharacter((IDWriteFontFace4*)Unsafe.AsPointer(ref this), unicodeValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode([NativeTypeName("FLOAT")] float fontEmSize, [NativeTypeName("FLOAT")] float dpiX, [NativeTypeName("FLOAT")] float dpiY, [NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("IDWriteRenderingParams *")] IDWriteRenderingParams* renderingParams, [NativeTypeName("DWRITE_RENDERING_MODE1 *")] DWRITE_RENDERING_MODE1* renderingMode, [NativeTypeName("DWRITE_GRID_FIT_MODE *")] DWRITE_GRID_FIT_MODE* gridFitMode)
        {
            return lpVtbl->GetRecommendedRenderingMode3((IDWriteFontFace4*)Unsafe.AsPointer(ref this), fontEmSize, dpiX, dpiY, transform, isSideways, outlineThreshold, measuringMode, renderingParams, renderingMode, gridFitMode);
        }

        [return: NativeTypeName("BOOL")]
        public int IsCharacterLocal([NativeTypeName("UINT32")] uint unicodeValue)
        {
            return lpVtbl->IsCharacterLocal((IDWriteFontFace4*)Unsafe.AsPointer(ref this), unicodeValue);
        }

        [return: NativeTypeName("BOOL")]
        public int IsGlyphLocal([NativeTypeName("UINT16")] ushort glyphId)
        {
            return lpVtbl->IsGlyphLocal((IDWriteFontFace4*)Unsafe.AsPointer(ref this), glyphId);
        }

        [return: NativeTypeName("HRESULT")]
        public int AreCharactersLocal([NativeTypeName("const WCHAR *")] ushort* characters, [NativeTypeName("UINT32")] uint characterCount, [NativeTypeName("BOOL")] int enqueueIfNotLocal, [NativeTypeName("BOOL *")] int* isLocal)
        {
            return lpVtbl->AreCharactersLocal((IDWriteFontFace4*)Unsafe.AsPointer(ref this), characters, characterCount, enqueueIfNotLocal, isLocal);
        }

        [return: NativeTypeName("HRESULT")]
        public int AreGlyphsLocal([NativeTypeName("const UINT16 *")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("BOOL")] int enqueueIfNotLocal, [NativeTypeName("BOOL *")] int* isLocal)
        {
            return lpVtbl->AreGlyphsLocal((IDWriteFontFace4*)Unsafe.AsPointer(ref this), glyphIndices, glyphCount, enqueueIfNotLocal, isLocal);
        }

        public DWRITE_GLYPH_IMAGE_FORMATS GetGlyphImageFormats()
        {
            return lpVtbl->GetGlyphImageFormats((IDWriteFontFace4*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphImageFormats([NativeTypeName("UINT16")] ushort glyphId, [NativeTypeName("UINT32")] uint pixelsPerEmFirst, [NativeTypeName("UINT32")] uint pixelsPerEmLast, [NativeTypeName("DWRITE_GLYPH_IMAGE_FORMATS *")] DWRITE_GLYPH_IMAGE_FORMATS* glyphImageFormats)
        {
            return lpVtbl->GetGlyphImageFormats1((IDWriteFontFace4*)Unsafe.AsPointer(ref this), glyphId, pixelsPerEmFirst, pixelsPerEmLast, glyphImageFormats);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphImageData([NativeTypeName("UINT16")] ushort glyphId, [NativeTypeName("UINT32")] uint pixelsPerEm, DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, [NativeTypeName("DWRITE_GLYPH_IMAGE_DATA *")] DWRITE_GLYPH_IMAGE_DATA* glyphData, [NativeTypeName("void **")] void** glyphDataContext)
        {
            return lpVtbl->GetGlyphImageData((IDWriteFontFace4*)Unsafe.AsPointer(ref this), glyphId, pixelsPerEm, glyphImageFormat, glyphData, glyphDataContext);
        }

        public void ReleaseGlyphImageData([NativeTypeName("void *")] void* glyphDataContext)
        {
            lpVtbl->ReleaseGlyphImageData((IDWriteFontFace4*)Unsafe.AsPointer(ref this), glyphDataContext);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, uint> Release;

            [NativeTypeName("DWRITE_FONT_FACE_TYPE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public new delegate* stdcall<IDWriteFontFace4*, DWRITE_FONT_FACE_TYPE> GetType;

            [NativeTypeName("HRESULT (UINT32 *, IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, uint*, IDWriteFontFile**, int> GetFiles;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, uint> GetIndex;

            [NativeTypeName("DWRITE_FONT_SIMULATIONS () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, DWRITE_FONT_SIMULATIONS> GetSimulations;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, int> IsSymbolFont;

            [NativeTypeName("void (DWRITE_FONT_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, DWRITE_FONT_METRICS*, void> GetMetrics;

            [NativeTypeName("UINT16 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, ushort> GetGlyphCount;

            [NativeTypeName("HRESULT (const UINT16 *, UINT32, DWRITE_GLYPH_METRICS *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, ushort*, uint, DWRITE_GLYPH_METRICS*, int, int> GetDesignGlyphMetrics;

            [NativeTypeName("HRESULT (const UINT32 *, UINT32, UINT16 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, uint*, uint, ushort*, int> GetGlyphIndices;

            [NativeTypeName("HRESULT (UINT32, const void **, UINT32 *, void **, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int> TryGetFontTable;

            [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, void*, void> ReleaseFontTable;

            [NativeTypeName("HRESULT (FLOAT, const UINT16 *, const FLOAT *, const DWRITE_GLYPH_OFFSET *, UINT32, BOOL, BOOL, IDWriteGeometrySink *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, float, ushort*, float*, DWRITE_GLYPH_OFFSET*, uint, int, int, ID2D1SimplifiedGeometrySink*, int> GetGlyphRunOutline;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, DWRITE_MEASURING_MODE, IDWriteRenderingParams *, DWRITE_RENDERING_MODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, float, float, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE*, int> GetRecommendedRenderingMode;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, DWRITE_FONT_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, float, float, DWRITE_MATRIX*, DWRITE_FONT_METRICS*, int> GetGdiCompatibleMetrics;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, const UINT16 *, UINT32, DWRITE_GLYPH_METRICS *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, float, float, DWRITE_MATRIX*, int, ushort*, uint, DWRITE_GLYPH_METRICS*, int, int> GetGdiCompatibleGlyphMetrics;

            [NativeTypeName("void (DWRITE_FONT_METRICS1 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, DWRITE_FONT_METRICS1*, void> GetMetrics1;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, DWRITE_FONT_METRICS1 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, float, float, DWRITE_MATRIX*, DWRITE_FONT_METRICS1*, int> GetGdiCompatibleMetrics1;

            [NativeTypeName("void (DWRITE_CARET_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, DWRITE_CARET_METRICS*, void> GetCaretMetrics;

            [NativeTypeName("HRESULT (UINT32, DWRITE_UNICODE_RANGE *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, uint, DWRITE_UNICODE_RANGE*, uint*, int> GetUnicodeRanges;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, int> IsMonospacedFont;

            [NativeTypeName("HRESULT (UINT32, const UINT16 *, INT32 *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, uint, ushort*, int*, int, int> GetDesignGlyphAdvances;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, BOOL, UINT32, const UINT16 *, INT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, float, float, DWRITE_MATRIX*, int, int, uint, ushort*, int*, int> GetGdiCompatibleGlyphAdvances;

            [NativeTypeName("HRESULT (UINT32, const UINT16 *, INT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, uint, ushort*, int*, int> GetKerningPairAdjustments;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, int> HasKerningPairs;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, DWRITE_RENDERING_MODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, float, float, float, DWRITE_MATRIX*, int, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, DWRITE_RENDERING_MODE*, int> GetRecommendedRenderingMode1;

            [NativeTypeName("HRESULT (UINT32, const UINT16 *, UINT16 *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, uint, ushort*, ushort*, int> GetVerticalGlyphVariants;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, int> HasVerticalGlyphVariants;

            [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, int> IsColorFont;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, uint> GetColorPaletteCount;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, uint> GetPaletteEntryCount;

            [NativeTypeName("HRESULT (UINT32, UINT32, UINT32, DWRITE_COLOR_F *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, uint, uint, uint, DXGI_RGBA*, int> GetPaletteEntries;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams *, DWRITE_RENDERING_MODE *, DWRITE_GRID_FIT_MODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, float, float, float, DWRITE_MATRIX*, int, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE*, DWRITE_GRID_FIT_MODE*, int> GetRecommendedRenderingMode2;

            [NativeTypeName("HRESULT (IDWriteFontFaceReference **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, IDWriteFontFaceReference**, int> GetFontFaceReference;

            [NativeTypeName("void (DWRITE_PANOSE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, DWRITE_PANOSE*, void> GetPanose;

            [NativeTypeName("DWRITE_FONT_WEIGHT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, DWRITE_FONT_WEIGHT> GetWeight;

            [NativeTypeName("DWRITE_FONT_STRETCH () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, DWRITE_FONT_STRETCH> GetStretch;

            [NativeTypeName("DWRITE_FONT_STYLE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, DWRITE_FONT_STYLE> GetStyle;

            [NativeTypeName("HRESULT (IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, IDWriteLocalizedStrings**, int> GetFamilyNames;

            [NativeTypeName("HRESULT (IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, IDWriteLocalizedStrings**, int> GetFaceNames;

            [NativeTypeName("HRESULT (DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings **, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings**, int*, int> GetInformationalStrings;

            [NativeTypeName("BOOL (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, uint, int> HasCharacter;

            [NativeTypeName("HRESULT (FLOAT, FLOAT, FLOAT, const DWRITE_MATRIX *, BOOL, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams *, DWRITE_RENDERING_MODE1 *, DWRITE_GRID_FIT_MODE *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, float, float, float, DWRITE_MATRIX*, int, DWRITE_OUTLINE_THRESHOLD, DWRITE_MEASURING_MODE, IDWriteRenderingParams*, DWRITE_RENDERING_MODE1*, DWRITE_GRID_FIT_MODE*, int> GetRecommendedRenderingMode3;

            [NativeTypeName("BOOL (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, uint, int> IsCharacterLocal;

            [NativeTypeName("BOOL (UINT16) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, ushort, int> IsGlyphLocal;

            [NativeTypeName("HRESULT (const WCHAR *, UINT32, BOOL, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, ushort*, uint, int, int*, int> AreCharactersLocal;

            [NativeTypeName("HRESULT (const UINT16 *, UINT32, BOOL, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, ushort*, uint, int, int*, int> AreGlyphsLocal;

            [NativeTypeName("DWRITE_GLYPH_IMAGE_FORMATS () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, DWRITE_GLYPH_IMAGE_FORMATS> GetGlyphImageFormats;

            [NativeTypeName("HRESULT (UINT16, UINT32, UINT32, DWRITE_GLYPH_IMAGE_FORMATS *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, ushort, uint, uint, DWRITE_GLYPH_IMAGE_FORMATS*, int> GetGlyphImageFormats1;

            [NativeTypeName("HRESULT (UINT16, UINT32, DWRITE_GLYPH_IMAGE_FORMATS, DWRITE_GLYPH_IMAGE_DATA *, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, ushort, uint, DWRITE_GLYPH_IMAGE_FORMATS, DWRITE_GLYPH_IMAGE_DATA*, void**, int> GetGlyphImageData;

            [NativeTypeName("void (void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontFace4*, void*, void> ReleaseGlyphImageData;
        }
    }
}