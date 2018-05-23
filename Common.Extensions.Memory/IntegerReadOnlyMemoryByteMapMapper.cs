using System;

namespace Common.Extensions.Memory
{
    public static class IntegerReadOnlyMemoryByteMapMapper
    {
        public static ReadOnlyMemory<byte> GetMemory(in Int16ByteMap map)
            => new[]
            {
                map.Byte0,
                map.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(in Int32ByteMap map)
            => new[]
            {
                map.Byte0,
                map.Byte1,
                map.Byte2,
                map.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(in Int64ByteMap map)
            => new[]
            {
                map.Byte0,
                map.Byte1,
                map.Byte2,
                map.Byte3,
                map.Byte4,
                map.Byte5,
                map.Byte6,
                map.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1)
            => new[]
            {
                item0,
                item1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1,
            in byte item2)
            => new[]
            {
                item0,
                item1,
                item2
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1,
            in Int16ByteMap item2)
            => new[]
            {
                item0,
                item1,
                item2.Byte0,
                item2.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1,
            in Int32ByteMap item2)
            => new[]
            {
                item0,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1,
            in Int64ByteMap item2)
            => new[]
            {
                item0,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1,
            in byte item2)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item2
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1,
            in Int16ByteMap item2)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1,
            in Int32ByteMap item2)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1,
            in Int64ByteMap item2)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1,
            in byte item2)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1,
            in Int16ByteMap item2)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1,
            in Int32ByteMap item2)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1,
            in Int64ByteMap item2)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1,
            in byte item2)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1,
            in Int16ByteMap item2)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1,
            in Int32ByteMap item2)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1,
            in Int64ByteMap item2)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1,
            in byte item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1,
                item2
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1,
            in Int16ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1,
                item2.Byte0,
                item2.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1,
            in Int32ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1,
            in Int64ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1,
            in byte item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item2
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1,
            in Int16ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1,
            in Int32ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1,
            in Int64ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1,
            in byte item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1,
            in Int16ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1,
            in Int32ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1,
            in Int64ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1,
            in byte item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1,
            in Int16ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1,
            in Int32ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1,
            in Int64ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1,
            in byte item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1,
                item2
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1,
            in Int16ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1,
                item2.Byte0,
                item2.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1,
            in Int32ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1,
            in Int64ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1,
            in byte item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item2
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1,
            in Int16ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1,
            in Int32ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1,
            in Int64ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1,
            in byte item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1,
            in Int16ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1,
            in Int32ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1,
            in Int64ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1,
            in byte item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1,
            in Int16ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1,
            in Int32ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1,
            in Int64ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1,
            in byte item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1,
                item2
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1,
            in Int16ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1,
                item2.Byte0,
                item2.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1,
            in Int32ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1,
            in Int64ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1,
            in byte item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item2
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1,
            in Int16ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1,
            in Int32ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1,
            in Int64ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1,
            in byte item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1,
            in Int16ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1,
            in Int32ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1,
            in Int64ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1,
            in byte item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1,
            in Int16ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1,
            in Int32ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1,
            in Int64ByteMap item2)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1,
            in byte item2,
            in byte item3)
            => new[]
            {
                item0,
                item1,
                item2,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1,
            in byte item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0,
                item1,
                item2,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1,
            in byte item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0,
                item1,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1,
            in byte item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0,
                item1,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1,
            in Int16ByteMap item2,
            in byte item3)
            => new[]
            {
                item0,
                item1,
                item2.Byte0,
                item2.Byte1,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1,
            in Int16ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0,
                item1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1,
            in Int16ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0,
                item1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1,
            in Int16ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0,
                item1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1,
            in Int32ByteMap item2,
            in byte item3)
            => new[]
            {
                item0,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1,
            in Int32ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1,
            in Int32ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1,
            in Int32ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1,
            in Int64ByteMap item2,
            in byte item3)
            => new[]
            {
                item0,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1,
            in Int64ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1,
            in Int64ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in byte item1,
            in Int64ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1,
            in byte item2,
            in byte item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item2,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1,
            in byte item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item2,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1,
            in byte item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1,
            in byte item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1,
            in Int16ByteMap item2,
            in byte item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1,
            in Int16ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1,
            in Int16ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1,
            in Int16ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1,
            in Int32ByteMap item2,
            in byte item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1,
            in Int32ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1,
            in Int32ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1,
            in Int32ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1,
            in Int64ByteMap item2,
            in byte item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1,
            in Int64ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1,
            in Int64ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int16ByteMap item1,
            in Int64ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1,
            in byte item2,
            in byte item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1,
            in byte item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1,
            in byte item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1,
            in byte item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1,
            in Int16ByteMap item2,
            in byte item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1,
            in Int16ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1,
            in Int16ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1,
            in Int16ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1,
            in Int32ByteMap item2,
            in byte item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1,
            in Int32ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1,
            in Int32ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1,
            in Int32ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1,
            in Int64ByteMap item2,
            in byte item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1,
            in Int64ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1,
            in Int64ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int32ByteMap item1,
            in Int64ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1,
            in byte item2,
            in byte item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1,
            in byte item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1,
            in byte item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1,
            in byte item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1,
            in Int16ByteMap item2,
            in byte item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1,
            in Int16ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1,
            in Int16ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1,
            in Int16ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1,
            in Int32ByteMap item2,
            in byte item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1,
            in Int32ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1,
            in Int32ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1,
            in Int32ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1,
            in Int64ByteMap item2,
            in byte item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1,
            in Int64ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1,
            in Int64ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in byte item0,
            in Int64ByteMap item1,
            in Int64ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1,
            in byte item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1,
                item2,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1,
            in byte item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1,
                item2,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1,
            in byte item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1,
            in byte item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1,
            in Int16ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1,
                item2.Byte0,
                item2.Byte1,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1,
            in Int16ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1,
            in Int16ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1,
            in Int16ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1,
            in Int32ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1,
            in Int32ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1,
            in Int32ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1,
            in Int32ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1,
            in Int64ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1,
            in Int64ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1,
            in Int64ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in byte item1,
            in Int64ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1,
            in byte item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item2,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1,
            in byte item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item2,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1,
            in byte item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1,
            in byte item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1,
            in Int16ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1,
            in Int16ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1,
            in Int16ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1,
            in Int16ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1,
            in Int32ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1,
            in Int32ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1,
            in Int32ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1,
            in Int32ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1,
            in Int64ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1,
            in Int64ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1,
            in Int64ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int16ByteMap item1,
            in Int64ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1,
            in byte item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1,
            in byte item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1,
            in byte item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1,
            in byte item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1,
            in Int16ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1,
            in Int16ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1,
            in Int16ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1,
            in Int16ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1,
            in Int32ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1,
            in Int32ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1,
            in Int32ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1,
            in Int32ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1,
            in Int64ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1,
            in Int64ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1,
            in Int64ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int32ByteMap item1,
            in Int64ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1,
            in byte item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1,
            in byte item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1,
            in byte item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1,
            in byte item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1,
            in Int16ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1,
            in Int16ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1,
            in Int16ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1,
            in Int16ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1,
            in Int32ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1,
            in Int32ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1,
            in Int32ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1,
            in Int32ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1,
            in Int64ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1,
            in Int64ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1,
            in Int64ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int16ByteMap item0,
            in Int64ByteMap item1,
            in Int64ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1,
            in byte item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1,
                item2,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1,
            in byte item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1,
                item2,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1,
            in byte item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1,
            in byte item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1,
            in Int16ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1,
                item2.Byte0,
                item2.Byte1,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1,
            in Int16ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1,
            in Int16ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1,
            in Int16ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1,
            in Int32ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1,
            in Int32ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1,
            in Int32ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1,
            in Int32ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1,
            in Int64ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1,
            in Int64ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1,
            in Int64ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in byte item1,
            in Int64ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1,
            in byte item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item2,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1,
            in byte item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item2,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1,
            in byte item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1,
            in byte item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1,
            in Int16ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1,
            in Int16ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1,
            in Int16ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1,
            in Int16ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1,
            in Int32ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1,
            in Int32ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1,
            in Int32ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1,
            in Int32ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1,
            in Int64ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1,
            in Int64ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1,
            in Int64ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int16ByteMap item1,
            in Int64ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1,
            in byte item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1,
            in byte item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1,
            in byte item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1,
            in byte item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1,
            in Int16ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1,
            in Int16ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1,
            in Int16ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1,
            in Int16ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1,
            in Int32ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1,
            in Int32ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1,
            in Int32ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1,
            in Int32ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1,
            in Int64ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1,
            in Int64ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1,
            in Int64ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int32ByteMap item1,
            in Int64ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1,
            in byte item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1,
            in byte item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1,
            in byte item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1,
            in byte item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1,
            in Int16ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1,
            in Int16ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1,
            in Int16ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1,
            in Int16ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1,
            in Int32ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1,
            in Int32ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1,
            in Int32ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1,
            in Int32ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1,
            in Int64ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1,
            in Int64ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1,
            in Int64ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int32ByteMap item0,
            in Int64ByteMap item1,
            in Int64ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1,
            in byte item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1,
                item2,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1,
            in byte item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1,
                item2,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1,
            in byte item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1,
            in byte item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1,
            in Int16ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1,
                item2.Byte0,
                item2.Byte1,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1,
            in Int16ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1,
            in Int16ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1,
            in Int16ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1,
            in Int32ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1,
            in Int32ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1,
            in Int32ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1,
            in Int32ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1,
            in Int64ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1,
            in Int64ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1,
            in Int64ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in byte item1,
            in Int64ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1,
            in byte item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item2,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1,
            in byte item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item2,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1,
            in byte item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1,
            in byte item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1,
            in Int16ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1,
            in Int16ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1,
            in Int16ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1,
            in Int16ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1,
            in Int32ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1,
            in Int32ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1,
            in Int32ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1,
            in Int32ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1,
            in Int64ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1,
            in Int64ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1,
            in Int64ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int16ByteMap item1,
            in Int64ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1,
            in byte item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1,
            in byte item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1,
            in byte item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1,
            in byte item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1,
            in Int16ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1,
            in Int16ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1,
            in Int16ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1,
            in Int16ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1,
            in Int32ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1,
            in Int32ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1,
            in Int32ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1,
            in Int32ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1,
            in Int64ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1,
            in Int64ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1,
            in Int64ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int32ByteMap item1,
            in Int64ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1,
            in byte item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1,
            in byte item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1,
            in byte item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1,
            in byte item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1,
            in Int16ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1,
            in Int16ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1,
            in Int16ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1,
            in Int16ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1,
            in Int32ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1,
            in Int32ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1,
            in Int32ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1,
            in Int32ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1,
            in Int64ByteMap item2,
            in byte item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1,
            in Int64ByteMap item2,
            in Int16ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1,
            in Int64ByteMap item2,
            in Int32ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3
            };

        public static ReadOnlyMemory<byte> GetMemory(
            in Int64ByteMap item0,
            in Int64ByteMap item1,
            in Int64ByteMap item2,
            in Int64ByteMap item3)
            => new[]
            {
                item0.Byte0,
                item0.Byte1,
                item0.Byte2,
                item0.Byte3,
                item0.Byte4,
                item0.Byte5,
                item0.Byte6,
                item0.Byte7,
                item1.Byte0,
                item1.Byte1,
                item1.Byte2,
                item1.Byte3,
                item1.Byte4,
                item1.Byte5,
                item1.Byte6,
                item1.Byte7,
                item2.Byte0,
                item2.Byte1,
                item2.Byte2,
                item2.Byte3,
                item2.Byte4,
                item2.Byte5,
                item2.Byte6,
                item2.Byte7,
                item3.Byte0,
                item3.Byte1,
                item3.Byte2,
                item3.Byte3,
                item3.Byte4,
                item3.Byte5,
                item3.Byte6,
                item3.Byte7
            };
    }
}
