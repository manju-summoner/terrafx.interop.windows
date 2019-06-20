// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public struct D3D12_DEPTH_STENCIL_VALUE
    {
        #region Fields
        [NativeTypeName("FLOAT")]
        public float Depth;

        [NativeTypeName("UINT8")]
        public byte Stencil;
        #endregion
    }
}