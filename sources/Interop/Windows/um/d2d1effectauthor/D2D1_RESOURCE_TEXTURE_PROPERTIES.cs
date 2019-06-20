// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>This is used to define a resource texture when that resource texture is created.</summary>
    [Unmanaged]
    public unsafe struct D2D1_RESOURCE_TEXTURE_PROPERTIES
    {
        #region Fields
        [NativeTypeName("UINT32[]")]
        public uint* extents;

        [NativeTypeName("UINT32")]
        public uint dimensions;

        public D2D1_BUFFER_PRECISION bufferPrecision;

        public D2D1_CHANNEL_DEPTH channelDepth;

        public D2D1_FILTER filter;

        [NativeTypeName("D2D1_EXTEND_MODE[]")]
        public D2D1_EXTEND_MODE* extendModes;
        #endregion
    }
}