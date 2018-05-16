using Common.Extensions.Memory;
using System;
using Tests.Data;
using Xunit;

namespace Tests
{
    public class Int64ByteMap_AsReadOnlySpan_Method
    {
        [Theory]
        [ClassData(typeof(Int64TestData_BitConverterBytes))]
        public void Bytes_should_equal_bytes_returned_by_BitConverter_for_given_value(Int64 value, byte[] control)
        {
            var result = new Int64ByteMap(value).AsReadOnlySpan();
            for (byte i = 0; i < sizeof(Int64); i++)
                Assert.Equal(control[i], result[i]);
        }

        [Theory]
        [ClassData(typeof(Int64TestData_BitConverterBytes))]
        public void Method_should_return_same_number_of_bytes_as_control(Int64 value, byte[] control)
            => Assert.Equal(control.Length, new Int64ByteMap(value).AsReadOnlySpan().Length);
    }
}
