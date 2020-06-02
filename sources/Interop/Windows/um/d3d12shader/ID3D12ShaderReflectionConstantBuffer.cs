// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C59598B4-48B3-4869-B9B1-B1618B14A8B7")]
    public unsafe partial struct ID3D12ShaderReflectionConstantBuffer
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int GetDesc([NativeTypeName("D3D12_SHADER_BUFFER_DESC *")] D3D12_SHADER_BUFFER_DESC* pDesc)
        {
            return lpVtbl->GetDesc((ID3D12ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), pDesc);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionVariable *")]
        public ID3D12ShaderReflectionVariable* GetVariableByIndex([NativeTypeName("UINT")] uint Index)
        {
            return lpVtbl->GetVariableByIndex((ID3D12ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Index);
        }

        [return: NativeTypeName("ID3D12ShaderReflectionVariable *")]
        public ID3D12ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return lpVtbl->GetVariableByName((ID3D12ShaderReflectionConstantBuffer*)Unsafe.AsPointer(ref this), Name);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (D3D12_SHADER_BUFFER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflectionConstantBuffer*, D3D12_SHADER_BUFFER_DESC*, int> GetDesc;

            [NativeTypeName("ID3D12ShaderReflectionVariable *(UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflectionConstantBuffer*, uint, ID3D12ShaderReflectionVariable*> GetVariableByIndex;

            [NativeTypeName("ID3D12ShaderReflectionVariable *(LPCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12ShaderReflectionConstantBuffer*, sbyte*, ID3D12ShaderReflectionVariable*> GetVariableByName;
        }
    }
}