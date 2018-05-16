using System;
using System.Collections;
using System.Collections.Generic;

namespace Tests.Data
{
    internal class Int16TestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 0 };
            yield return new object[] { 1 };
            yield return new object[] { 5 };
            yield return new object[] { 5000 };
            yield return new object[] { 12345 };
            yield return new object[] { Int16.MinValue };
            yield return new object[] { Int16.MaxValue };
            yield return new object[] { Int16.MinValue + 1 };
            yield return new object[] { Int16.MaxValue - 1 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
