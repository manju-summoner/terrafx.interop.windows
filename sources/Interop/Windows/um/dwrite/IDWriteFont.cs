// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using TerraFX.Utilities;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>The IDWriteFont interface represents a physical font in a font collection.</summary>
    [Guid("ACD16696-8C14-4F5D-877E-FE3FC1D32737")]
    [Unmanaged]
    public unsafe struct IDWriteFont
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteFont* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteFont* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteFont* This
        );
        #endregion

        #region Delegates
        /// <summary>Gets the font family to which the specified font belongs.</summary>
        /// <param name="fontFamily">Receives a pointer to the font family object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFontFamily(
            [In] IDWriteFont* This,
            [Out] IDWriteFontFamily** fontFamily
        );

        /// <summary>Gets the weight of the specified font.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FONT_WEIGHT _GetWeight(
            [In] IDWriteFont* This
        );

        /// <summary>Gets the stretch (aka. width) of the specified font.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FONT_STRETCH _GetStretch(
            [In] IDWriteFont* This
        );

        /// <summary>Gets the style (aka. slope) of the specified font.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FONT_STYLE _GetStyle(
            [In] IDWriteFont* This
        );

        /// <summary>Returns TRUE if the font is a symbol font or FALSE if not.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("BOOL")]
        public /* static */ delegate int _IsSymbolFont(
            [In] IDWriteFont* This
        );

        /// <summary>Gets a localized strings collection containing the face names for the font (e.g., Regular or Bold), indexed by locale name.</summary>
        /// <param name="names">Receives a pointer to the newly created localized strings object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetFaceNames(
            [In] IDWriteFont* This,
            [Out] IDWriteLocalizedStrings** names
        );

        /// <summary>Gets a localized strings collection containing the specified informational strings, indexed by locale name.</summary>
        /// <param name="informationalStringID">Identifies the string to get.</param>
        /// <param name="informationalStrings">Receives a pointer to the newly created localized strings object.</param>
        /// <param name="exists">Receives the value TRUE if the font contains the specified string ID or FALSE if not.</param>
        /// <returns>Standard HRESULT error code. If the font does not contain the specified string, the return value is S_OK but informationalStrings receives a NULL pointer and exists receives the value FALSE.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetInformationalStrings(
            [In] IDWriteFont* This,
            [In] DWRITE_INFORMATIONAL_STRING_ID informationalStringID,
            [Out] IDWriteLocalizedStrings** informationalStrings,
            [Out, NativeTypeName("BOOL")] int* exists
        );

        /// <summary>Gets a value that indicates what simulation are applied to the specified font.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_FONT_SIMULATIONS _GetSimulations(
            [In] IDWriteFont* This
        );

        /// <summary>Gets the metrics for the font.</summary>
        /// <param name="fontMetrics">Receives the font metrics.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetMetrics(
            [In] IDWriteFont* This,
            [Out] DWRITE_FONT_METRICS* fontMetrics
        );

        /// <summary>Determines whether the font supports the specified character.</summary>
        /// <param name="unicodeValue">Unicode (UCS-4) character value.</param>
        /// <param name="exists">Receives the value TRUE if the font supports the specified character or FALSE if not.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _HasCharacter(
            [In] IDWriteFont* This,
            [In, NativeTypeName("UINT32")] uint unicodeValue,
            [Out, NativeTypeName("BOOL")] int* exists
        );

        /// <summary>Creates a font face object for the font.</summary>
        /// <param name="fontFace">Receives a pointer to the newly created font face object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateFontFace(
            [In] IDWriteFont* This,
            [Out] IDWriteFontFace** fontFace
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteFont* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteFont* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFont* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily(
            [Out] IDWriteFontFamily** fontFamily
        )
        {
            fixed (IDWriteFont* This = &this)
            {
                return MarshalFunction<_GetFontFamily>(lpVtbl->GetFontFamily)(
                    This,
                    fontFamily
                );
            }
        }

        public DWRITE_FONT_WEIGHT GetWeight()
        {
            fixed (IDWriteFont* This = &this)
            {
                return MarshalFunction<_GetWeight>(lpVtbl->GetWeight)(
                    This
                );
            }
        }

        public DWRITE_FONT_STRETCH GetStretch()
        {
            fixed (IDWriteFont* This = &this)
            {
                return MarshalFunction<_GetStretch>(lpVtbl->GetStretch)(
                    This
                );
            }
        }

        public DWRITE_FONT_STYLE GetStyle()
        {
            fixed (IDWriteFont* This = &this)
            {
                return MarshalFunction<_GetStyle>(lpVtbl->GetStyle)(
                    This
                );
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsSymbolFont()
        {
            fixed (IDWriteFont* This = &this)
            {
                return MarshalFunction<_IsSymbolFont>(lpVtbl->IsSymbolFont)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFaceNames(
            [Out] IDWriteLocalizedStrings** names
        )
        {
            fixed (IDWriteFont* This = &this)
            {
                return MarshalFunction<_GetFaceNames>(lpVtbl->GetFaceNames)(
                    This,
                    names
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInformationalStrings(
            [In] DWRITE_INFORMATIONAL_STRING_ID informationalStringID,
            [Out] IDWriteLocalizedStrings** informationalStrings,
            [Out, NativeTypeName("BOOL")] int* exists
        )
        {
            fixed (IDWriteFont* This = &this)
            {
                return MarshalFunction<_GetInformationalStrings>(lpVtbl->GetInformationalStrings)(
                    This,
                    informationalStringID,
                    informationalStrings,
                    exists
                );
            }
        }

        public DWRITE_FONT_SIMULATIONS GetSimulations()
        {
            fixed (IDWriteFont* This = &this)
            {
                return MarshalFunction<_GetSimulations>(lpVtbl->GetSimulations)(
                    This
                );
            }
        }

        public void GetMetrics(
            [Out] DWRITE_FONT_METRICS* fontMetrics
        )
        {
            fixed (IDWriteFont* This = &this)
            {
                MarshalFunction<_GetMetrics>(lpVtbl->GetMetrics)(
                    This,
                    fontMetrics
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int HasCharacter(
            [In, NativeTypeName("UINT32")] uint unicodeValue,
            [Out, NativeTypeName("BOOL")] int* exists
        )
        {
            fixed (IDWriteFont* This = &this)
            {
                return MarshalFunction<_HasCharacter>(lpVtbl->HasCharacter)(
                    This,
                    unicodeValue,
                    exists
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace(
            [Out] IDWriteFontFace** fontFace
        )
        {
            fixed (IDWriteFont* This = &this)
            {
                return MarshalFunction<_CreateFontFace>(lpVtbl->CreateFontFace)(
                    This,
                    fontFace
                );
            }
        }
        #endregion

        #region Structs
        [Unmanaged]
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region Fields
            public IntPtr GetFontFamily;

            public IntPtr GetWeight;

            public IntPtr GetStretch;

            public IntPtr GetStyle;

            public IntPtr IsSymbolFont;

            public IntPtr GetFaceNames;

            public IntPtr GetInformationalStrings;

            public IntPtr GetSimulations;

            public IntPtr GetMetrics;

            public IntPtr HasCharacter;

            public IntPtr CreateFontFace;
            #endregion
        }
        #endregion
    }
}