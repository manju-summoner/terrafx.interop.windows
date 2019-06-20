// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Defines capabilities of the underlying D3D device which may be queried using CheckFeatureSupport.</summary>
    public enum D2D1_FEATURE : uint
    {
        D2D1_FEATURE_DOUBLES = 0,

        D2D1_FEATURE_D3D10_X_HARDWARE_OPTIONS = 1,

        D2D1_FEATURE_FORCE_DWORD = 0xFFFFFFFF
    }
}