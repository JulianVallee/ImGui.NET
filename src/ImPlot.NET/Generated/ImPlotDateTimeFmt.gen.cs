using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotDateTimeFmt
    {
        public ImPlotDateFmt Date;
        public ImPlotTimeFmt Time;
        public byte UseISO8601;
        public byte Use24HourClock;
    }
    public unsafe partial struct ImPlotDateTimeFmtPtr
    {
        public ImPlotDateTimeFmt* NativePtr { get; }
        public ImPlotDateTimeFmtPtr(ImPlotDateTimeFmt* nativePtr) => NativePtr = nativePtr;
        public ImPlotDateTimeFmtPtr(IntPtr nativePtr) => NativePtr = (ImPlotDateTimeFmt*)nativePtr;
        public static implicit operator ImPlotDateTimeFmtPtr(ImPlotDateTimeFmt* nativePtr) => new ImPlotDateTimeFmtPtr(nativePtr);
        public static implicit operator ImPlotDateTimeFmt* (ImPlotDateTimeFmtPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotDateTimeFmtPtr(IntPtr nativePtr) => new ImPlotDateTimeFmtPtr(nativePtr);
        public ref ImPlotDateFmt Date => ref Unsafe.AsRef<ImPlotDateFmt>(&NativePtr->Date);
        public ref ImPlotTimeFmt Time => ref Unsafe.AsRef<ImPlotTimeFmt>(&NativePtr->Time);
        public ref bool UseISO8601 => ref Unsafe.AsRef<bool>(&NativePtr->UseISO8601);
        public ref bool Use24HourClock => ref Unsafe.AsRef<bool>(&NativePtr->Use24HourClock);
        public void Destroy()
        {
            ImPlotNative.ImPlotDateTimeFmt_destroy((ImPlotDateTimeFmt*)(NativePtr));
        }
    }
}
