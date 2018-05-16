using Common.Extensions.Memory;
using System;
using Tests.Data;
using Xunit;

namespace Tests
{
    public class Int64ByteMap_Span_Constructor
    {
        [Theory]
        [ClassData(typeof(Int64TestData_BitConverterBytes))]
        public void Value_property_should_equal_given_value(Int64 value, byte[] control)
            => Assert.Equal(value, new Int64ByteMap(control.AsSpan()).Value);

        [Theory]
        [ClassData(typeof(Int64TestData_BitConverterBytes))]
        public void Bytes_should_equal_bytes_returned_by_BitConverter_for_given_value(Int64 value, byte[] control)
        {
            var result = new Int64ByteMap(control.AsSpan());
            Assert.Equal(control[0], result.Byte0);
            Assert.Equal(control[1], result.Byte1);
            Assert.Equal(control[2], result.Byte2);
            Assert.Equal(control[3], result.Byte3);
            Assert.Equal(control[4], result.Byte4);
            Assert.Equal(control[5], result.Byte5);
            Assert.Equal(control[6], result.Byte6);
            Assert.Equal(control[7], result.Byte7);
            Assert.Equal(value, result.Value);
        }
    }
}
