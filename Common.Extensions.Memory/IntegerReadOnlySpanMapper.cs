using System;
using static Common.Extensions.Memory.IntegerByteMapper;
using static Common.Extensions.Memory.IntegerReadOnlySpanByteMapMapper;

namespace Common.Extensions.Memory
{
    public static class IntegerReadOnlySpanMapper
    {
        public static ReadOnlySpan<byte> MapSpan(in Int16 @int)
            => GetSpan(Map(in @int));

        public static ReadOnlySpan<byte> MapSpan(in Int32 @int)
            => GetSpan(Map(in @int));

        public static ReadOnlySpan<byte> MapSpan(in Int64 @int)
            => GetSpan(Map(in @int));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1)
            => GetSpan(in item0, in item1);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1)
            => GetSpan(in item0, Map(in item1));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1)
            => GetSpan(in item0, Map(in item1));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1)
            => GetSpan(in item0, Map(in item1));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1)
            => GetSpan(Map(in item0), in item1);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1)
            => GetSpan(Map(in item0), Map(in item1));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1)
            => GetSpan(Map(in item0), Map(in item1));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1)
            => GetSpan(Map(in item0), Map(in item1));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1)
            => GetSpan(Map(in item0), in item1);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1)
            => GetSpan(Map(in item0), Map(in item1));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1)
            => GetSpan(Map(in item0), Map(in item1));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1)
            => GetSpan(Map(in item0), Map(in item1));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1)
            => GetSpan(Map(in item0), in item1);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1)
            => GetSpan(Map(in item0), Map(in item1));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1)
            => GetSpan(Map(in item0), Map(in item1));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1)
            => GetSpan(Map(in item0), Map(in item1));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in byte item2)
            => GetSpan(in item0, in item1, in item2);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int16 item2)
            => GetSpan(in item0, in item1, Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int32 item2)
            => GetSpan(in item0, in item1, Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int64 item2)
            => GetSpan(in item0, in item1, Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in byte item2)
            => GetSpan(in item0, Map(in item1), in item2);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int16 item2)
            => GetSpan(in item0, Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int32 item2)
            => GetSpan(in item0, Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int64 item2)
            => GetSpan(in item0, Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in byte item2)
            => GetSpan(in item0, Map(in item1), in item2);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int16 item2)
            => GetSpan(in item0, Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int32 item2)
            => GetSpan(in item0, Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int64 item2)
            => GetSpan(in item0, Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in byte item2)
            => GetSpan(in item0, Map(in item1), in item2);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int16 item2)
            => GetSpan(in item0, Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int32 item2)
            => GetSpan(in item0, Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int64 item2)
            => GetSpan(in item0, Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in byte item2)
            => GetSpan(Map(in item0), in item1, in item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int16 item2)
            => GetSpan(Map(in item0), in item1, Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int32 item2)
            => GetSpan(Map(in item0), in item1, Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int64 item2)
            => GetSpan(Map(in item0), in item1, Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in byte item2)
            => GetSpan(Map(in item0), Map(in item1), in item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int16 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int32 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int64 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in byte item2)
            => GetSpan(Map(in item0), Map(in item1), in item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int16 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int32 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int64 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in byte item2)
            => GetSpan(Map(in item0), Map(in item1), in item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int16 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int32 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int64 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in byte item2)
            => GetSpan(Map(in item0), in item1, in item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int16 item2)
            => GetSpan(Map(in item0), in item1, Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int32 item2)
            => GetSpan(Map(in item0), in item1, Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int64 item2)
            => GetSpan(Map(in item0), in item1, Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in byte item2)
            => GetSpan(Map(in item0), Map(in item1), in item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int16 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int32 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int64 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in byte item2)
            => GetSpan(Map(in item0), Map(in item1), in item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int16 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int32 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int64 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in byte item2)
            => GetSpan(Map(in item0), Map(in item1), in item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int16 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int32 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int64 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in byte item2)
            => GetSpan(Map(in item0), in item1, in item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int16 item2)
            => GetSpan(Map(in item0), in item1, Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int32 item2)
            => GetSpan(Map(in item0), in item1, Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int64 item2)
            => GetSpan(Map(in item0), in item1, Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in byte item2)
            => GetSpan(Map(in item0), Map(in item1), in item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int16 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int32 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int64 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in byte item2)
            => GetSpan(Map(in item0), Map(in item1), in item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int16 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int32 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int64 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in byte item2)
            => GetSpan(Map(in item0), Map(in item1), in item2);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int16 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int32 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int64 item2)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in byte item2,
            in byte item3)
            => GetSpan(in item0, in item1, in item2, in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(in item0, in item1, in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(in item0, in item1, in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(in item0, in item1, in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(in item0, in item1, Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(in item0, in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(in item0, in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(in item0, in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(in item0, in item1, Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(in item0, in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(in item0, in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(in item0, in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(in item0, in item1, Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(in item0, in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(in item0, in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in byte item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(in item0, in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in byte item2,
            in byte item3)
            => GetSpan(in item0, Map(in item1), in item2, in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(in item0, Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(in item0, Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(in item0, Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int16 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in byte item2,
            in byte item3)
            => GetSpan(in item0, Map(in item1), in item2, in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(in item0, Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(in item0, Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(in item0, Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int32 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in byte item2,
            in byte item3)
            => GetSpan(in item0, Map(in item1), in item2, in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(in item0, Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(in item0, Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(in item0, Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in byte item0,
            in Int64 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(in item0, Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(in item0), in item1, in item2, in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(in item0), in item1, in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(in item0), in item1, in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(in item0), in item1, in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in byte item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int16 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int32 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int16 item0,
            in Int64 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(in item0), in item1, in item2, in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(in item0), in item1, in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(in item0), in item1, in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(in item0), in item1, in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in byte item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int16 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int32 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int32 item0,
            in Int64 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(in item0), in item1, in item2, in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(in item0), in item1, in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(in item0), in item1, in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(in item0), in item1, in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in byte item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), in item1, Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int16 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int32 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in byte item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in byte item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in byte item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in byte item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), in item2, Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int16 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int16 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int16 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int16 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int32 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int32 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int32 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int32 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int64 item2,
            in byte item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), in item3);

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int64 item2,
            in Int16 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int64 item2,
            in Int32 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));

        public static ReadOnlySpan<byte> MapSpan(
            in Int64 item0,
            in Int64 item1,
            in Int64 item2,
            in Int64 item3)
            => GetSpan(Map(in item0), Map(in item1), Map(in item2), Map(in item3));
    }
}
