// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    [return: NativeTypeName("HRESULT")]
    public unsafe delegate int pD3DDisassemble([NativeTypeName("LPCVOID")] void* pSrcData, [NativeTypeName("SIZE_T")] UIntPtr SrcDataSize, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("LPCSTR")] sbyte* szComments, [NativeTypeName("ID3DBlob **")] ID3DBlob** ppDisassembly);
}
