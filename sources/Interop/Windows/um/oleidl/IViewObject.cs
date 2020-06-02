// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000010D-0000-0000-C000-000000000046")]
    public unsafe partial struct IViewObject
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IViewObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IViewObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IViewObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Draw([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, [NativeTypeName("void *")] void* pvAspect, [NativeTypeName("DVTARGETDEVICE *")] DVTARGETDEVICE* ptd, [NativeTypeName("HDC")] IntPtr hdcTargetDev, [NativeTypeName("HDC")] IntPtr hdcDraw, [NativeTypeName("LPCRECTL")] RECTL* lprcBounds, [NativeTypeName("LPCRECTL")] RECTL* lprcWBounds, [NativeTypeName("BOOL (*)(ULONG_PTR) __attribute__((stdcall))")] delegate* stdcall<nuint, int> pfnContinue, [NativeTypeName("ULONG_PTR")] nuint dwContinue)
        {
            return lpVtbl->Draw((IViewObject*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, ptd, hdcTargetDev, hdcDraw, lprcBounds, lprcWBounds, pfnContinue, dwContinue);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorSet([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, [NativeTypeName("void *")] void* pvAspect, [NativeTypeName("DVTARGETDEVICE *")] DVTARGETDEVICE* ptd, [NativeTypeName("HDC")] IntPtr hicTargetDev, [NativeTypeName("LOGPALETTE **")] LOGPALETTE** ppColorSet)
        {
            return lpVtbl->GetColorSet((IViewObject*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, ptd, hicTargetDev, ppColorSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int Freeze([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, [NativeTypeName("void *")] void* pvAspect, [NativeTypeName("DWORD *")] uint* pdwFreeze)
        {
            return lpVtbl->Freeze((IViewObject*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, pdwFreeze);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unfreeze([NativeTypeName("DWORD")] uint dwFreeze)
        {
            return lpVtbl->Unfreeze((IViewObject*)Unsafe.AsPointer(ref this), dwFreeze);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetAdvise([NativeTypeName("DWORD")] uint aspects, [NativeTypeName("DWORD")] uint advf, [NativeTypeName("IAdviseSink *")] IAdviseSink* pAdvSink)
        {
            return lpVtbl->SetAdvise((IViewObject*)Unsafe.AsPointer(ref this), aspects, advf, pAdvSink);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAdvise([NativeTypeName("DWORD *")] uint* pAspects, [NativeTypeName("DWORD *")] uint* pAdvf, [NativeTypeName("IAdviseSink **")] IAdviseSink** ppAdvSink)
        {
            return lpVtbl->GetAdvise((IViewObject*)Unsafe.AsPointer(ref this), pAspects, pAdvf, ppAdvSink);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IViewObject*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IViewObject*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IViewObject*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, LONG, void *, DVTARGETDEVICE *, HDC, HDC, LPCRECTL, LPCRECTL, BOOL (*)(ULONG_PTR) __attribute__((stdcall)), ULONG_PTR) __attribute__((stdcall))")]
            public delegate* stdcall<IViewObject*, uint, int, void*, DVTARGETDEVICE*, IntPtr, IntPtr, RECTL*, RECTL*, delegate* stdcall<nuint, int>, nuint, int> Draw;

            [NativeTypeName("HRESULT (DWORD, LONG, void *, DVTARGETDEVICE *, HDC, LOGPALETTE **) __attribute__((stdcall))")]
            public delegate* stdcall<IViewObject*, uint, int, void*, DVTARGETDEVICE*, IntPtr, LOGPALETTE**, int> GetColorSet;

            [NativeTypeName("HRESULT (DWORD, LONG, void *, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IViewObject*, uint, int, void*, uint*, int> Freeze;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IViewObject*, uint, int> Unfreeze;

            [NativeTypeName("HRESULT (DWORD, DWORD, IAdviseSink *) __attribute__((stdcall))")]
            public delegate* stdcall<IViewObject*, uint, uint, IAdviseSink*, int> SetAdvise;

            [NativeTypeName("HRESULT (DWORD *, DWORD *, IAdviseSink **) __attribute__((stdcall))")]
            public delegate* stdcall<IViewObject*, uint*, uint*, IAdviseSink**, int> GetAdvise;
        }
    }
}