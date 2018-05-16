using Xunit;

namespace Tests.Assertions
{
    public static class ByteArrayEqualityAssertor
    {
        public static void AssertEqual(in byte[] control, in byte[] result)
        {
            var length = control.Length;
            Assert.Equal(length, result.Length);
            for (byte i = 0; i < length; i++)
                Assert.Equal(control[i], result[i]);
        }
    }
}
