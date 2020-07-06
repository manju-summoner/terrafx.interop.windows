// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/CoreWindow.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_ICoreWindowInterop = new Guid(0x45D64A29, 0xA63E, 0x4CB6, 0xB4, 0x98, 0x57, 0x81, 0xD2, 0x98, 0xCB, 0x4F);

        public static readonly Guid IID_ICoreInputInterop = new Guid(0x40BFE3E3, 0xB75A, 0x4479, 0xAC, 0x96, 0x47, 0x53, 0x65, 0x74, 0x9B, 0xB8);
    }
}
