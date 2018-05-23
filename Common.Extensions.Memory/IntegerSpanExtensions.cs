using System;

namespace Common.Extensions.Memory
{
    public static class IntegerSpanExtensions
    {
        public static ReadOnlySpan<byte> ToSpan(this Int16 value)
            => new Int16ByteMap(in value).AsReadOnlySpan();

        public static ReadOnlySpan<byte> ToSpan(this Int32 value)
            => new Int32ByteMap(in value).AsReadOnlySpan();

        public static ReadOnlySpan<byte> ToSpan(this Int64 value)
            => new Int64ByteMap(in value).AsReadOnlySpan();
    }
}
