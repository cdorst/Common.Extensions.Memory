using System;

namespace Common.Extensions.Memory
{
    public static class IntegerByteMapper
    {
        public static Int16ByteMap Map(in Int16 value)
            => new Int16ByteMap(in value);

        public static Int32ByteMap Map(in Int32 value)
            => new Int32ByteMap(in value);

        public static Int64ByteMap Map(in Int64 value)
            => new Int64ByteMap(in value);
    }
}
