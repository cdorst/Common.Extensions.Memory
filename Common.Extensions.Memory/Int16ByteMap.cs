using System;
using System.Runtime.InteropServices;

namespace Common.Extensions.Memory
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly ref struct Int16ByteMap
    {
        [FieldOffset(0)] public readonly byte Byte0;
        [FieldOffset(1)] public readonly byte Byte1;

        [FieldOffset(0)] public readonly short Value;

        public Int16ByteMap(in short value)
        {
            Byte0 = default;
            Byte1 = default;
            Value = value;
        }

        public Int16ByteMap(in ReadOnlySpan<byte> bytes)
        {
            Value = default;
            Byte0 = bytes[0];
            Byte1 = bytes[1];
        }

        public ReadOnlySpan<byte> AsReadOnlySpan()
            => new [] {
                Byte0,
                Byte1
            };
    }
}
