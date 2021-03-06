// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D11_VIDEO_DECODER_BUFFER_TYPE
    {
        D3D11_VIDEO_DECODER_BUFFER_PICTURE_PARAMETERS = 0,
        D3D11_VIDEO_DECODER_BUFFER_MACROBLOCK_CONTROL = 1,
        D3D11_VIDEO_DECODER_BUFFER_RESIDUAL_DIFFERENCE = 2,
        D3D11_VIDEO_DECODER_BUFFER_DEBLOCKING_CONTROL = 3,
        D3D11_VIDEO_DECODER_BUFFER_INVERSE_QUANTIZATION_MATRIX = 4,
        D3D11_VIDEO_DECODER_BUFFER_SLICE_CONTROL = 5,
        D3D11_VIDEO_DECODER_BUFFER_BITSTREAM = 6,
        D3D11_VIDEO_DECODER_BUFFER_MOTION_VECTOR = 7,
        D3D11_VIDEO_DECODER_BUFFER_FILM_GRAIN = 8,
    }
}
