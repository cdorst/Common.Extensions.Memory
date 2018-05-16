using Common.Extensions.Memory;
using System;
using Tests.Data;
using Xunit;

namespace Tests
{
    public class Int32ByteMap_AsReadOnlySpan_Method
    {
        [Theory]
        [ClassData(typeof(Int32TestData_BitConverterBytes))]
        public void Bytes_should_equal_bytes_returned_by_BitConverter_for_given_value(Int32 value, byte[] control)
        {
            var result = new Int32ByteMap(value).AsReadOnlySpan();
            for (byte i = 0; i < sizeof(Int32); i++)
                Assert.Equal(control[i], result[i]);
        }

        [Theory]
        [ClassData(typeof(Int32TestData_BitConverterBytes))]
        public void Method_should_return_same_number_of_bytes_as_control(Int32 value, byte[] control)
            => Assert.Equal(control.Length, new Int32ByteMap(value).AsReadOnlySpan().Length);
    }
}
