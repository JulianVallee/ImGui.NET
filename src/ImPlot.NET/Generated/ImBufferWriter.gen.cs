using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImPlotNET
{
    public unsafe partial struct ImBufferWriter
    {
        public byte* Buffer;
        public int Size;
        public int Pos;
    }
    public unsafe partial struct ImBufferWriterPtr
    {
        public ImBufferWriter* NativePtr { get; }
        public ImBufferWriterPtr(ImBufferWriter* nativePtr) => NativePtr = nativePtr;
        public ImBufferWriterPtr(IntPtr nativePtr) => NativePtr = (ImBufferWriter*)nativePtr;
        public static implicit operator ImBufferWriterPtr(ImBufferWriter* nativePtr) => new ImBufferWriterPtr(nativePtr);
        public static implicit operator ImBufferWriter* (ImBufferWriterPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImBufferWriterPtr(IntPtr nativePtr) => new ImBufferWriterPtr(nativePtr);
        public IntPtr Buffer { get => (IntPtr)NativePtr->Buffer; set => NativePtr->Buffer = (byte*)value; }
        public ref int Size => ref Unsafe.AsRef<int>(&NativePtr->Size);
        public ref int Pos => ref Unsafe.AsRef<int>(&NativePtr->Pos);
        public void Destroy()
        {
            ImPlotNative.ImBufferWriter_destroy((ImBufferWriter*)(NativePtr));
        }
        public void Write(string fmt)
        {
            byte* native_fmt;
            int fmt_byteCount = 0;
            if (fmt != null)
            {
                fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
                if (fmt_byteCount > Util.StackAllocationSizeLimit)
                {
                    native_fmt = Util.Allocate(fmt_byteCount + 1);
                }
                else
                {
                    byte* native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
                    native_fmt = native_fmt_stackBytes;
                }
                int native_fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
                native_fmt[native_fmt_offset] = 0;
            }
            else { native_fmt = null; }
            ImPlotNative.ImBufferWriter_Write((ImBufferWriter*)(NativePtr), native_fmt);
            if (fmt_byteCount > Util.StackAllocationSizeLimit)
            {
                Util.Free(native_fmt);
            }
        }
    }
}
