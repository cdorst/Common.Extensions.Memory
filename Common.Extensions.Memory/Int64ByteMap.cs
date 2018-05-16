using System;
using System.Runtime.InteropServices;

namespace Common.Extensions.Memory
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly ref struct Int64ByteMap
    {
        [FieldOffset(0)] public readonly byte Byte0;
        [FieldOffset(1)] public readonly byte Byte1;
        [FieldOffset(2)] public readonly byte Byte2;
        [FieldOffset(3)] public readonly byte Byte3;
        [FieldOffset(4)] public readonly byte Byte4;
        [FieldOffset(5)] public readonly byte Byte5;
        [FieldOffset(6)] public readonly byte Byte6;
        [FieldOffset(7)] public readonly byte Byte7;

        [FieldOffset(0)] public readonly long Value;

        public Int64ByteMap(in long value)
        {
            Byte0 = default;
            Byte1 = default;
            Byte2 = default;
            Byte3 = default;
            Byte4 = default;
            Byte5 = default;
            Byte6 = default;
            Byte7 = default;
            Value = value;
        }

        public Int64ByteMap(in ReadOnlySpan<byte> bytes)
        {
            Value = default;
            Byte0 = bytes[0];
            Byte1 = bytes[1];
            Byte2 = bytes[2];
            Byte3 = bytes[3];
            Byte4 = bytes[4];
            Byte5 = bytes[5];
            Byte6 = bytes[6];
            Byte7 = bytes[7];
        }

        public ReadOnlySpan<byte> AsReadOnlySpan()
            => new [] {
                Byte0,
                Byte1,
                Byte2,
                Byte3,
                Byte4,
                Byte5,
                Byte6,
                Byte7
            };
    }
}
