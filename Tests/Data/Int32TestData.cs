using System;
using System.Collections;
using System.Collections.Generic;

namespace Tests.Data
{
    internal class Int32TestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            foreach (var item in new Int16TestData()) yield return item;
            yield return new object[] { 1_000_000 };
            yield return new object[] { Int16.MinValue - 1 };
            yield return new object[] { Int16.MaxValue + 1 };
            yield return new object[] { Int32.MinValue };
            yield return new object[] { Int32.MaxValue };
            yield return new object[] { Int32.MinValue + 1 };
            yield return new object[] { Int32.MaxValue - 1 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
