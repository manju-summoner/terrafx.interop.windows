// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_ROOT_DESCRIPTOR
    {
        public D3D12_ROOT_DESCRIPTOR([NativeTypeName("UINT")] uint shaderRegister, [NativeTypeName("UINT")] uint registerSpace = 0)
        {
            Init(out this, shaderRegister, registerSpace);
        }

        public void Init([NativeTypeName("UINT")] uint shaderRegister, [NativeTypeName("UINT")] uint registerSpace = 0)
        {
            Init(out this, shaderRegister, registerSpace);
        }

        public static void Init([NativeTypeName("D3D12_ROOT_DESCRIPTOR &")] out D3D12_ROOT_DESCRIPTOR table, [NativeTypeName("UINT")] uint shaderRegister, [NativeTypeName("UINT")] uint registerSpace = 0)
        {
            table.ShaderRegister = shaderRegister;
            table.RegisterSpace = registerSpace;
        }
    }
}
