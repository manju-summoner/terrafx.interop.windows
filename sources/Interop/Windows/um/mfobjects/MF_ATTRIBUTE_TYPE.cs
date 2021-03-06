// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.VARENUM;

namespace TerraFX.Interop
{
    public enum MF_ATTRIBUTE_TYPE
    {
        MF_ATTRIBUTE_UINT32 = VT_UI4,
        MF_ATTRIBUTE_UINT64 = VT_UI8,
        MF_ATTRIBUTE_DOUBLE = VT_R8,
        MF_ATTRIBUTE_GUID = VT_CLSID,
        MF_ATTRIBUTE_STRING = VT_LPWSTR,
        MF_ATTRIBUTE_BLOB = (VT_VECTOR | VT_UI1),
        MF_ATTRIBUTE_IUNKNOWN = VT_UNKNOWN,
    }
}
