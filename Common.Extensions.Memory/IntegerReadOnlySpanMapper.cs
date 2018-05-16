using System;
using static Common.Extensions.Memory.IntegerByteMapper;
using static Common.Extensions.Memory.IntegerReadOnlySpanByteMapMapper;

namespace Common.Extensions.Memory
{
    public static class IntegerReadOnlySpanMapper
    {
        public static ReadOnlySpan<byte> MapSpan(in Int16 @int)
            => GetSpan(Map(@int));

        public static ReadOnlySpan<byte> MapSpan(in Int32 @int)
            => GetSpan(Map(@int));

        public static ReadOnlySpan<byte> MapSpan(in Int64 @int)
            => GetSpan(Map(@int));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1)
            => GetSpan(item0, item1);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1)
            => GetSpan(item0, Map(item1));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1)
            => GetSpan(item0, Map(item1));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1)
            => GetSpan(item0, Map(item1));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1)
            => GetSpan(Map(item0), item1);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1)
            => GetSpan(Map(item0), Map(item1));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1)
            => GetSpan(Map(item0), Map(item1));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1)
            => GetSpan(Map(item0), Map(item1));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1)
            => GetSpan(Map(item0), item1);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1)
            => GetSpan(Map(item0), Map(item1));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1)
            => GetSpan(Map(item0), Map(item1));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1)
            => GetSpan(Map(item0), Map(item1));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1)
            => GetSpan(Map(item0), item1);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1)
            => GetSpan(Map(item0), Map(item1));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1)
            => GetSpan(Map(item0), Map(item1));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1)
            => GetSpan(Map(item0), Map(item1));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in byte item2)
            => GetSpan(item0, item1, item2);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int16 item2)
            => GetSpan(item0, item1, Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int32 item2)
            => GetSpan(item0, item1, Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int64 item2)
            => GetSpan(item0, item1, Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in byte item2)
            => GetSpan(item0, Map(item1), item2);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int16 item2)
            => GetSpan(item0, Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int32 item2)
            => GetSpan(item0, Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int64 item2)
            => GetSpan(item0, Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in byte item2)
            => GetSpan(item0, Map(item1), item2);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int16 item2)
            => GetSpan(item0, Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int32 item2)
            => GetSpan(item0, Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int64 item2)
            => GetSpan(item0, Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in byte item2)
            => GetSpan(item0, Map(item1), item2);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int16 item2)
            => GetSpan(item0, Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int32 item2)
            => GetSpan(item0, Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int64 item2)
            => GetSpan(item0, Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in byte item2)
            => GetSpan(Map(item0), item1, item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int16 item2)
            => GetSpan(Map(item0), item1, Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int32 item2)
            => GetSpan(Map(item0), item1, Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int64 item2)
            => GetSpan(Map(item0), item1, Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in byte item2)
            => GetSpan(Map(item0), Map(item1), item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int16 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int32 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int64 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in byte item2)
            => GetSpan(Map(item0), Map(item1), item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int16 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int32 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int64 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in byte item2)
            => GetSpan(Map(item0), Map(item1), item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int16 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int32 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int64 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in byte item2)
            => GetSpan(Map(item0), item1, item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int16 item2)
            => GetSpan(Map(item0), item1, Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int32 item2)
            => GetSpan(Map(item0), item1, Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int64 item2)
            => GetSpan(Map(item0), item1, Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in byte item2)
            => GetSpan(Map(item0), Map(item1), item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int16 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int32 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int64 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in byte item2)
            => GetSpan(Map(item0), Map(item1), item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int16 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int32 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int64 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in byte item2)
            => GetSpan(Map(item0), Map(item1), item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int16 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int32 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int64 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in byte item2)
            => GetSpan(Map(item0), item1, item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int16 item2)
            => GetSpan(Map(item0), item1, Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int32 item2)
            => GetSpan(Map(item0), item1, Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int64 item2)
            => GetSpan(Map(item0), item1, Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in byte item2)
            => GetSpan(Map(item0), Map(item1), item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int16 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int32 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int64 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in byte item2)
            => GetSpan(Map(item0), Map(item1), item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int16 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int32 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int64 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in byte item2)
            => GetSpan(Map(item0), Map(item1), item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int16 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int32 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int64 item2)
            => GetSpan(Map(item0), Map(item1), Map(item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in byte item2,
            in byte item3)
            => GetSpan(item0, item1, item2, item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(item0, item1, item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(item0, item1, item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(item0, item1, item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(item0, item1, Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(item0, item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(item0, item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(item0, item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(item0, item1, Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(item0, item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(item0, item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(item0, item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(item0, item1, Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(item0, item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(item0, item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(item0, item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in byte item2,
            in byte item3)
            => GetSpan(item0, Map(item1), item2, item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(item0, Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(item0, Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(item0, Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(item0, Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(item0, Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(item0, Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in byte item2,
            in byte item3)
            => GetSpan(item0, Map(item1), item2, item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(item0, Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(item0, Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(item0, Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(item0, Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(item0, Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(item0, Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in byte item2,
            in byte item3)
            => GetSpan(item0, Map(item1), item2, item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(item0, Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(item0, Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(item0, Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(item0, Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(item0, Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(item0, Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(item0), item1, item2, item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(item0), item1, item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(item0), item1, item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(item0), item1, item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(item0), item1, Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(item0), item1, Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(item0), item1, Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), item2, item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), item2, item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), item2, item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(item0), item1, item2, item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(item0), item1, item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(item0), item1, item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(item0), item1, item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(item0), item1, Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(item0), item1, Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(item0), item1, Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), item2, item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), item2, item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), item2, item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(item0), item1, item2, item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(item0), item1, item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(item0), item1, item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(item0), item1, item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(item0), item1, Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(item0), item1, Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(item0), item1, Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), item2, item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), item2, item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), item2, item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(item0), Map(item1), Map(item2), Map(item3));
    }
}
