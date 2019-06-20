// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public struct D3D12_TILE_SHAPE
    {
        #region Fields
        [NativeTypeName("UINT")]
        public uint WidthInTexels;

        [NativeTypeName("UINT")]
        public uint HeightInTexels;

        [NativeTypeName("UINT")]
        public uint DepthInTexels;
        #endregion

        #region Constructors
        public D3D12_TILE_SHAPE(uint widthInTexels, uint heightInTexels, uint depthInTexels)
        {
            WidthInTexels = widthInTexels;
            HeightInTexels = heightInTexels;
            DepthInTexels = depthInTexels;
        }
        #endregion
    }
}