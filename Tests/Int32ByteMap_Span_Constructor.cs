using Common.Extensions.Memory;
using System;
using Tests.Data;
using Xunit;

namespace Tests
{
    public class Int32ByteMap_Span_Constructor
    {
        [Theory]
        [ClassData(typeof(Int32TestData_BitConverterBytes))]
        public void Value_property_should_equal_given_value(Int32 value, byte[] control)
            => Assert.Equal(value, new Int32ByteMap(control.AsSpan()).Value);

        [Theory]
        [ClassData(typeof(Int32TestData_BitConverterBytes))]
        public void Bytes_should_equal_bytes_returned_by_BitConverter_for_given_value(Int32 value, byte[] control)
        {
            var result = new Int32ByteMap(control.AsSpan());
            Assert.Equal(control[0], result.Byte0);
            Assert.Equal(control[1], result.Byte1);
            Assert.Equal(control[2], result.Byte2);
            Assert.Equal(control[3], result.Byte3);
            Assert.Equal(value, result.Value);
        }
    }
}
