using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotNextPlotData
    {
        public ImGuiCond XRangeCond;
        public ImGuiCond YRangeCond_0;
        public ImGuiCond YRangeCond_1;
        public ImGuiCond YRangeCond_2;
        public ImPlotRange X;
        public ImPlotRange Y_0;
        public ImPlotRange Y_1;
        public ImPlotRange Y_2;
        public byte HasXRange;
        public fixed byte HasYRange[3];
        public byte ShowDefaultTicksX;
        public fixed byte ShowDefaultTicksY[3];
        public byte FitX;
        public fixed byte FitY[3];
        public double* LinkedXmin;
        public double* LinkedXmax;
        public double* LinkedYmin_0;
        public double* LinkedYmin_1;
        public double* LinkedYmin_2;
        public double* LinkedYmax_0;
        public double* LinkedYmax_1;
        public double* LinkedYmax_2;
    }
    public unsafe partial struct ImPlotNextPlotDataPtr
    {
        public ImPlotNextPlotData* NativePtr { get; }
        public ImPlotNextPlotDataPtr(ImPlotNextPlotData* nativePtr) => NativePtr = nativePtr;
        public ImPlotNextPlotDataPtr(IntPtr nativePtr) => NativePtr = (ImPlotNextPlotData*)nativePtr;
        public static implicit operator ImPlotNextPlotDataPtr(ImPlotNextPlotData* nativePtr) => new ImPlotNextPlotDataPtr(nativePtr);
        public static implicit operator ImPlotNextPlotData* (ImPlotNextPlotDataPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotNextPlotDataPtr(IntPtr nativePtr) => new ImPlotNextPlotDataPtr(nativePtr);
        public ref ImGuiCond XRangeCond => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->XRangeCond);
        public RangeAccessor<ImGuiCond> YRangeCond => new RangeAccessor<ImGuiCond>(&NativePtr->YRangeCond_0, 3);
        public ref ImPlotRange X => ref Unsafe.AsRef<ImPlotRange>(&NativePtr->X);
        public RangeAccessor<ImPlotRange> Y => new RangeAccessor<ImPlotRange>(&NativePtr->Y_0, 3);
        public ref bool HasXRange => ref Unsafe.AsRef<bool>(&NativePtr->HasXRange);
        public RangeAccessor<bool> HasYRange => new RangeAccessor<bool>(NativePtr->HasYRange, 3);
        public ref bool ShowDefaultTicksX => ref Unsafe.AsRef<bool>(&NativePtr->ShowDefaultTicksX);
        public RangeAccessor<bool> ShowDefaultTicksY => new RangeAccessor<bool>(NativePtr->ShowDefaultTicksY, 3);
        public ref bool FitX => ref Unsafe.AsRef<bool>(&NativePtr->FitX);
        public RangeAccessor<bool> FitY => new RangeAccessor<bool>(NativePtr->FitY, 3);
        public IntPtr LinkedXmin { get => (IntPtr)NativePtr->LinkedXmin; set => NativePtr->LinkedXmin = (double*)value; }
        public IntPtr LinkedXmax { get => (IntPtr)NativePtr->LinkedXmax; set => NativePtr->LinkedXmax = (double*)value; }
        public RangeAccessor<double*> LinkedYmin => new RangeAccessor<double*>(&NativePtr->LinkedYmin_0, 3);
        public RangeAccessor<double*> LinkedYmax => new RangeAccessor<double*>(&NativePtr->LinkedYmax_0, 3);
        public void Destroy()
        {
            ImPlotNative.ImPlotNextPlotData_destroy((ImPlotNextPlotData*)(NativePtr));
        }
        public void Reset()
        {
            ImPlotNative.ImPlotNextPlotData_Reset((ImPlotNextPlotData*)(NativePtr));
        }
    }
}
