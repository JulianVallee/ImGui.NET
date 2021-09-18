using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotTime
    {
        public time_t S;
        public int Us;
    }
    public unsafe partial struct ImPlotTimePtr
    {
        public ImPlotTime* NativePtr { get; }
        public ImPlotTimePtr(ImPlotTime* nativePtr) => NativePtr = nativePtr;
        public ImPlotTimePtr(IntPtr nativePtr) => NativePtr = (ImPlotTime*)nativePtr;
        public static implicit operator ImPlotTimePtr(ImPlotTime* nativePtr) => new ImPlotTimePtr(nativePtr);
        public static implicit operator ImPlotTime* (ImPlotTimePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotTimePtr(IntPtr nativePtr) => new ImPlotTimePtr(nativePtr);
        public ref time_t S => ref Unsafe.AsRef<time_t>(&NativePtr->S);
        public ref int Us => ref Unsafe.AsRef<int>(&NativePtr->Us);
        public void Destroy()
        {
            ImPlotNative.ImPlotTime_destroy((ImPlotTime*)(NativePtr));
        }
        public ImPlotTime FromDouble(double t)
        {
            ImPlotTime __retval;
            ImPlotNative.ImPlotTime_FromDouble(&__retval, t);
            return __retval;
        }
        public void RollOver()
        {
            ImPlotNative.ImPlotTime_RollOver((ImPlotTime*)(NativePtr));
        }
        public double ToDouble()
        {
            double ret = ImPlotNative.ImPlotTime_ToDouble((ImPlotTime*)(NativePtr));
            return ret;
        }
    }
}
