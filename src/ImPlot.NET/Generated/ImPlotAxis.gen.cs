using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotAxis
    {
        public ImPlotAxisFlags Flags;
        public ImPlotAxisFlags PreviousFlags;
        public ImPlotRange Range;
        public float Pixels;
        public ImPlotOrientation Orientation;
        public byte Dragging;
        public byte ExtHovered;
        public byte AllHovered;
        public byte Present;
        public byte HasRange;
        public double* LinkedMin;
        public double* LinkedMax;
        public ImPlotTime PickerTimeMin;
        public ImPlotTime PickerTimeMax;
        public int PickerLevel;
        public uint ColorMaj;
        public uint ColorMin;
        public uint ColorTxt;
        public ImGuiCond RangeCond;
        public ImRect HoverRect;
    }
    public unsafe partial struct ImPlotAxisPtr
    {
        public ImPlotAxis* NativePtr { get; }
        public ImPlotAxisPtr(ImPlotAxis* nativePtr) => NativePtr = nativePtr;
        public ImPlotAxisPtr(IntPtr nativePtr) => NativePtr = (ImPlotAxis*)nativePtr;
        public static implicit operator ImPlotAxisPtr(ImPlotAxis* nativePtr) => new ImPlotAxisPtr(nativePtr);
        public static implicit operator ImPlotAxis* (ImPlotAxisPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotAxisPtr(IntPtr nativePtr) => new ImPlotAxisPtr(nativePtr);
        public ref ImPlotAxisFlags Flags => ref Unsafe.AsRef<ImPlotAxisFlags>(&NativePtr->Flags);
        public ref ImPlotAxisFlags PreviousFlags => ref Unsafe.AsRef<ImPlotAxisFlags>(&NativePtr->PreviousFlags);
        public ref ImPlotRange Range => ref Unsafe.AsRef<ImPlotRange>(&NativePtr->Range);
        public ref float Pixels => ref Unsafe.AsRef<float>(&NativePtr->Pixels);
        public ref ImPlotOrientation Orientation => ref Unsafe.AsRef<ImPlotOrientation>(&NativePtr->Orientation);
        public ref bool Dragging => ref Unsafe.AsRef<bool>(&NativePtr->Dragging);
        public ref bool ExtHovered => ref Unsafe.AsRef<bool>(&NativePtr->ExtHovered);
        public ref bool AllHovered => ref Unsafe.AsRef<bool>(&NativePtr->AllHovered);
        public ref bool Present => ref Unsafe.AsRef<bool>(&NativePtr->Present);
        public ref bool HasRange => ref Unsafe.AsRef<bool>(&NativePtr->HasRange);
        public IntPtr LinkedMin { get => (IntPtr)NativePtr->LinkedMin; set => NativePtr->LinkedMin = (double*)value; }
        public IntPtr LinkedMax { get => (IntPtr)NativePtr->LinkedMax; set => NativePtr->LinkedMax = (double*)value; }
        public ref ImPlotTime PickerTimeMin => ref Unsafe.AsRef<ImPlotTime>(&NativePtr->PickerTimeMin);
        public ref ImPlotTime PickerTimeMax => ref Unsafe.AsRef<ImPlotTime>(&NativePtr->PickerTimeMax);
        public ref int PickerLevel => ref Unsafe.AsRef<int>(&NativePtr->PickerLevel);
        public ref uint ColorMaj => ref Unsafe.AsRef<uint>(&NativePtr->ColorMaj);
        public ref uint ColorMin => ref Unsafe.AsRef<uint>(&NativePtr->ColorMin);
        public ref uint ColorTxt => ref Unsafe.AsRef<uint>(&NativePtr->ColorTxt);
        public ref ImGuiCond RangeCond => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->RangeCond);
        public ref ImRect HoverRect => ref Unsafe.AsRef<ImRect>(&NativePtr->HoverRect);
        public void Constrain()
        {
            ImPlotNative.ImPlotAxis_Constrain((ImPlotAxis*)(NativePtr));
        }
        public void Destroy()
        {
            ImPlotNative.ImPlotAxis_destroy((ImPlotAxis*)(NativePtr));
        }
        public double GetAspect()
        {
            double ret = ImPlotNative.ImPlotAxis_GetAspect((ImPlotAxis*)(NativePtr));
            return ret;
        }
        public bool IsAlwaysLocked()
        {
            byte ret = ImPlotNative.ImPlotAxis_IsAlwaysLocked((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool IsInverted()
        {
            byte ret = ImPlotNative.ImPlotAxis_IsInverted((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool IsLabeled()
        {
            byte ret = ImPlotNative.ImPlotAxis_IsLabeled((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool IsLocked()
        {
            byte ret = ImPlotNative.ImPlotAxis_IsLocked((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool IsLockedMax()
        {
            byte ret = ImPlotNative.ImPlotAxis_IsLockedMax((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool IsLockedMin()
        {
            byte ret = ImPlotNative.ImPlotAxis_IsLockedMin((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool IsLog()
        {
            byte ret = ImPlotNative.ImPlotAxis_IsLog((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public bool IsTime()
        {
            byte ret = ImPlotNative.ImPlotAxis_IsTime((ImPlotAxis*)(NativePtr));
            return ret != 0;
        }
        public void SetAspect(double unit_per_pix)
        {
            ImPlotNative.ImPlotAxis_SetAspect((ImPlotAxis*)(NativePtr), unit_per_pix);
        }
        public bool SetMax(double _max)
        {
            byte ret = ImPlotNative.ImPlotAxis_SetMax((ImPlotAxis*)(NativePtr), _max);
            return ret != 0;
        }
        public bool SetMin(double _min)
        {
            byte ret = ImPlotNative.ImPlotAxis_SetMin((ImPlotAxis*)(NativePtr), _min);
            return ret != 0;
        }
        public void SetRange(double _min, double _max)
        {
            ImPlotNative.ImPlotAxis_SetRange_double((ImPlotAxis*)(NativePtr), _min, _max);
        }
        public void SetRange(ImPlotRange range)
        {
            ImPlotNative.ImPlotAxis_SetRange_PlotRange((ImPlotAxis*)(NativePtr), range);
        }
    }
}
