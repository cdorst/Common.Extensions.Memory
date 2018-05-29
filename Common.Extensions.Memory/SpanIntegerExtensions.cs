using System;

namespace Common.Extensions.Memory
{
    public static class SpanIntegerExtensions
    {
        public static Int16 AsInt16(this ReadOnlySpan<byte> span)
            => new Int16ByteMap(in span).Value;

        public static Int16 AsInt16(this Span<byte> span)
            => new Int16ByteMap(in span).Value;

        public static Int32 AsInt32(this ReadOnlySpan<byte> span)
            => new Int32ByteMap(in span).Value;

        public static Int32 AsInt32(this Span<byte> span)
            => new Int32ByteMap(in span).Value;

        public static Int64 AsInt64(this ReadOnlySpan<byte> span)
            => new Int64ByteMap(in span).Value;

        public static Int64 AsInt64(this Span<byte> span)
            => new Int64ByteMap(in span).Value;

        public static Int16 GetInt16(in ReadOnlySpan<byte> span)
            => new Int16ByteMap(in span).Value;

        public static Int16 GetInt16(in Span<byte> span)
            => new Int16ByteMap(in span).Value;

        public static Int32 GetInt32(in ReadOnlySpan<byte> span)
            => new Int32ByteMap(in span).Value;

        public static Int32 GetInt32(in Span<byte> span)
            => new Int32ByteMap(in span).Value;

        public static Int64 GetInt64(in ReadOnlySpan<byte> span)
            => new Int64ByteMap(in span).Value;

        public static Int64 GetInt64(in Span<byte> span)
            => new Int64ByteMap(in span).Value;
    }
}
