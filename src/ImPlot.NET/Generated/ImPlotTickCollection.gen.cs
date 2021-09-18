using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImPlotTickCollection
    {
        public ImVector Ticks;
        public ImGuiTextBuffer TextBuffer;
        public float TotalWidth;
        public float TotalHeight;
        public float MaxWidth;
        public float MaxHeight;
        public int Size;
    }
    public unsafe partial struct ImPlotTickCollectionPtr
    {
        public ImPlotTickCollection* NativePtr { get; }
        public ImPlotTickCollectionPtr(ImPlotTickCollection* nativePtr) => NativePtr = nativePtr;
        public ImPlotTickCollectionPtr(IntPtr nativePtr) => NativePtr = (ImPlotTickCollection*)nativePtr;
        public static implicit operator ImPlotTickCollectionPtr(ImPlotTickCollection* nativePtr) => new ImPlotTickCollectionPtr(nativePtr);
        public static implicit operator ImPlotTickCollection* (ImPlotTickCollectionPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImPlotTickCollectionPtr(IntPtr nativePtr) => new ImPlotTickCollectionPtr(nativePtr);
        public ImPtrVector<ImPlotTickPtr> Ticks => new ImPtrVector<ImPlotTickPtr>(NativePtr->Ticks, Unsafe.SizeOf<ImPlotTick>());
        public ref ImGuiTextBuffer TextBuffer => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->TextBuffer);
        public ref float TotalWidth => ref Unsafe.AsRef<float>(&NativePtr->TotalWidth);
        public ref float TotalHeight => ref Unsafe.AsRef<float>(&NativePtr->TotalHeight);
        public ref float MaxWidth => ref Unsafe.AsRef<float>(&NativePtr->MaxWidth);
        public ref float MaxHeight => ref Unsafe.AsRef<float>(&NativePtr->MaxHeight);
        public ref int Size => ref Unsafe.AsRef<int>(&NativePtr->Size);
        public void Append(ImPlotTick tick)
        {
            ImPlotNative.ImPlotTickCollection_Append_PlotTick((ImPlotTickCollection*)(NativePtr), tick);
        }
        public void Destroy()
        {
            ImPlotNative.ImPlotTickCollection_destroy((ImPlotTickCollection*)(NativePtr));
        }
        public string GetText(int idx)
        {
            byte* ret = ImPlotNative.ImPlotTickCollection_GetText((ImPlotTickCollection*)(NativePtr), idx);
            return Util.StringFromPtr(ret);
        }
        public void Reset()
        {
            ImPlotNative.ImPlotTickCollection_Reset((ImPlotTickCollection*)(NativePtr));
        }
    }
}
