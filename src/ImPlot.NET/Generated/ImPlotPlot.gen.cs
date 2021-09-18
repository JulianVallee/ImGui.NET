using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotPlot
    {
        public uint ID;
        public ImPlotFlags Flags;
        public ImPlotFlags PreviousFlags;
        public ImPlotAxis XAxis;
        public ImPlotAxis YAxis_0;
        public ImPlotAxis YAxis_1;
        public ImPlotAxis YAxis_2;
        public ImPlotLegendData LegendData;
        public ImPool Items;
        public Vector2 SelectStart;
        public Vector2 QueryStart;
        public ImRect QueryRect;
        public byte Selecting;
        public byte ContextLocked;
        public byte Querying;
        public byte Queried;
        public byte DraggingQuery;
        public byte LegendHovered;
        public byte LegendOutside;
        public byte LegendFlipSideNextFrame;
        public byte FrameHovered;
        public byte PlotHovered;
        public int ColormapIdx;
        public int CurrentYAxis;
        public ImPlotLocation MousePosLocation;
        public ImPlotLocation LegendLocation;
        public ImPlotOrientation LegendOrientation;
        public ImRect FrameRect;
        public ImRect CanvasRect;
        public ImRect PlotRect;
        public ImRect AxesRect;
        public ImRect LegendRect;
    }
    public unsafe partial struct ImPlotPlotPtr
    {
        public ImPlotPlot* NativePtr { get; }
        public ImPlotPlotPtr(ImPlotPlot* nativePtr) => NativePtr = nativePtr;
        public ImPlotPlotPtr(IntPtr nativePtr) => NativePtr = (ImPlotPlot*)nativePtr;
        public static implicit operator ImPlotPlotPtr(ImPlotPlot* nativePtr) => new ImPlotPlotPtr(nativePtr);
        public static implicit operator ImPlotPlot* (ImPlotPlotPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotPlotPtr(IntPtr nativePtr) => new ImPlotPlotPtr(nativePtr);
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref ImPlotFlags Flags => ref Unsafe.AsRef<ImPlotFlags>(&NativePtr->Flags);
        public ref ImPlotFlags PreviousFlags => ref Unsafe.AsRef<ImPlotFlags>(&NativePtr->PreviousFlags);
        public ref ImPlotAxis XAxis => ref Unsafe.AsRef<ImPlotAxis>(&NativePtr->XAxis);
        public RangeAccessor<ImPlotAxis> YAxis => new RangeAccessor<ImPlotAxis>(&NativePtr->YAxis_0, 3);
        public ref ImPlotLegendData LegendData => ref Unsafe.AsRef<ImPlotLegendData>(&NativePtr->LegendData);
        public ImPtrSpan<ImPlotItemPtr> Items => new ImPtrSpan<ImPlotItemPtr>(NativePtr->Items, Unsafe.SizeOf<ImPlotItem>());
        public ref Vector2 SelectStart => ref Unsafe.AsRef<Vector2>(&NativePtr->SelectStart);
        public ref Vector2 QueryStart => ref Unsafe.AsRef<Vector2>(&NativePtr->QueryStart);
        public ref ImRect QueryRect => ref Unsafe.AsRef<ImRect>(&NativePtr->QueryRect);
        public ref bool Selecting => ref Unsafe.AsRef<bool>(&NativePtr->Selecting);
        public ref bool ContextLocked => ref Unsafe.AsRef<bool>(&NativePtr->ContextLocked);
        public ref bool Querying => ref Unsafe.AsRef<bool>(&NativePtr->Querying);
        public ref bool Queried => ref Unsafe.AsRef<bool>(&NativePtr->Queried);
        public ref bool DraggingQuery => ref Unsafe.AsRef<bool>(&NativePtr->DraggingQuery);
        public ref bool LegendHovered => ref Unsafe.AsRef<bool>(&NativePtr->LegendHovered);
        public ref bool LegendOutside => ref Unsafe.AsRef<bool>(&NativePtr->LegendOutside);
        public ref bool LegendFlipSideNextFrame => ref Unsafe.AsRef<bool>(&NativePtr->LegendFlipSideNextFrame);
        public ref bool FrameHovered => ref Unsafe.AsRef<bool>(&NativePtr->FrameHovered);
        public ref bool PlotHovered => ref Unsafe.AsRef<bool>(&NativePtr->PlotHovered);
        public ref int ColormapIdx => ref Unsafe.AsRef<int>(&NativePtr->ColormapIdx);
        public ref int CurrentYAxis => ref Unsafe.AsRef<int>(&NativePtr->CurrentYAxis);
        public ref ImPlotLocation MousePosLocation => ref Unsafe.AsRef<ImPlotLocation>(&NativePtr->MousePosLocation);
        public ref ImPlotLocation LegendLocation => ref Unsafe.AsRef<ImPlotLocation>(&NativePtr->LegendLocation);
        public ref ImPlotOrientation LegendOrientation => ref Unsafe.AsRef<ImPlotOrientation>(&NativePtr->LegendOrientation);
        public ref ImRect FrameRect => ref Unsafe.AsRef<ImRect>(&NativePtr->FrameRect);
        public ref ImRect CanvasRect => ref Unsafe.AsRef<ImRect>(&NativePtr->CanvasRect);
        public ref ImRect PlotRect => ref Unsafe.AsRef<ImRect>(&NativePtr->PlotRect);
        public ref ImRect AxesRect => ref Unsafe.AsRef<ImRect>(&NativePtr->AxesRect);
        public ref ImRect LegendRect => ref Unsafe.AsRef<ImRect>(&NativePtr->LegendRect);
        public void Destroy()
        {
            ImPlotNative.ImPlotPlot_destroy((ImPlotPlot*)(NativePtr));
        }
        public int GetLegendCount()
        {
            int ret = ImPlotNative.ImPlotPlot_GetLegendCount((ImPlotPlot*)(NativePtr));
            return ret;
        }
        public ImPlotItemPtr GetLegendItem(int i)
        {
            ImPlotItem* ret = ImPlotNative.ImPlotPlot_GetLegendItem((ImPlotPlot*)(NativePtr), i);
            return new ImPlotItemPtr(ret);
        }
        public string GetLegendLabel(int i)
        {
            byte* ret = ImPlotNative.ImPlotPlot_GetLegendLabel((ImPlotPlot*)(NativePtr), i);
            return Util.StringFromPtr(ret);
        }
        public bool IsLocked()
        {
            byte ret = ImPlotNative.ImPlotPlot_IsLocked((ImPlotPlot*)(NativePtr));
            return ret != 0;
        }
    }
}
