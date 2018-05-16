using Common.Extensions.Memory;
using System;
using Tests.Data;
using Xunit;

namespace Tests
{
    public class IntegerByteMapper_Map
    {
        [Theory]
        [ClassData(typeof(Int16TestData))]
        public void Map_returns_structure_with_same_value_as_given_Int16_value(Int16 value)
            => Assert.Equal(value, IntegerByteMapper.Map(value).Value);

        [Theory]
        [ClassData(typeof(Int32TestData))]
        public void Map_returns_structure_with_same_value_as_given_Int32_value(Int32 value)
            => Assert.Equal(value, IntegerByteMapper.Map(value).Value);

        [Theory]
        [ClassData(typeof(Int64TestData))]
        public void Map_returns_structure_with_same_value_as_given_Int64_value(Int64 value)
            => Assert.Equal(value, IntegerByteMapper.Map(value).Value);
    }
}
