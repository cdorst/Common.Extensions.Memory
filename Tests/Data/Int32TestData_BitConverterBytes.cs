using System;
using System.Collections;
using System.Collections.Generic;

namespace Tests.Data
{
    internal class Int32TestData_BitConverterBytes : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            foreach (var array in new Int32TestData())
            {
                var number = Convert.ToInt32(array[0]);
                yield return new object[]
                {
                    number,
                    BitConverter.GetBytes(number)
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
