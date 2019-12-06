// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D1_IMAGE_BRUSH_PROPERTIES
    {
        public D2D1_IMAGE_BRUSH_PROPERTIES(D2D_RECT_F sourceRectangle, D2D1_EXTEND_MODE extendModeX = D2D1_EXTEND_MODE.D2D1_EXTEND_MODE_CLAMP, D2D1_EXTEND_MODE extendModeY = D2D1_EXTEND_MODE.D2D1_EXTEND_MODE_CLAMP, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE.D2D1_INTERPOLATION_MODE_LINEAR)
        {
            this.sourceRectangle = sourceRectangle;
            this.extendModeX = extendModeX;
            this.extendModeY = extendModeY;
            this.interpolationMode = interpolationMode;
        }
    }
}