using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotLegendData
    {
        public ImVector Indices;
        public ImGuiTextBuffer Labels;
    }
    public unsafe partial struct ImPlotLegendDataPtr
    {
        public ImPlotLegendData* NativePtr { get; }
        public ImPlotLegendDataPtr(ImPlotLegendData* nativePtr) => NativePtr = nativePtr;
        public ImPlotLegendDataPtr(IntPtr nativePtr) => NativePtr = (ImPlotLegendData*)nativePtr;
        public static implicit operator ImPlotLegendDataPtr(ImPlotLegendData* nativePtr) => new ImPlotLegendDataPtr(nativePtr);
        public static implicit operator ImPlotLegendData* (ImPlotLegendDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotLegendDataPtr(IntPtr nativePtr) => new ImPlotLegendDataPtr(nativePtr);
        public ImVector<int> Indices => new ImVector<int>(NativePtr->Indices);
        public ref ImGuiTextBuffer Labels => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->Labels);
        public void Reset()
        {
            ImPlotNative.ImPlotLegendData_Reset((ImPlotLegendData*)(NativePtr));
        }
    }
}
