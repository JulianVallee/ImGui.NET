using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotContext
    {
        public ImPool Plots;
        public ImPlotPlot* CurrentPlot;
        public ImPlotItem* CurrentItem;
        public ImPlotItem* PreviousItem;
        public ImPlotTickCollection CTicks;
        public ImPlotTickCollection XTicks;
        public ImPlotTickCollection YTicks_0;
        public ImPlotTickCollection YTicks_1;
        public ImPlotTickCollection YTicks_2;
        public fixed float YAxisReference[3];
        public ImPlotAnnotationCollection Annotations;
        public ImPlotScale Scales_0;
        public ImPlotScale Scales_1;
        public ImPlotScale Scales_2;
        public ImRect PixelRange_0;
        public ImRect PixelRange_1;
        public ImRect PixelRange_2;
        public double Mx;
        public fixed double My[3];
        public double LogDenX;
        public fixed double LogDenY[3];
        public ImPlotRange ExtentsX;
        public ImPlotRange ExtentsY_0;
        public ImPlotRange ExtentsY_1;
        public ImPlotRange ExtentsY_2;
        public byte FitThisFrame;
        public byte FitX;
        public fixed byte FitY[3];
        public byte RenderX;
        public fixed byte RenderY[3];
        public byte ChildWindowMade;
        public ImPlotStyle Style;
        public ImVector ColorModifiers;
        public ImVector StyleModifiers;
        public Vector4* Colormap;
        public int ColormapSize;
        public ImVector ColormapModifiers;
        public tm Tm;
        public int VisibleItemCount;
        public int DigitalPlotItemCnt;
        public int DigitalPlotOffset;
        public ImPlotNextPlotData NextPlotData;
        public ImPlotNextItemData NextItemData;
        public ImPlotInputMap InputMap;
        public ImPlotPoint MousePos_0;
        public ImPlotPoint MousePos_1;
        public ImPlotPoint MousePos_2;
    }
    public unsafe partial struct ImPlotContextPtr
    {
        public ImPlotContext* NativePtr { get; }
        public ImPlotContextPtr(ImPlotContext* nativePtr) => NativePtr = nativePtr;
        public ImPlotContextPtr(IntPtr nativePtr) => NativePtr = (ImPlotContext*)nativePtr;
        public static implicit operator ImPlotContextPtr(ImPlotContext* nativePtr) => new ImPlotContextPtr(nativePtr);
        public static implicit operator ImPlotContext* (ImPlotContextPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotContextPtr(IntPtr nativePtr) => new ImPlotContextPtr(nativePtr);
        public ImPtrSpan<ImPlotPlotPtr> Plots => new ImPtrSpan<ImPlotPlotPtr>(NativePtr->Plots, Unsafe.SizeOf<ImPlotPlot>());
        public ImPlotPlotPtr CurrentPlot => new ImPlotPlotPtr(NativePtr->CurrentPlot);
        public ImPlotItemPtr CurrentItem => new ImPlotItemPtr(NativePtr->CurrentItem);
        public ImPlotItemPtr PreviousItem => new ImPlotItemPtr(NativePtr->PreviousItem);
        public ref ImPlotTickCollection CTicks => ref Unsafe.AsRef<ImPlotTickCollection>(&NativePtr->CTicks);
        public ref ImPlotTickCollection XTicks => ref Unsafe.AsRef<ImPlotTickCollection>(&NativePtr->XTicks);
        public RangeAccessor<ImPlotTickCollection> YTicks => new RangeAccessor<ImPlotTickCollection>(&NativePtr->YTicks_0, 3);
        public RangeAccessor<float> YAxisReference => new RangeAccessor<float>(NativePtr->YAxisReference, 3);
        public ref ImPlotAnnotationCollection Annotations => ref Unsafe.AsRef<ImPlotAnnotationCollection>(&NativePtr->Annotations);
        public RangeAccessor<ImPlotScale> Scales => new RangeAccessor<ImPlotScale>(&NativePtr->Scales_0, 3);
        public RangeAccessor<ImRect> PixelRange => new RangeAccessor<ImRect>(&NativePtr->PixelRange_0, 3);
        public ref double Mx => ref Unsafe.AsRef<double>(&NativePtr->Mx);
        public RangeAccessor<double> My => new RangeAccessor<double>(NativePtr->My, 3);
        public ref double LogDenX => ref Unsafe.AsRef<double>(&NativePtr->LogDenX);
        public RangeAccessor<double> LogDenY => new RangeAccessor<double>(NativePtr->LogDenY, 3);
        public ref ImPlotRange ExtentsX => ref Unsafe.AsRef<ImPlotRange>(&NativePtr->ExtentsX);
        public RangeAccessor<ImPlotRange> ExtentsY => new RangeAccessor<ImPlotRange>(&NativePtr->ExtentsY_0, 3);
        public ref bool FitThisFrame => ref Unsafe.AsRef<bool>(&NativePtr->FitThisFrame);
        public ref bool FitX => ref Unsafe.AsRef<bool>(&NativePtr->FitX);
        public RangeAccessor<bool> FitY => new RangeAccessor<bool>(NativePtr->FitY, 3);
        public ref bool RenderX => ref Unsafe.AsRef<bool>(&NativePtr->RenderX);
        public RangeAccessor<bool> RenderY => new RangeAccessor<bool>(NativePtr->RenderY, 3);
        public ref bool ChildWindowMade => ref Unsafe.AsRef<bool>(&NativePtr->ChildWindowMade);
        public ref ImPlotStyle Style => ref Unsafe.AsRef<ImPlotStyle>(&NativePtr->Style);
        public ImPtrVector<ImGuiColorModPtr> ColorModifiers => new ImPtrVector<ImGuiColorModPtr>(NativePtr->ColorModifiers, Unsafe.SizeOf<ImGuiColorMod>());
        public ImPtrVector<ImGuiStyleModPtr> StyleModifiers => new ImPtrVector<ImGuiStyleModPtr>(NativePtr->StyleModifiers, Unsafe.SizeOf<ImGuiStyleMod>());
        public IntPtr Colormap { get => (IntPtr)NativePtr->Colormap; set => NativePtr->Colormap = (Vector4*)value; }
        public ref int ColormapSize => ref Unsafe.AsRef<int>(&NativePtr->ColormapSize);
        public ImPtrVector<ImPlotColormapModPtr> ColormapModifiers => new ImPtrVector<ImPlotColormapModPtr>(NativePtr->ColormapModifiers, Unsafe.SizeOf<ImPlotColormapMod>());
        public ref tm Tm => ref Unsafe.AsRef<tm>(&NativePtr->Tm);
        public ref int VisibleItemCount => ref Unsafe.AsRef<int>(&NativePtr->VisibleItemCount);
        public ref int DigitalPlotItemCnt => ref Unsafe.AsRef<int>(&NativePtr->DigitalPlotItemCnt);
        public ref int DigitalPlotOffset => ref Unsafe.AsRef<int>(&NativePtr->DigitalPlotOffset);
        public ref ImPlotNextPlotData NextPlotData => ref Unsafe.AsRef<ImPlotNextPlotData>(&NativePtr->NextPlotData);
        public ref ImPlotNextItemData NextItemData => ref Unsafe.AsRef<ImPlotNextItemData>(&NativePtr->NextItemData);
        public ref ImPlotInputMap InputMap => ref Unsafe.AsRef<ImPlotInputMap>(&NativePtr->InputMap);
        public RangeAccessor<ImPlotPoint> MousePos => new RangeAccessor<ImPlotPoint>(&NativePtr->MousePos_0, 3);
    }
}
