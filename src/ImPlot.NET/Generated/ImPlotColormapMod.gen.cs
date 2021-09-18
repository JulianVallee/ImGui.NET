using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotColormapMod
    {
        public Vector4* Colormap;
        public int ColormapSize;
    }
    public unsafe partial struct ImPlotColormapModPtr
    {
        public ImPlotColormapMod* NativePtr { get; }
        public ImPlotColormapModPtr(ImPlotColormapMod* nativePtr) => NativePtr = nativePtr;
        public ImPlotColormapModPtr(IntPtr nativePtr) => NativePtr = (ImPlotColormapMod*)nativePtr;
        public static implicit operator ImPlotColormapModPtr(ImPlotColormapMod* nativePtr) => new ImPlotColormapModPtr(nativePtr);
        public static implicit operator ImPlotColormapMod* (ImPlotColormapModPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotColormapModPtr(IntPtr nativePtr) => new ImPlotColormapModPtr(nativePtr);
        public IntPtr Colormap { get => (IntPtr)NativePtr->Colormap; set => NativePtr->Colormap = (Vector4*)value; }
        public ref int ColormapSize => ref Unsafe.AsRef<int>(&NativePtr->ColormapSize);
        public void Destroy()
        {
            ImPlotNative.ImPlotColormapMod_destroy((ImPlotColormapMod*)(NativePtr));
        }
    }
}
