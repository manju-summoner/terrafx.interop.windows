// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using TerraFX.Utilities;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("688D15C3-02B0-438D-B13A-D1B44C32C39A")]
    [Unmanaged]
    public unsafe struct ID2D1ResourceTexture
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1ResourceTexture* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1ResourceTexture* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1ResourceTexture* This
        );
        #endregion

        #region Delegates
        /// <summary>Update the vertex text.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Update(
            [In] ID2D1ResourceTexture* This,
            [In, Optional, NativeTypeName("UINT32[]")] uint* minimumExtents,
            [In, Optional, NativeTypeName("UINT32[]")] uint* maximimumExtents,
            [In, Optional, NativeTypeName("UINT32[]")] uint* strides,
            [In, NativeTypeName("UINT32")] uint dimensions,
            [In, NativeTypeName("BYTE[]")]  byte* data,
            [In, NativeTypeName("UINT32")] uint dataCount
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1ResourceTexture* This = &this)
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
            fixed (ID2D1ResourceTexture* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1ResourceTexture* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int Update(
            [In, Optional, NativeTypeName("UINT32[]")] uint* minimumExtents,
            [In, Optional, NativeTypeName("UINT32[]")] uint* maximimumExtents,
            [In, Optional, NativeTypeName("UINT32[]")] uint* strides,
            [In, NativeTypeName("UINT32")] uint dimensions,
            [In, NativeTypeName("BYTE[]")]  byte* data,
            [In, NativeTypeName("UINT32")] uint dataCount
        )
        {
            fixed (ID2D1ResourceTexture* This = &this)
            {
                return MarshalFunction<_Update>(lpVtbl->Update)(
                    This,
                    minimumExtents,
                    maximimumExtents,
                    strides,
                    dimensions,
                    data,
                    dataCount
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
            public IntPtr Update;
            #endregion
        }
        #endregion
    }
}