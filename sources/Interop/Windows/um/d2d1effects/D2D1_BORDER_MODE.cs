// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Specifies how the Crop effect handles the crop rectangle falling on fractional pixel coordinates.</summary>
    public enum D2D1_BORDER_MODE : uint
    {
        D2D1_BORDER_MODE_SOFT = 0,

        D2D1_BORDER_MODE_HARD = 1,

        D2D1_BORDER_MODE_FORCE_DWORD = 0xFFFFFFFF
    }
}