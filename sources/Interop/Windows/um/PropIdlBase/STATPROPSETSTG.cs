// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct STATPROPSETSTG
    {
        [NativeTypeName("FMTID")]
        public Guid fmtid;

        [NativeTypeName("CLSID")]
        public Guid clsid;

        [NativeTypeName("DWORD")]
        public uint grfFlags;

        public FILETIME mtime;

        public FILETIME ctime;

        public FILETIME atime;

        [NativeTypeName("DWORD")]
        public uint dwOSVersion;
    }
}
