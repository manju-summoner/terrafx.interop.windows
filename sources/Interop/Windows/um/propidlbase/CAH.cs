// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\propidlbase.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public unsafe struct CAH
    {
        #region Fields
        [NativeTypeName("ULONG")]
        public uint cElems;

        [NativeTypeName("LARGE_INTEGER[]")]
        public LARGE_INTEGER* pElems;
        #endregion
    }
}