using Common.Extensions.Memory;
using System;
using Tests.Data;
using Xunit;

namespace Tests
{
    public class Int16ByteMap_Value_Constructor
    {
        [Theory]
        [ClassData(typeof(Int16TestData))]
        public void Value_property_should_equal_given_value(Int16 value)
            => Assert.Equal(value, new Int16ByteMap(value).Value);

        [Theory]
        [ClassData(typeof(Int16TestData_BitConverterBytes))]
        public void Bytes_should_equal_bytes_returned_by_BitConverter_for_given_value(Int16 value, byte[] control)
        {
            var result = new Int16ByteMap(value);
            Assert.Equal(control[0], result.Byte0);
            Assert.Equal(control[1], result.Byte1);
        }
    }
}
