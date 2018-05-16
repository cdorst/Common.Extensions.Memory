using System;
using System.Runtime.InteropServices;

namespace Common.Extensions.Memory
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly ref struct Int32ByteMap
    {
        [FieldOffset(0)] public readonly byte Byte0;
        [FieldOffset(1)] public readonly byte Byte1;
        [FieldOffset(2)] public readonly byte Byte2;
        [FieldOffset(3)] public readonly byte Byte3;

        [FieldOffset(0)] public readonly int Value;

        public Int32ByteMap(in int value)
        {
            Byte0 = default;
            Byte1 = default;
            Byte2 = default;
            Byte3 = default;
            Value = value;
        }

        public Int32ByteMap(in ReadOnlySpan<byte> bytes)
        {
            Value = default;
            Byte0 = bytes[0];
            Byte1 = bytes[1];
            Byte2 = bytes[2];
            Byte3 = bytes[3];
        }

        public ReadOnlySpan<byte> AsReadOnlySpan()
            => new [] {
                Byte0,
                Byte1,
                Byte2,
                Byte3
            };
    }
}
