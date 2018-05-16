using Common.Extensions.Memory;
using System;
using Tests.Data;
using Xunit;

namespace Tests
{
    public class IntegerSpanExtensions_ToSpan
    {
        [Theory]
        [ClassData(typeof(Int16TestData_BitConverterBytes))]
        public void Map_returns_structure_with_same_value_as_given_Int16_value(Int16 value, byte[] control)
        {
            var result = value.ToSpan();
            for (byte i = 0; i < sizeof(Int16); i++)
                Assert.Equal(control[i], result[i]);
        }

        [Theory]
        [ClassData(typeof(Int32TestData_BitConverterBytes))]
        public void Map_returns_structure_with_same_value_as_given_Int32_value(Int32 value, byte[] control)
        {
            var result = value.ToSpan();
            for (byte i = 0; i < sizeof(Int32); i++)
                Assert.Equal(control[i], result[i]);
        }

        [Theory]
        [ClassData(typeof(Int64TestData_BitConverterBytes))]
        public void Map_returns_structure_with_same_value_as_given_Int64_value(Int64 value, byte[] control)
        {
            var result = value.ToSpan();
            for (byte i = 0; i < sizeof(Int64); i++)
                Assert.Equal(control[i], result[i]);
        }
    }
}
