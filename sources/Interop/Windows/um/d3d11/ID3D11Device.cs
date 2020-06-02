// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DB6F6DDB-AC77-4E88-8253-819DF9BBF140")]
    public unsafe partial struct ID3D11Device
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D11Device*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D11Device*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D11Device*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBuffer([NativeTypeName("const D3D11_BUFFER_DESC *")] D3D11_BUFFER_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Buffer **")] ID3D11Buffer** ppBuffer)
        {
            return lpVtbl->CreateBuffer((ID3D11Device*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppBuffer);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTexture1D([NativeTypeName("const D3D11_TEXTURE1D_DESC *")] D3D11_TEXTURE1D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Texture1D **")] ID3D11Texture1D** ppTexture1D)
        {
            return lpVtbl->CreateTexture1D((ID3D11Device*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture1D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTexture2D([NativeTypeName("const D3D11_TEXTURE2D_DESC *")] D3D11_TEXTURE2D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Texture2D **")] ID3D11Texture2D** ppTexture2D)
        {
            return lpVtbl->CreateTexture2D((ID3D11Device*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture2D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateTexture3D([NativeTypeName("const D3D11_TEXTURE3D_DESC *")] D3D11_TEXTURE3D_DESC* pDesc, [NativeTypeName("const D3D11_SUBRESOURCE_DATA *")] D3D11_SUBRESOURCE_DATA* pInitialData, [NativeTypeName("ID3D11Texture3D **")] ID3D11Texture3D** ppTexture3D)
        {
            return lpVtbl->CreateTexture3D((ID3D11Device*)Unsafe.AsPointer(ref this), pDesc, pInitialData, ppTexture3D);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateShaderResourceView([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_SHADER_RESOURCE_VIEW_DESC *")] D3D11_SHADER_RESOURCE_VIEW_DESC* pDesc, [NativeTypeName("ID3D11ShaderResourceView **")] ID3D11ShaderResourceView** ppSRView)
        {
            return lpVtbl->CreateShaderResourceView((ID3D11Device*)Unsafe.AsPointer(ref this), pResource, pDesc, ppSRView);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateUnorderedAccessView([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_UNORDERED_ACCESS_VIEW_DESC *")] D3D11_UNORDERED_ACCESS_VIEW_DESC* pDesc, [NativeTypeName("ID3D11UnorderedAccessView **")] ID3D11UnorderedAccessView** ppUAView)
        {
            return lpVtbl->CreateUnorderedAccessView((ID3D11Device*)Unsafe.AsPointer(ref this), pResource, pDesc, ppUAView);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRenderTargetView([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_RENDER_TARGET_VIEW_DESC *")] D3D11_RENDER_TARGET_VIEW_DESC* pDesc, [NativeTypeName("ID3D11RenderTargetView **")] ID3D11RenderTargetView** ppRTView)
        {
            return lpVtbl->CreateRenderTargetView((ID3D11Device*)Unsafe.AsPointer(ref this), pResource, pDesc, ppRTView);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDepthStencilView([NativeTypeName("ID3D11Resource *")] ID3D11Resource* pResource, [NativeTypeName("const D3D11_DEPTH_STENCIL_VIEW_DESC *")] D3D11_DEPTH_STENCIL_VIEW_DESC* pDesc, [NativeTypeName("ID3D11DepthStencilView **")] ID3D11DepthStencilView** ppDepthStencilView)
        {
            return lpVtbl->CreateDepthStencilView((ID3D11Device*)Unsafe.AsPointer(ref this), pResource, pDesc, ppDepthStencilView);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateInputLayout([NativeTypeName("const D3D11_INPUT_ELEMENT_DESC *")] D3D11_INPUT_ELEMENT_DESC* pInputElementDescs, [NativeTypeName("UINT")] uint NumElements, [NativeTypeName("const void *")] void* pShaderBytecodeWithInputSignature, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11InputLayout **")] ID3D11InputLayout** ppInputLayout)
        {
            return lpVtbl->CreateInputLayout((ID3D11Device*)Unsafe.AsPointer(ref this), pInputElementDescs, NumElements, pShaderBytecodeWithInputSignature, BytecodeLength, ppInputLayout);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateVertexShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11VertexShader **")] ID3D11VertexShader** ppVertexShader)
        {
            return lpVtbl->CreateVertexShader((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppVertexShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGeometryShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11GeometryShader **")] ID3D11GeometryShader** ppGeometryShader)
        {
            return lpVtbl->CreateGeometryShader((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppGeometryShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateGeometryShaderWithStreamOutput([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("const D3D11_SO_DECLARATION_ENTRY *")] D3D11_SO_DECLARATION_ENTRY* pSODeclaration, [NativeTypeName("UINT")] uint NumEntries, [NativeTypeName("const UINT *")] uint* pBufferStrides, [NativeTypeName("UINT")] uint NumStrides, [NativeTypeName("UINT")] uint RasterizedStream, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11GeometryShader **")] ID3D11GeometryShader** ppGeometryShader)
        {
            return lpVtbl->CreateGeometryShaderWithStreamOutput((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pSODeclaration, NumEntries, pBufferStrides, NumStrides, RasterizedStream, pClassLinkage, ppGeometryShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePixelShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11PixelShader **")] ID3D11PixelShader** ppPixelShader)
        {
            return lpVtbl->CreatePixelShader((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppPixelShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateHullShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11HullShader **")] ID3D11HullShader** ppHullShader)
        {
            return lpVtbl->CreateHullShader((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppHullShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDomainShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11DomainShader **")] ID3D11DomainShader** ppDomainShader)
        {
            return lpVtbl->CreateDomainShader((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppDomainShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateComputeShader([NativeTypeName("const void *")] void* pShaderBytecode, [NativeTypeName("SIZE_T")] nuint BytecodeLength, [NativeTypeName("ID3D11ClassLinkage *")] ID3D11ClassLinkage* pClassLinkage, [NativeTypeName("ID3D11ComputeShader **")] ID3D11ComputeShader** ppComputeShader)
        {
            return lpVtbl->CreateComputeShader((ID3D11Device*)Unsafe.AsPointer(ref this), pShaderBytecode, BytecodeLength, pClassLinkage, ppComputeShader);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateClassLinkage([NativeTypeName("ID3D11ClassLinkage **")] ID3D11ClassLinkage** ppLinkage)
        {
            return lpVtbl->CreateClassLinkage((ID3D11Device*)Unsafe.AsPointer(ref this), ppLinkage);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateBlendState([NativeTypeName("const D3D11_BLEND_DESC *")] D3D11_BLEND_DESC* pBlendStateDesc, [NativeTypeName("ID3D11BlendState **")] ID3D11BlendState** ppBlendState)
        {
            return lpVtbl->CreateBlendState((ID3D11Device*)Unsafe.AsPointer(ref this), pBlendStateDesc, ppBlendState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDepthStencilState([NativeTypeName("const D3D11_DEPTH_STENCIL_DESC *")] D3D11_DEPTH_STENCIL_DESC* pDepthStencilDesc, [NativeTypeName("ID3D11DepthStencilState **")] ID3D11DepthStencilState** ppDepthStencilState)
        {
            return lpVtbl->CreateDepthStencilState((ID3D11Device*)Unsafe.AsPointer(ref this), pDepthStencilDesc, ppDepthStencilState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateRasterizerState([NativeTypeName("const D3D11_RASTERIZER_DESC *")] D3D11_RASTERIZER_DESC* pRasterizerDesc, [NativeTypeName("ID3D11RasterizerState **")] ID3D11RasterizerState** ppRasterizerState)
        {
            return lpVtbl->CreateRasterizerState((ID3D11Device*)Unsafe.AsPointer(ref this), pRasterizerDesc, ppRasterizerState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSamplerState([NativeTypeName("const D3D11_SAMPLER_DESC *")] D3D11_SAMPLER_DESC* pSamplerDesc, [NativeTypeName("ID3D11SamplerState **")] ID3D11SamplerState** ppSamplerState)
        {
            return lpVtbl->CreateSamplerState((ID3D11Device*)Unsafe.AsPointer(ref this), pSamplerDesc, ppSamplerState);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateQuery([NativeTypeName("const D3D11_QUERY_DESC *")] D3D11_QUERY_DESC* pQueryDesc, [NativeTypeName("ID3D11Query **")] ID3D11Query** ppQuery)
        {
            return lpVtbl->CreateQuery((ID3D11Device*)Unsafe.AsPointer(ref this), pQueryDesc, ppQuery);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePredicate([NativeTypeName("const D3D11_QUERY_DESC *")] D3D11_QUERY_DESC* pPredicateDesc, [NativeTypeName("ID3D11Predicate **")] ID3D11Predicate** ppPredicate)
        {
            return lpVtbl->CreatePredicate((ID3D11Device*)Unsafe.AsPointer(ref this), pPredicateDesc, ppPredicate);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateCounter([NativeTypeName("const D3D11_COUNTER_DESC *")] D3D11_COUNTER_DESC* pCounterDesc, [NativeTypeName("ID3D11Counter **")] ID3D11Counter** ppCounter)
        {
            return lpVtbl->CreateCounter((ID3D11Device*)Unsafe.AsPointer(ref this), pCounterDesc, ppCounter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeferredContext([NativeTypeName("UINT")] uint ContextFlags, [NativeTypeName("ID3D11DeviceContext **")] ID3D11DeviceContext** ppDeferredContext)
        {
            return lpVtbl->CreateDeferredContext((ID3D11Device*)Unsafe.AsPointer(ref this), ContextFlags, ppDeferredContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int OpenSharedResource([NativeTypeName("HANDLE")] IntPtr hResource, [NativeTypeName("const IID &")] Guid* ReturnedInterface, [NativeTypeName("void **")] void** ppResource)
        {
            return lpVtbl->OpenSharedResource((ID3D11Device*)Unsafe.AsPointer(ref this), hResource, ReturnedInterface, ppResource);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFormatSupport(DXGI_FORMAT Format, [NativeTypeName("UINT *")] uint* pFormatSupport)
        {
            return lpVtbl->CheckFormatSupport((ID3D11Device*)Unsafe.AsPointer(ref this), Format, pFormatSupport);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckMultisampleQualityLevels(DXGI_FORMAT Format, [NativeTypeName("UINT")] uint SampleCount, [NativeTypeName("UINT *")] uint* pNumQualityLevels)
        {
            return lpVtbl->CheckMultisampleQualityLevels((ID3D11Device*)Unsafe.AsPointer(ref this), Format, SampleCount, pNumQualityLevels);
        }

        public void CheckCounterInfo([NativeTypeName("D3D11_COUNTER_INFO *")] D3D11_COUNTER_INFO* pCounterInfo)
        {
            lpVtbl->CheckCounterInfo((ID3D11Device*)Unsafe.AsPointer(ref this), pCounterInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckCounter([NativeTypeName("const D3D11_COUNTER_DESC *")] D3D11_COUNTER_DESC* pDesc, [NativeTypeName("D3D11_COUNTER_TYPE *")] D3D11_COUNTER_TYPE* pType, [NativeTypeName("UINT *")] uint* pActiveCounters, [NativeTypeName("LPSTR")] sbyte* szName, [NativeTypeName("UINT *")] uint* pNameLength, [NativeTypeName("LPSTR")] sbyte* szUnits, [NativeTypeName("UINT *")] uint* pUnitsLength, [NativeTypeName("LPSTR")] sbyte* szDescription, [NativeTypeName("UINT *")] uint* pDescriptionLength)
        {
            return lpVtbl->CheckCounter((ID3D11Device*)Unsafe.AsPointer(ref this), pDesc, pType, pActiveCounters, szName, pNameLength, szUnits, pUnitsLength, szDescription, pDescriptionLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(D3D11_FEATURE Feature, [NativeTypeName("void *")] void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize)
        {
            return lpVtbl->CheckFeatureSupport((ID3D11Device*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((ID3D11Device*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((ID3D11Device*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return lpVtbl->SetPrivateDataInterface((ID3D11Device*)Unsafe.AsPointer(ref this), guid, pData);
        }

        public D3D_FEATURE_LEVEL GetFeatureLevel()
        {
            return lpVtbl->GetFeatureLevel((ID3D11Device*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetCreationFlags()
        {
            return lpVtbl->GetCreationFlags((ID3D11Device*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceRemovedReason()
        {
            return lpVtbl->GetDeviceRemovedReason((ID3D11Device*)Unsafe.AsPointer(ref this));
        }

        public void GetImmediateContext([NativeTypeName("ID3D11DeviceContext **")] ID3D11DeviceContext** ppImmediateContext)
        {
            lpVtbl->GetImmediateContext((ID3D11Device*)Unsafe.AsPointer(ref this), ppImmediateContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetExceptionMode([NativeTypeName("UINT")] uint RaiseFlags)
        {
            return lpVtbl->SetExceptionMode((ID3D11Device*)Unsafe.AsPointer(ref this), RaiseFlags);
        }

        [return: NativeTypeName("UINT")]
        public uint GetExceptionMode()
        {
            return lpVtbl->GetExceptionMode((ID3D11Device*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, uint> Release;

            [NativeTypeName("HRESULT (const D3D11_BUFFER_DESC *, const D3D11_SUBRESOURCE_DATA *, ID3D11Buffer **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, D3D11_BUFFER_DESC*, D3D11_SUBRESOURCE_DATA*, ID3D11Buffer**, int> CreateBuffer;

            [NativeTypeName("HRESULT (const D3D11_TEXTURE1D_DESC *, const D3D11_SUBRESOURCE_DATA *, ID3D11Texture1D **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, D3D11_TEXTURE1D_DESC*, D3D11_SUBRESOURCE_DATA*, ID3D11Texture1D**, int> CreateTexture1D;

            [NativeTypeName("HRESULT (const D3D11_TEXTURE2D_DESC *, const D3D11_SUBRESOURCE_DATA *, ID3D11Texture2D **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, D3D11_TEXTURE2D_DESC*, D3D11_SUBRESOURCE_DATA*, ID3D11Texture2D**, int> CreateTexture2D;

            [NativeTypeName("HRESULT (const D3D11_TEXTURE3D_DESC *, const D3D11_SUBRESOURCE_DATA *, ID3D11Texture3D **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, D3D11_TEXTURE3D_DESC*, D3D11_SUBRESOURCE_DATA*, ID3D11Texture3D**, int> CreateTexture3D;

            [NativeTypeName("HRESULT (ID3D11Resource *, const D3D11_SHADER_RESOURCE_VIEW_DESC *, ID3D11ShaderResourceView **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, ID3D11Resource*, D3D11_SHADER_RESOURCE_VIEW_DESC*, ID3D11ShaderResourceView**, int> CreateShaderResourceView;

            [NativeTypeName("HRESULT (ID3D11Resource *, const D3D11_UNORDERED_ACCESS_VIEW_DESC *, ID3D11UnorderedAccessView **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, ID3D11Resource*, D3D11_UNORDERED_ACCESS_VIEW_DESC*, ID3D11UnorderedAccessView**, int> CreateUnorderedAccessView;

            [NativeTypeName("HRESULT (ID3D11Resource *, const D3D11_RENDER_TARGET_VIEW_DESC *, ID3D11RenderTargetView **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, ID3D11Resource*, D3D11_RENDER_TARGET_VIEW_DESC*, ID3D11RenderTargetView**, int> CreateRenderTargetView;

            [NativeTypeName("HRESULT (ID3D11Resource *, const D3D11_DEPTH_STENCIL_VIEW_DESC *, ID3D11DepthStencilView **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, ID3D11Resource*, D3D11_DEPTH_STENCIL_VIEW_DESC*, ID3D11DepthStencilView**, int> CreateDepthStencilView;

            [NativeTypeName("HRESULT (const D3D11_INPUT_ELEMENT_DESC *, UINT, const void *, SIZE_T, ID3D11InputLayout **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, D3D11_INPUT_ELEMENT_DESC*, uint, void*, nuint, ID3D11InputLayout**, int> CreateInputLayout;

            [NativeTypeName("HRESULT (const void *, SIZE_T, ID3D11ClassLinkage *, ID3D11VertexShader **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, void*, nuint, ID3D11ClassLinkage*, ID3D11VertexShader**, int> CreateVertexShader;

            [NativeTypeName("HRESULT (const void *, SIZE_T, ID3D11ClassLinkage *, ID3D11GeometryShader **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, void*, nuint, ID3D11ClassLinkage*, ID3D11GeometryShader**, int> CreateGeometryShader;

            [NativeTypeName("HRESULT (const void *, SIZE_T, const D3D11_SO_DECLARATION_ENTRY *, UINT, const UINT *, UINT, UINT, ID3D11ClassLinkage *, ID3D11GeometryShader **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, void*, nuint, D3D11_SO_DECLARATION_ENTRY*, uint, uint*, uint, uint, ID3D11ClassLinkage*, ID3D11GeometryShader**, int> CreateGeometryShaderWithStreamOutput;

            [NativeTypeName("HRESULT (const void *, SIZE_T, ID3D11ClassLinkage *, ID3D11PixelShader **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, void*, nuint, ID3D11ClassLinkage*, ID3D11PixelShader**, int> CreatePixelShader;

            [NativeTypeName("HRESULT (const void *, SIZE_T, ID3D11ClassLinkage *, ID3D11HullShader **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, void*, nuint, ID3D11ClassLinkage*, ID3D11HullShader**, int> CreateHullShader;

            [NativeTypeName("HRESULT (const void *, SIZE_T, ID3D11ClassLinkage *, ID3D11DomainShader **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, void*, nuint, ID3D11ClassLinkage*, ID3D11DomainShader**, int> CreateDomainShader;

            [NativeTypeName("HRESULT (const void *, SIZE_T, ID3D11ClassLinkage *, ID3D11ComputeShader **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, void*, nuint, ID3D11ClassLinkage*, ID3D11ComputeShader**, int> CreateComputeShader;

            [NativeTypeName("HRESULT (ID3D11ClassLinkage **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, ID3D11ClassLinkage**, int> CreateClassLinkage;

            [NativeTypeName("HRESULT (const D3D11_BLEND_DESC *, ID3D11BlendState **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, D3D11_BLEND_DESC*, ID3D11BlendState**, int> CreateBlendState;

            [NativeTypeName("HRESULT (const D3D11_DEPTH_STENCIL_DESC *, ID3D11DepthStencilState **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, D3D11_DEPTH_STENCIL_DESC*, ID3D11DepthStencilState**, int> CreateDepthStencilState;

            [NativeTypeName("HRESULT (const D3D11_RASTERIZER_DESC *, ID3D11RasterizerState **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, D3D11_RASTERIZER_DESC*, ID3D11RasterizerState**, int> CreateRasterizerState;

            [NativeTypeName("HRESULT (const D3D11_SAMPLER_DESC *, ID3D11SamplerState **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, D3D11_SAMPLER_DESC*, ID3D11SamplerState**, int> CreateSamplerState;

            [NativeTypeName("HRESULT (const D3D11_QUERY_DESC *, ID3D11Query **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, D3D11_QUERY_DESC*, ID3D11Query**, int> CreateQuery;

            [NativeTypeName("HRESULT (const D3D11_QUERY_DESC *, ID3D11Predicate **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, D3D11_QUERY_DESC*, ID3D11Predicate**, int> CreatePredicate;

            [NativeTypeName("HRESULT (const D3D11_COUNTER_DESC *, ID3D11Counter **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, D3D11_COUNTER_DESC*, ID3D11Counter**, int> CreateCounter;

            [NativeTypeName("HRESULT (UINT, ID3D11DeviceContext **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, uint, ID3D11DeviceContext**, int> CreateDeferredContext;

            [NativeTypeName("HRESULT (HANDLE, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, IntPtr, Guid*, void**, int> OpenSharedResource;

            [NativeTypeName("HRESULT (DXGI_FORMAT, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, DXGI_FORMAT, uint*, int> CheckFormatSupport;

            [NativeTypeName("HRESULT (DXGI_FORMAT, UINT, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, DXGI_FORMAT, uint, uint*, int> CheckMultisampleQualityLevels;

            [NativeTypeName("void (D3D11_COUNTER_INFO *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, D3D11_COUNTER_INFO*, void> CheckCounterInfo;

            [NativeTypeName("HRESULT (const D3D11_COUNTER_DESC *, D3D11_COUNTER_TYPE *, UINT *, LPSTR, UINT *, LPSTR, UINT *, LPSTR, UINT *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, D3D11_COUNTER_DESC*, D3D11_COUNTER_TYPE*, uint*, sbyte*, uint*, sbyte*, uint*, sbyte*, uint*, int> CheckCounter;

            [NativeTypeName("HRESULT (D3D11_FEATURE, void *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, D3D11_FEATURE, void*, uint, int> CheckFeatureSupport;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("D3D_FEATURE_LEVEL () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, D3D_FEATURE_LEVEL> GetFeatureLevel;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, uint> GetCreationFlags;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, int> GetDeviceRemovedReason;

            [NativeTypeName("void (ID3D11DeviceContext **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, ID3D11DeviceContext**, void> GetImmediateContext;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, uint, int> SetExceptionMode;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D11Device*, uint> GetExceptionMode;
        }
    }
}