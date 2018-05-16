﻿using System;
using static Common.Extensions.Memory.IntegerByteMapper;
using static Common.Extensions.Memory.IntegerReadOnlyMemoryByteMapMapper;

namespace Common.Extensions.Memory
{
    public static class IntegerReadOnlyMemoryMapper
    {
        public static ReadOnlyMemory<byte> MapMemory(in Int16 @int)
            => GetMemory(Map(@int));

        public static ReadOnlyMemory<byte> MapMemory(in Int32 @int)
            => GetMemory(Map(@int));

        public static ReadOnlyMemory<byte> MapMemory(in Int64 @int)
            => GetMemory(Map(@int));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1)
            => GetMemory(item0, item1);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1)
            => GetMemory(item0, Map(item1));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1)
            => GetMemory(item0, Map(item1));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1)
            => GetMemory(item0, Map(item1));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1)
            => GetMemory(Map(item0), item1);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1)
            => GetMemory(Map(item0), Map(item1));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1)
            => GetMemory(Map(item0), Map(item1));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1)
            => GetMemory(Map(item0), Map(item1));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1)
            => GetMemory(Map(item0), item1);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1)
            => GetMemory(Map(item0), Map(item1));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1)
            => GetMemory(Map(item0), Map(item1));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1)
            => GetMemory(Map(item0), Map(item1));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1)
            => GetMemory(Map(item0), item1);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1)
            => GetMemory(Map(item0), Map(item1));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1)
            => GetMemory(Map(item0), Map(item1));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1)
            => GetMemory(Map(item0), Map(item1));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1,
            in byte item2)
            => GetMemory(item0, item1, item2);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1,
            in Int16 item2)
            => GetMemory(item0, item1, Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1,
            in Int32 item2)
            => GetMemory(item0, item1, Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1,
            in Int64 item2)
            => GetMemory(item0, item1, Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1,
            in byte item2)
            => GetMemory(item0, Map(item1), item2);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1,
            in Int16 item2)
            => GetMemory(item0, Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1,
            in Int32 item2)
            => GetMemory(item0, Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1,
            in Int64 item2)
            => GetMemory(item0, Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1,
            in byte item2)
            => GetMemory(item0, Map(item1), item2);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1,
            in Int16 item2)
            => GetMemory(item0, Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1,
            in Int32 item2)
            => GetMemory(item0, Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1,
            in Int64 item2)
            => GetMemory(item0, Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1,
            in byte item2)
            => GetMemory(item0, Map(item1), item2);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1,
            in Int16 item2)
            => GetMemory(item0, Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1,
            in Int32 item2)
            => GetMemory(item0, Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1,
            in Int64 item2)
            => GetMemory(item0, Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1,
            in byte item2)
            => GetMemory(Map(item0), item1, item2);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1,
            in Int16 item2)
            => GetMemory(Map(item0), item1, Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1,
            in Int32 item2)
            => GetMemory(Map(item0), item1, Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1,
            in Int64 item2)
            => GetMemory(Map(item0), item1, Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1,
            in byte item2)
            => GetMemory(Map(item0), Map(item1), item2);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1,
            in Int16 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1,
            in Int32 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1,
            in Int64 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1,
            in byte item2)
            => GetMemory(Map(item0), Map(item1), item2);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1,
            in Int16 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1,
            in Int32 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1,
            in Int64 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1,
            in byte item2)
            => GetMemory(Map(item0), Map(item1), item2);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1,
            in Int16 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1,
            in Int32 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1,
            in Int64 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1,
            in byte item2)
            => GetMemory(Map(item0), item1, item2);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1,
            in Int16 item2)
            => GetMemory(Map(item0), item1, Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1,
            in Int32 item2)
            => GetMemory(Map(item0), item1, Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1,
            in Int64 item2)
            => GetMemory(Map(item0), item1, Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1,
            in byte item2)
            => GetMemory(Map(item0), Map(item1), item2);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1,
            in Int16 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1,
            in Int32 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1,
            in Int64 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1,
            in byte item2)
            => GetMemory(Map(item0), Map(item1), item2);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1,
            in Int16 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1,
            in Int32 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1,
            in Int64 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1,
            in byte item2)
            => GetMemory(Map(item0), Map(item1), item2);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1,
            in Int16 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1,
            in Int32 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1,
            in Int64 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1,
            in byte item2)
            => GetMemory(Map(item0), item1, item2);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1,
            in Int16 item2)
            => GetMemory(Map(item0), item1, Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1,
            in Int32 item2)
            => GetMemory(Map(item0), item1, Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1,
            in Int64 item2)
            => GetMemory(Map(item0), item1, Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1,
            in byte item2)
            => GetMemory(Map(item0), Map(item1), item2);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1,
            in Int16 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1,
            in Int32 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1,
            in Int64 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1,
            in byte item2)
            => GetMemory(Map(item0), Map(item1), item2);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1,
            in Int16 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1,
            in Int32 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1,
            in Int64 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1,
            in byte item2)
            => GetMemory(Map(item0), Map(item1), item2);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1,
            in Int16 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1,
            in Int32 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1,
            in Int64 item2)
            => GetMemory(Map(item0), Map(item1), Map(item2));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1,
            in byte item2,
            in byte item3)
            => GetMemory(item0, item1, item2, item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1,
            in byte item2,
            in Int16 item3)
            => GetMemory(item0, item1, item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1,
            in byte item2,
            in Int32 item3)
            => GetMemory(item0, item1, item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1,
            in byte item2,
            in Int64 item3)
            => GetMemory(item0, item1, item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1,
            in Int16 item2,
            in byte item3)
            => GetMemory(item0, item1, Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1,
            in Int16 item2,
            in Int16 item3)
            => GetMemory(item0, item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1,
            in Int16 item2,
            in Int32 item3)
            => GetMemory(item0, item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1,
            in Int16 item2,
            in Int64 item3)
            => GetMemory(item0, item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1,
            in Int32 item2,
            in byte item3)
            => GetMemory(item0, item1, Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1,
            in Int32 item2,
            in Int16 item3)
            => GetMemory(item0, item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1,
            in Int32 item2,
            in Int32 item3)
            => GetMemory(item0, item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1,
            in Int32 item2,
            in Int64 item3)
            => GetMemory(item0, item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1,
            in Int64 item2,
            in byte item3)
            => GetMemory(item0, item1, Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1,
            in Int64 item2,
            in Int16 item3)
            => GetMemory(item0, item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1,
            in Int64 item2,
            in Int32 item3)
            => GetMemory(item0, item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in byte item1,
            in Int64 item2,
            in Int64 item3)
            => GetMemory(item0, item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1,
            in byte item2,
            in byte item3)
            => GetMemory(item0, Map(item1), item2, item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1,
            in byte item2,
            in Int16 item3)
            => GetMemory(item0, Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1,
            in byte item2,
            in Int32 item3)
            => GetMemory(item0, Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1,
            in byte item2,
            in Int64 item3)
            => GetMemory(item0, Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1,
            in Int16 item2,
            in byte item3)
            => GetMemory(item0, Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1,
            in Int16 item2,
            in Int16 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1,
            in Int16 item2,
            in Int32 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1,
            in Int16 item2,
            in Int64 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1,
            in Int32 item2,
            in byte item3)
            => GetMemory(item0, Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1,
            in Int32 item2,
            in Int16 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1,
            in Int32 item2,
            in Int32 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1,
            in Int32 item2,
            in Int64 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1,
            in Int64 item2,
            in byte item3)
            => GetMemory(item0, Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1,
            in Int64 item2,
            in Int16 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1,
            in Int64 item2,
            in Int32 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int16 item1,
            in Int64 item2,
            in Int64 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1,
            in byte item2,
            in byte item3)
            => GetMemory(item0, Map(item1), item2, item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1,
            in byte item2,
            in Int16 item3)
            => GetMemory(item0, Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1,
            in byte item2,
            in Int32 item3)
            => GetMemory(item0, Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1,
            in byte item2,
            in Int64 item3)
            => GetMemory(item0, Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1,
            in Int16 item2,
            in byte item3)
            => GetMemory(item0, Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1,
            in Int16 item2,
            in Int16 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1,
            in Int16 item2,
            in Int32 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1,
            in Int16 item2,
            in Int64 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1,
            in Int32 item2,
            in byte item3)
            => GetMemory(item0, Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1,
            in Int32 item2,
            in Int16 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1,
            in Int32 item2,
            in Int32 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1,
            in Int32 item2,
            in Int64 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1,
            in Int64 item2,
            in byte item3)
            => GetMemory(item0, Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1,
            in Int64 item2,
            in Int16 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1,
            in Int64 item2,
            in Int32 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int32 item1,
            in Int64 item2,
            in Int64 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1,
            in byte item2,
            in byte item3)
            => GetMemory(item0, Map(item1), item2, item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1,
            in byte item2,
            in Int16 item3)
            => GetMemory(item0, Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1,
            in byte item2,
            in Int32 item3)
            => GetMemory(item0, Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1,
            in byte item2,
            in Int64 item3)
            => GetMemory(item0, Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1,
            in Int16 item2,
            in byte item3)
            => GetMemory(item0, Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1,
            in Int16 item2,
            in Int16 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1,
            in Int16 item2,
            in Int32 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1,
            in Int16 item2,
            in Int64 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1,
            in Int32 item2,
            in byte item3)
            => GetMemory(item0, Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1,
            in Int32 item2,
            in Int16 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1,
            in Int32 item2,
            in Int32 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1,
            in Int32 item2,
            in Int64 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1,
            in Int64 item2,
            in byte item3)
            => GetMemory(item0, Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1,
            in Int64 item2,
            in Int16 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1,
            in Int64 item2,
            in Int32 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in byte item0,
            in Int64 item1,
            in Int64 item2,
            in Int64 item3)
            => GetMemory(item0, Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1,
            in byte item2,
            in byte item3)
            => GetMemory(Map(item0), item1, item2, item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1,
            in byte item2,
            in Int16 item3)
            => GetMemory(Map(item0), item1, item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1,
            in byte item2,
            in Int32 item3)
            => GetMemory(Map(item0), item1, item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1,
            in byte item2,
            in Int64 item3)
            => GetMemory(Map(item0), item1, item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1,
            in Int16 item2,
            in byte item3)
            => GetMemory(Map(item0), item1, Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1,
            in Int16 item2,
            in Int16 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1,
            in Int16 item2,
            in Int32 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1,
            in Int16 item2,
            in Int64 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1,
            in Int32 item2,
            in byte item3)
            => GetMemory(Map(item0), item1, Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1,
            in Int32 item2,
            in Int16 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1,
            in Int32 item2,
            in Int32 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1,
            in Int32 item2,
            in Int64 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1,
            in Int64 item2,
            in byte item3)
            => GetMemory(Map(item0), item1, Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1,
            in Int64 item2,
            in Int16 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1,
            in Int64 item2,
            in Int32 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in byte item1,
            in Int64 item2,
            in Int64 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1,
            in byte item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), item2, item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1,
            in byte item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1,
            in byte item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1,
            in byte item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1,
            in Int16 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1,
            in Int16 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1,
            in Int16 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1,
            in Int16 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1,
            in Int32 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1,
            in Int32 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1,
            in Int32 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1,
            in Int32 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1,
            in Int64 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1,
            in Int64 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1,
            in Int64 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int16 item1,
            in Int64 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1,
            in byte item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), item2, item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1,
            in byte item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1,
            in byte item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1,
            in byte item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1,
            in Int16 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1,
            in Int16 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1,
            in Int16 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1,
            in Int16 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1,
            in Int32 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1,
            in Int32 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1,
            in Int32 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1,
            in Int32 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1,
            in Int64 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1,
            in Int64 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1,
            in Int64 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int32 item1,
            in Int64 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1,
            in byte item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), item2, item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1,
            in byte item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1,
            in byte item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1,
            in byte item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1,
            in Int16 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1,
            in Int16 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1,
            in Int16 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1,
            in Int16 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1,
            in Int32 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1,
            in Int32 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1,
            in Int32 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1,
            in Int32 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1,
            in Int64 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1,
            in Int64 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1,
            in Int64 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int16 item0,
            in Int64 item1,
            in Int64 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1,
            in byte item2,
            in byte item3)
            => GetMemory(Map(item0), item1, item2, item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1,
            in byte item2,
            in Int16 item3)
            => GetMemory(Map(item0), item1, item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1,
            in byte item2,
            in Int32 item3)
            => GetMemory(Map(item0), item1, item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1,
            in byte item2,
            in Int64 item3)
            => GetMemory(Map(item0), item1, item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1,
            in Int16 item2,
            in byte item3)
            => GetMemory(Map(item0), item1, Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1,
            in Int16 item2,
            in Int16 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1,
            in Int16 item2,
            in Int32 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1,
            in Int16 item2,
            in Int64 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1,
            in Int32 item2,
            in byte item3)
            => GetMemory(Map(item0), item1, Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1,
            in Int32 item2,
            in Int16 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1,
            in Int32 item2,
            in Int32 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1,
            in Int32 item2,
            in Int64 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1,
            in Int64 item2,
            in byte item3)
            => GetMemory(Map(item0), item1, Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1,
            in Int64 item2,
            in Int16 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1,
            in Int64 item2,
            in Int32 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in byte item1,
            in Int64 item2,
            in Int64 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1,
            in byte item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), item2, item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1,
            in byte item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1,
            in byte item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1,
            in byte item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1,
            in Int16 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1,
            in Int16 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1,
            in Int16 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1,
            in Int16 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1,
            in Int32 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1,
            in Int32 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1,
            in Int32 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1,
            in Int32 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1,
            in Int64 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1,
            in Int64 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1,
            in Int64 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int16 item1,
            in Int64 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1,
            in byte item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), item2, item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1,
            in byte item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1,
            in byte item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1,
            in byte item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1,
            in Int16 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1,
            in Int16 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1,
            in Int16 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1,
            in Int16 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1,
            in Int32 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1,
            in Int32 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1,
            in Int32 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1,
            in Int32 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1,
            in Int64 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1,
            in Int64 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1,
            in Int64 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int32 item1,
            in Int64 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1,
            in byte item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), item2, item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1,
            in byte item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1,
            in byte item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1,
            in byte item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1,
            in Int16 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1,
            in Int16 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1,
            in Int16 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1,
            in Int16 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1,
            in Int32 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1,
            in Int32 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1,
            in Int32 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1,
            in Int32 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1,
            in Int64 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1,
            in Int64 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1,
            in Int64 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int32 item0,
            in Int64 item1,
            in Int64 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1,
            in byte item2,
            in byte item3)
            => GetMemory(Map(item0), item1, item2, item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1,
            in byte item2,
            in Int16 item3)
            => GetMemory(Map(item0), item1, item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1,
            in byte item2,
            in Int32 item3)
            => GetMemory(Map(item0), item1, item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1,
            in byte item2,
            in Int64 item3)
            => GetMemory(Map(item0), item1, item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1,
            in Int16 item2,
            in byte item3)
            => GetMemory(Map(item0), item1, Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1,
            in Int16 item2,
            in Int16 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1,
            in Int16 item2,
            in Int32 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1,
            in Int16 item2,
            in Int64 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1,
            in Int32 item2,
            in byte item3)
            => GetMemory(Map(item0), item1, Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1,
            in Int32 item2,
            in Int16 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1,
            in Int32 item2,
            in Int32 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1,
            in Int32 item2,
            in Int64 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1,
            in Int64 item2,
            in byte item3)
            => GetMemory(Map(item0), item1, Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1,
            in Int64 item2,
            in Int16 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1,
            in Int64 item2,
            in Int32 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in byte item1,
            in Int64 item2,
            in Int64 item3)
            => GetMemory(Map(item0), item1, Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1,
            in byte item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), item2, item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1,
            in byte item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1,
            in byte item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1,
            in byte item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1,
            in Int16 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1,
            in Int16 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1,
            in Int16 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1,
            in Int16 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1,
            in Int32 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1,
            in Int32 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1,
            in Int32 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1,
            in Int32 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1,
            in Int64 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1,
            in Int64 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1,
            in Int64 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int16 item1,
            in Int64 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1,
            in byte item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), item2, item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1,
            in byte item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1,
            in byte item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1,
            in byte item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1,
            in Int16 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1,
            in Int16 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1,
            in Int16 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1,
            in Int16 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1,
            in Int32 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1,
            in Int32 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1,
            in Int32 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1,
            in Int32 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1,
            in Int64 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1,
            in Int64 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1,
            in Int64 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int32 item1,
            in Int64 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1,
            in byte item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), item2, item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1,
            in byte item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1,
            in byte item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1,
            in byte item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), item2, Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1,
            in Int16 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1,
            in Int16 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1,
            in Int16 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1,
            in Int16 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1,
            in Int32 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1,
            in Int32 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1,
            in Int32 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1,
            in Int32 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1,
            in Int64 item2,
            in byte item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), item3);

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1,
            in Int64 item2,
            in Int16 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1,
            in Int64 item2,
            in Int32 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));

        public static ReadOnlyMemory<byte> MapMemory(
            in Int64 item0,
            in Int64 item1,
            in Int64 item2,
            in Int64 item3)
            => GetMemory(Map(item0), Map(item1), Map(item2), Map(item3));
    }
}