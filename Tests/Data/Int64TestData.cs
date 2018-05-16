using System;
using System.Collections;
using System.Collections.Generic;

namespace Tests.Data
{
    internal class Int64TestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            foreach (var item in new Int64TestData()) yield return item;
            yield return new object[] { 5_000_000_000 };
            yield return new object[] { 100_000_000_000_000 };
            yield return new object[] { Int32.MinValue - (long)1 };
            yield return new object[] { Int32.MaxValue + (long)1 };
            yield return new object[] { Int64.MinValue };
            yield return new object[] { Int64.MaxValue };
            yield return new object[] { Int64.MinValue + 1 };
            yield return new object[] { Int64.MaxValue - 1 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
