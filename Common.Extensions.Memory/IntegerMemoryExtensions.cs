using System;

namespace Common.Extensions.Memory
{
    public static class IntegerMemoryExtensions
    {
        public static ReadOnlyMemory<byte> ToMemory(this Int16 value)
            => new Int16ByteMap(in value).AsReadOnlyMemory();

        public static ReadOnlyMemory<byte> ToMemory(this Int32 value)
            => new Int32ByteMap(in value).AsReadOnlyMemory();

        public static ReadOnlyMemory<byte> ToMemory(this Int64 value)
            => new Int64ByteMap(in value).AsReadOnlyMemory();
    }
}
