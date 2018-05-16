using Common.Extensions.Memory;
using System;
using Tests.Data;
using Xunit;

namespace Tests
{
    public class Int16ByteMap_AsReadOnlySpan_Method
    {
        [Theory]
        [ClassData(typeof(Int16TestData_BitConverterBytes))]
        public void Bytes_should_equal_bytes_returned_by_BitConverter_for_given_value(Int16 value, byte[] control)
        {
            var result = new Int16ByteMap(value).AsReadOnlySpan();
            for (byte i = 0; i < sizeof(Int16); i++)
                Assert.Equal(control[i], result[i]);
        }

        [Theory]
        [ClassData(typeof(Int16TestData_BitConverterBytes))]
        public void Method_should_return_same_number_of_bytes_as_control(Int16 value, byte[] control)
            => Assert.Equal(control.Length, new Int16ByteMap(value).AsReadOnlySpan().Length);
    }
}
