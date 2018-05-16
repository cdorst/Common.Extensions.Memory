using Common.Extensions.Memory;
using System;
using Tests.Data;
using Xunit;

namespace Tests
{
    public class Int16ByteMap_Span_Constructor
    {
        [Theory]
        [ClassData(typeof(Int16TestData_BitConverterBytes))]
        public void Value_property_should_equal_given_value(Int16 value, byte[] control)
            => Assert.Equal(value, new Int16ByteMap(control.AsSpan()).Value);

        [Theory]
        [ClassData(typeof(Int16TestData_BitConverterBytes))]
        public void Bytes_should_equal_bytes_returned_by_BitConverter_for_given_value(Int16 value, byte[] control)
        {
            var result = new Int16ByteMap(control.AsSpan());
            Assert.Equal(control[0], result.Byte0);
            Assert.Equal(control[1], result.Byte1);
            Assert.Equal(value, result.Value);
        }
    }
}
