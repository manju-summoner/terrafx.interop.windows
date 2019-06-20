// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public unsafe struct D3D12_SHADER_BYTECODE
    {
        #region Fields
        public void* pShaderBytecode;

        [NativeTypeName("SIZE_T")]
        public UIntPtr BytecodeLength;
        #endregion

        #region Constructors
        public D3D12_SHADER_BYTECODE(ID3DBlob* pShaderBlob)
        {
            pShaderBytecode = pShaderBlob->GetBufferPointer();
            BytecodeLength = pShaderBlob->GetBufferSize();
        }

        public D3D12_SHADER_BYTECODE(void* _pShaderBytecode, UIntPtr bytecodeLength)
        {
            pShaderBytecode = _pShaderBytecode;
            BytecodeLength = bytecodeLength;
        }
        #endregion
    }
}