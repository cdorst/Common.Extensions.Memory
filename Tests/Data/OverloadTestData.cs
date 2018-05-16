using Common.Extensions.Memory;
using System;
using System.Collections;
using System.Collections.Generic;
using static Tests.Data.OverloadTestDataIterations;

namespace Tests.Data
{
    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1)
    /// </summary>
    public class OverloadTestData_1 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                yield return new object[]
                {
                    value0,
                    value1,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1)
    /// </summary>
    public class OverloadTestData_2 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1)
    /// </summary>
    public class OverloadTestData_3 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1)
    /// </summary>
    public class OverloadTestData_4 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1)
    /// </summary>
    public class OverloadTestData_5 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                yield return new object[]
                {
                    value0,
                    value1,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1)
    /// </summary>
    public class OverloadTestData_6 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1)
    /// </summary>
    public class OverloadTestData_7 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1)
    /// </summary>
    public class OverloadTestData_8 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1)
    /// </summary>
    public class OverloadTestData_9 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                yield return new object[]
                {
                    value0,
                    value1,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1)
    /// </summary>
    public class OverloadTestData_10 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1)
    /// </summary>
    public class OverloadTestData_11 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1)
    /// </summary>
    public class OverloadTestData_12 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1)
    /// </summary>
    public class OverloadTestData_13 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                yield return new object[]
                {
                    value0,
                    value1,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1)
    /// </summary>
    public class OverloadTestData_14 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1)
    /// </summary>
    public class OverloadTestData_15 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1)
    /// </summary>
    public class OverloadTestData_16 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1, byte value2)
    /// </summary>
    public class OverloadTestData_17 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value2;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1, Int16 value2)
    /// </summary>
    public class OverloadTestData_18 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[2] = value2bytes[0];
                control[3] = value2bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1, Int32 value2)
    /// </summary>
    public class OverloadTestData_19 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[2] = value2bytes[0];
                control[3] = value2bytes[1];
                control[4] = value2bytes[2];
                control[5] = value2bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1, Int64 value2)
    /// </summary>
    public class OverloadTestData_20 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[2] = value2bytes[0];
                control[3] = value2bytes[1];
                control[4] = value2bytes[2];
                control[5] = value2bytes[3];
                control[6] = value2bytes[4];
                control[7] = value2bytes[5];
                control[8] = value2bytes[6];
                control[9] = value2bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1, byte value2)
    /// </summary>
    public class OverloadTestData_21 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[3] = value2;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1, Int16 value2)
    /// </summary>
    public class OverloadTestData_22 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1, Int32 value2)
    /// </summary>
    public class OverloadTestData_23 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                control[5] = value2bytes[2];
                control[6] = value2bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1, Int64 value2)
    /// </summary>
    public class OverloadTestData_24 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                control[5] = value2bytes[2];
                control[6] = value2bytes[3];
                control[7] = value2bytes[4];
                control[8] = value2bytes[5];
                control[9] = value2bytes[6];
                control[10] = value2bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1, byte value2)
    /// </summary>
    public class OverloadTestData_25 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[5] = value2;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1, Int16 value2)
    /// </summary>
    public class OverloadTestData_26 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1, Int32 value2)
    /// </summary>
    public class OverloadTestData_27 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                control[7] = value2bytes[2];
                control[8] = value2bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1, Int64 value2)
    /// </summary>
    public class OverloadTestData_28 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                control[7] = value2bytes[2];
                control[8] = value2bytes[3];
                control[9] = value2bytes[4];
                control[10] = value2bytes[5];
                control[11] = value2bytes[6];
                control[12] = value2bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1, byte value2)
    /// </summary>
    public class OverloadTestData_29 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[9] = value2;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1, Int16 value2)
    /// </summary>
    public class OverloadTestData_30 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1, Int32 value2)
    /// </summary>
    public class OverloadTestData_31 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                control[11] = value2bytes[2];
                control[12] = value2bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1, Int64 value2)
    /// </summary>
    public class OverloadTestData_32 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                control[11] = value2bytes[2];
                control[12] = value2bytes[3];
                control[13] = value2bytes[4];
                control[14] = value2bytes[5];
                control[15] = value2bytes[6];
                control[16] = value2bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1, byte value2)
    /// </summary>
    public class OverloadTestData_33 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[3] = value2;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1, Int16 value2)
    /// </summary>
    public class OverloadTestData_34 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1, Int32 value2)
    /// </summary>
    public class OverloadTestData_35 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                control[5] = value2bytes[2];
                control[6] = value2bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1, Int64 value2)
    /// </summary>
    public class OverloadTestData_36 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                control[5] = value2bytes[2];
                control[6] = value2bytes[3];
                control[7] = value2bytes[4];
                control[8] = value2bytes[5];
                control[9] = value2bytes[6];
                control[10] = value2bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1, byte value2)
    /// </summary>
    public class OverloadTestData_37 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value2;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1, Int16 value2)
    /// </summary>
    public class OverloadTestData_38 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[4] = value2bytes[0];
                control[5] = value2bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1, Int32 value2)
    /// </summary>
    public class OverloadTestData_39 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[4] = value2bytes[0];
                control[5] = value2bytes[1];
                control[6] = value2bytes[2];
                control[7] = value2bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1, Int64 value2)
    /// </summary>
    public class OverloadTestData_40 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[4] = value2bytes[0];
                control[5] = value2bytes[1];
                control[6] = value2bytes[2];
                control[7] = value2bytes[3];
                control[8] = value2bytes[4];
                control[9] = value2bytes[5];
                control[10] = value2bytes[6];
                control[11] = value2bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1, byte value2)
    /// </summary>
    public class OverloadTestData_41 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[6] = value2;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1, Int16 value2)
    /// </summary>
    public class OverloadTestData_42 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1, Int32 value2)
    /// </summary>
    public class OverloadTestData_43 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                control[8] = value2bytes[2];
                control[9] = value2bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1, Int64 value2)
    /// </summary>
    public class OverloadTestData_44 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                control[8] = value2bytes[2];
                control[9] = value2bytes[3];
                control[10] = value2bytes[4];
                control[11] = value2bytes[5];
                control[12] = value2bytes[6];
                control[13] = value2bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1, byte value2)
    /// </summary>
    public class OverloadTestData_45 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[10] = value2;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1, Int16 value2)
    /// </summary>
    public class OverloadTestData_46 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1, Int32 value2)
    /// </summary>
    public class OverloadTestData_47 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                control[12] = value2bytes[2];
                control[13] = value2bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1, Int64 value2)
    /// </summary>
    public class OverloadTestData_48 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                control[12] = value2bytes[2];
                control[13] = value2bytes[3];
                control[14] = value2bytes[4];
                control[15] = value2bytes[5];
                control[16] = value2bytes[6];
                control[17] = value2bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1, byte value2)
    /// </summary>
    public class OverloadTestData_49 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[5] = value2;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1, Int16 value2)
    /// </summary>
    public class OverloadTestData_50 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1, Int32 value2)
    /// </summary>
    public class OverloadTestData_51 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                control[7] = value2bytes[2];
                control[8] = value2bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1, Int64 value2)
    /// </summary>
    public class OverloadTestData_52 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                control[7] = value2bytes[2];
                control[8] = value2bytes[3];
                control[9] = value2bytes[4];
                control[10] = value2bytes[5];
                control[11] = value2bytes[6];
                control[12] = value2bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1, byte value2)
    /// </summary>
    public class OverloadTestData_53 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[6] = value2;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1, Int16 value2)
    /// </summary>
    public class OverloadTestData_54 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1, Int32 value2)
    /// </summary>
    public class OverloadTestData_55 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                control[8] = value2bytes[2];
                control[9] = value2bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1, Int64 value2)
    /// </summary>
    public class OverloadTestData_56 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                control[8] = value2bytes[2];
                control[9] = value2bytes[3];
                control[10] = value2bytes[4];
                control[11] = value2bytes[5];
                control[12] = value2bytes[6];
                control[13] = value2bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1, byte value2)
    /// </summary>
    public class OverloadTestData_57 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value2;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1, Int16 value2)
    /// </summary>
    public class OverloadTestData_58 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[8] = value2bytes[0];
                control[9] = value2bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1, Int32 value2)
    /// </summary>
    public class OverloadTestData_59 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[8] = value2bytes[0];
                control[9] = value2bytes[1];
                control[10] = value2bytes[2];
                control[11] = value2bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1, Int64 value2)
    /// </summary>
    public class OverloadTestData_60 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[8] = value2bytes[0];
                control[9] = value2bytes[1];
                control[10] = value2bytes[2];
                control[11] = value2bytes[3];
                control[12] = value2bytes[4];
                control[13] = value2bytes[5];
                control[14] = value2bytes[6];
                control[15] = value2bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1, byte value2)
    /// </summary>
    public class OverloadTestData_61 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[12] = value2;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1, Int16 value2)
    /// </summary>
    public class OverloadTestData_62 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1, Int32 value2)
    /// </summary>
    public class OverloadTestData_63 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                control[14] = value2bytes[2];
                control[15] = value2bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1, Int64 value2)
    /// </summary>
    public class OverloadTestData_64 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                control[14] = value2bytes[2];
                control[15] = value2bytes[3];
                control[16] = value2bytes[4];
                control[17] = value2bytes[5];
                control[18] = value2bytes[6];
                control[19] = value2bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1, byte value2)
    /// </summary>
    public class OverloadTestData_65 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[9] = value2;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1, Int16 value2)
    /// </summary>
    public class OverloadTestData_66 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1, Int32 value2)
    /// </summary>
    public class OverloadTestData_67 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                control[11] = value2bytes[2];
                control[12] = value2bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1, Int64 value2)
    /// </summary>
    public class OverloadTestData_68 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                control[11] = value2bytes[2];
                control[12] = value2bytes[3];
                control[13] = value2bytes[4];
                control[14] = value2bytes[5];
                control[15] = value2bytes[6];
                control[16] = value2bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1, byte value2)
    /// </summary>
    public class OverloadTestData_69 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[10] = value2;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1, Int16 value2)
    /// </summary>
    public class OverloadTestData_70 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1, Int32 value2)
    /// </summary>
    public class OverloadTestData_71 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                control[12] = value2bytes[2];
                control[13] = value2bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1, Int64 value2)
    /// </summary>
    public class OverloadTestData_72 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                control[12] = value2bytes[2];
                control[13] = value2bytes[3];
                control[14] = value2bytes[4];
                control[15] = value2bytes[5];
                control[16] = value2bytes[6];
                control[17] = value2bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1, byte value2)
    /// </summary>
    public class OverloadTestData_73 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[12] = value2;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1, Int16 value2)
    /// </summary>
    public class OverloadTestData_74 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1, Int32 value2)
    /// </summary>
    public class OverloadTestData_75 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                control[14] = value2bytes[2];
                control[15] = value2bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1, Int64 value2)
    /// </summary>
    public class OverloadTestData_76 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                control[14] = value2bytes[2];
                control[15] = value2bytes[3];
                control[16] = value2bytes[4];
                control[17] = value2bytes[5];
                control[18] = value2bytes[6];
                control[19] = value2bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1, byte value2)
    /// </summary>
    public class OverloadTestData_77 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[16] = value2;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1, Int16 value2)
    /// </summary>
    public class OverloadTestData_78 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[16] = value2bytes[0];
                control[17] = value2bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1, Int32 value2)
    /// </summary>
    public class OverloadTestData_79 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[16] = value2bytes[0];
                control[17] = value2bytes[1];
                control[18] = value2bytes[2];
                control[19] = value2bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1, Int64 value2)
    /// </summary>
    public class OverloadTestData_80 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[16] = value2bytes[0];
                control[17] = value2bytes[1];
                control[18] = value2bytes[2];
                control[19] = value2bytes[3];
                control[20] = value2bytes[4];
                control[21] = value2bytes[5];
                control[22] = value2bytes[6];
                control[23] = value2bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1, byte value2, byte value3)
    /// </summary>
    public class OverloadTestData_81 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value2;
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[3] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1, byte value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_82 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value2;
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[3] = value3bytes[0];
                control[4] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1, byte value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_83 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value2;
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[3] = value3bytes[0];
                control[4] = value3bytes[1];
                control[5] = value3bytes[2];
                control[6] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1, byte value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_84 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte) + sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value2;
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[3] = value3bytes[0];
                control[4] = value3bytes[1];
                control[5] = value3bytes[2];
                control[6] = value3bytes[3];
                control[7] = value3bytes[4];
                control[8] = value3bytes[5];
                control[9] = value3bytes[6];
                control[10] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1, Int16 value2, byte value3)
    /// </summary>
    public class OverloadTestData_85 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte) + sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[2] = value2bytes[0];
                control[3] = value2bytes[1];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1, Int16 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_86 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte) + sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[2] = value2bytes[0];
                control[3] = value2bytes[1];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[4] = value3bytes[0];
                control[5] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1, Int16 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_87 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte) + sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[2] = value2bytes[0];
                control[3] = value2bytes[1];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[4] = value3bytes[0];
                control[5] = value3bytes[1];
                control[6] = value3bytes[2];
                control[7] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1, Int16 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_88 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte) + sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[2] = value2bytes[0];
                control[3] = value2bytes[1];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[4] = value3bytes[0];
                control[5] = value3bytes[1];
                control[6] = value3bytes[2];
                control[7] = value3bytes[3];
                control[8] = value3bytes[4];
                control[9] = value3bytes[5];
                control[10] = value3bytes[6];
                control[11] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1, Int32 value2, byte value3)
    /// </summary>
    public class OverloadTestData_89 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte) + sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[2] = value2bytes[0];
                control[3] = value2bytes[1];
                control[4] = value2bytes[2];
                control[5] = value2bytes[3];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[6] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1, Int32 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_90 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte) + sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[2] = value2bytes[0];
                control[3] = value2bytes[1];
                control[4] = value2bytes[2];
                control[5] = value2bytes[3];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[6] = value3bytes[0];
                control[7] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1, Int32 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_91 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte) + sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[2] = value2bytes[0];
                control[3] = value2bytes[1];
                control[4] = value2bytes[2];
                control[5] = value2bytes[3];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[6] = value3bytes[0];
                control[7] = value3bytes[1];
                control[8] = value3bytes[2];
                control[9] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1, Int32 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_92 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte) + sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[2] = value2bytes[0];
                control[3] = value2bytes[1];
                control[4] = value2bytes[2];
                control[5] = value2bytes[3];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[6] = value3bytes[0];
                control[7] = value3bytes[1];
                control[8] = value3bytes[2];
                control[9] = value3bytes[3];
                control[10] = value3bytes[4];
                control[11] = value3bytes[5];
                control[12] = value3bytes[6];
                control[13] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1, Int64 value2, byte value3)
    /// </summary>
    public class OverloadTestData_93 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte) + sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[2] = value2bytes[0];
                control[3] = value2bytes[1];
                control[4] = value2bytes[2];
                control[5] = value2bytes[3];
                control[6] = value2bytes[4];
                control[7] = value2bytes[5];
                control[8] = value2bytes[6];
                control[9] = value2bytes[7];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[10] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1, Int64 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_94 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte) + sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[2] = value2bytes[0];
                control[3] = value2bytes[1];
                control[4] = value2bytes[2];
                control[5] = value2bytes[3];
                control[6] = value2bytes[4];
                control[7] = value2bytes[5];
                control[8] = value2bytes[6];
                control[9] = value2bytes[7];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[10] = value3bytes[0];
                control[11] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1, Int64 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_95 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte) + sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[2] = value2bytes[0];
                control[3] = value2bytes[1];
                control[4] = value2bytes[2];
                control[5] = value2bytes[3];
                control[6] = value2bytes[4];
                control[7] = value2bytes[5];
                control[8] = value2bytes[6];
                control[9] = value2bytes[7];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[10] = value3bytes[0];
                control[11] = value3bytes[1];
                control[12] = value3bytes[2];
                control[13] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, byte value1, Int64 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_96 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(byte) + sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[1] = value1;
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[2] = value2bytes[0];
                control[3] = value2bytes[1];
                control[4] = value2bytes[2];
                control[5] = value2bytes[3];
                control[6] = value2bytes[4];
                control[7] = value2bytes[5];
                control[8] = value2bytes[6];
                control[9] = value2bytes[7];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[10] = value3bytes[0];
                control[11] = value3bytes[1];
                control[12] = value3bytes[2];
                control[13] = value3bytes[3];
                control[14] = value3bytes[4];
                control[15] = value3bytes[5];
                control[16] = value3bytes[6];
                control[17] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1, byte value2, byte value3)
    /// </summary>
    public class OverloadTestData_97 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16) + sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[3] = value2;
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1, byte value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_98 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16) + sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[3] = value2;
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[4] = value3bytes[0];
                control[5] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1, byte value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_99 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16) + sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[3] = value2;
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[4] = value3bytes[0];
                control[5] = value3bytes[1];
                control[6] = value3bytes[2];
                control[7] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1, byte value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_100 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16) + sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[3] = value2;
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[4] = value3bytes[0];
                control[5] = value3bytes[1];
                control[6] = value3bytes[2];
                control[7] = value3bytes[3];
                control[8] = value3bytes[4];
                control[9] = value3bytes[5];
                control[10] = value3bytes[6];
                control[11] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1, Int16 value2, byte value3)
    /// </summary>
    public class OverloadTestData_101 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16) + sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[5] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1, Int16 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_102 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16) + sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[5] = value3bytes[0];
                control[6] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1, Int16 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_103 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16) + sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[5] = value3bytes[0];
                control[6] = value3bytes[1];
                control[7] = value3bytes[2];
                control[8] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1, Int16 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_104 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16) + sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[5] = value3bytes[0];
                control[6] = value3bytes[1];
                control[7] = value3bytes[2];
                control[8] = value3bytes[3];
                control[9] = value3bytes[4];
                control[10] = value3bytes[5];
                control[11] = value3bytes[6];
                control[12] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1, Int32 value2, byte value3)
    /// </summary>
    public class OverloadTestData_105 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16) + sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                control[5] = value2bytes[2];
                control[6] = value2bytes[3];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[7] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1, Int32 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_106 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16) + sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                control[5] = value2bytes[2];
                control[6] = value2bytes[3];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[7] = value3bytes[0];
                control[8] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1, Int32 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_107 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16) + sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                control[5] = value2bytes[2];
                control[6] = value2bytes[3];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[7] = value3bytes[0];
                control[8] = value3bytes[1];
                control[9] = value3bytes[2];
                control[10] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1, Int32 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_108 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16) + sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                control[5] = value2bytes[2];
                control[6] = value2bytes[3];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[7] = value3bytes[0];
                control[8] = value3bytes[1];
                control[9] = value3bytes[2];
                control[10] = value3bytes[3];
                control[11] = value3bytes[4];
                control[12] = value3bytes[5];
                control[13] = value3bytes[6];
                control[14] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1, Int64 value2, byte value3)
    /// </summary>
    public class OverloadTestData_109 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16) + sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                control[5] = value2bytes[2];
                control[6] = value2bytes[3];
                control[7] = value2bytes[4];
                control[8] = value2bytes[5];
                control[9] = value2bytes[6];
                control[10] = value2bytes[7];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[11] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1, Int64 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_110 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16) + sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                control[5] = value2bytes[2];
                control[6] = value2bytes[3];
                control[7] = value2bytes[4];
                control[8] = value2bytes[5];
                control[9] = value2bytes[6];
                control[10] = value2bytes[7];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[11] = value3bytes[0];
                control[12] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1, Int64 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_111 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16) + sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                control[5] = value2bytes[2];
                control[6] = value2bytes[3];
                control[7] = value2bytes[4];
                control[8] = value2bytes[5];
                control[9] = value2bytes[6];
                control[10] = value2bytes[7];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[11] = value3bytes[0];
                control[12] = value3bytes[1];
                control[13] = value3bytes[2];
                control[14] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int16 value1, Int64 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_112 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int16) + sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                control[5] = value2bytes[2];
                control[6] = value2bytes[3];
                control[7] = value2bytes[4];
                control[8] = value2bytes[5];
                control[9] = value2bytes[6];
                control[10] = value2bytes[7];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[11] = value3bytes[0];
                control[12] = value3bytes[1];
                control[13] = value3bytes[2];
                control[14] = value3bytes[3];
                control[15] = value3bytes[4];
                control[16] = value3bytes[5];
                control[17] = value3bytes[6];
                control[18] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1, byte value2, byte value3)
    /// </summary>
    public class OverloadTestData_113 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32) + sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[5] = value2;
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[6] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1, byte value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_114 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32) + sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[5] = value2;
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[6] = value3bytes[0];
                control[7] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1, byte value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_115 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32) + sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[5] = value2;
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[6] = value3bytes[0];
                control[7] = value3bytes[1];
                control[8] = value3bytes[2];
                control[9] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1, byte value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_116 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32) + sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[5] = value2;
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[6] = value3bytes[0];
                control[7] = value3bytes[1];
                control[8] = value3bytes[2];
                control[9] = value3bytes[3];
                control[10] = value3bytes[4];
                control[11] = value3bytes[5];
                control[12] = value3bytes[6];
                control[13] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1, Int16 value2, byte value3)
    /// </summary>
    public class OverloadTestData_117 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32) + sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[7] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1, Int16 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_118 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32) + sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[7] = value3bytes[0];
                control[8] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1, Int16 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_119 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32) + sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[7] = value3bytes[0];
                control[8] = value3bytes[1];
                control[9] = value3bytes[2];
                control[10] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1, Int16 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_120 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32) + sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[7] = value3bytes[0];
                control[8] = value3bytes[1];
                control[9] = value3bytes[2];
                control[10] = value3bytes[3];
                control[11] = value3bytes[4];
                control[12] = value3bytes[5];
                control[13] = value3bytes[6];
                control[14] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1, Int32 value2, byte value3)
    /// </summary>
    public class OverloadTestData_121 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32) + sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                control[7] = value2bytes[2];
                control[8] = value2bytes[3];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[9] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1, Int32 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_122 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32) + sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                control[7] = value2bytes[2];
                control[8] = value2bytes[3];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[9] = value3bytes[0];
                control[10] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1, Int32 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_123 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32) + sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                control[7] = value2bytes[2];
                control[8] = value2bytes[3];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[9] = value3bytes[0];
                control[10] = value3bytes[1];
                control[11] = value3bytes[2];
                control[12] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1, Int32 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_124 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32) + sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                control[7] = value2bytes[2];
                control[8] = value2bytes[3];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[9] = value3bytes[0];
                control[10] = value3bytes[1];
                control[11] = value3bytes[2];
                control[12] = value3bytes[3];
                control[13] = value3bytes[4];
                control[14] = value3bytes[5];
                control[15] = value3bytes[6];
                control[16] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1, Int64 value2, byte value3)
    /// </summary>
    public class OverloadTestData_125 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32) + sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                control[7] = value2bytes[2];
                control[8] = value2bytes[3];
                control[9] = value2bytes[4];
                control[10] = value2bytes[5];
                control[11] = value2bytes[6];
                control[12] = value2bytes[7];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[13] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1, Int64 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_126 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32) + sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                control[7] = value2bytes[2];
                control[8] = value2bytes[3];
                control[9] = value2bytes[4];
                control[10] = value2bytes[5];
                control[11] = value2bytes[6];
                control[12] = value2bytes[7];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[13] = value3bytes[0];
                control[14] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1, Int64 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_127 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32) + sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                control[7] = value2bytes[2];
                control[8] = value2bytes[3];
                control[9] = value2bytes[4];
                control[10] = value2bytes[5];
                control[11] = value2bytes[6];
                control[12] = value2bytes[7];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[13] = value3bytes[0];
                control[14] = value3bytes[1];
                control[15] = value3bytes[2];
                control[16] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int32 value1, Int64 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_128 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int32) + sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                control[7] = value2bytes[2];
                control[8] = value2bytes[3];
                control[9] = value2bytes[4];
                control[10] = value2bytes[5];
                control[11] = value2bytes[6];
                control[12] = value2bytes[7];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[13] = value3bytes[0];
                control[14] = value3bytes[1];
                control[15] = value3bytes[2];
                control[16] = value3bytes[3];
                control[17] = value3bytes[4];
                control[18] = value3bytes[5];
                control[19] = value3bytes[6];
                control[20] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1, byte value2, byte value3)
    /// </summary>
    public class OverloadTestData_129 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64) + sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[9] = value2;
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[10] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1, byte value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_130 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64) + sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[9] = value2;
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[10] = value3bytes[0];
                control[11] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1, byte value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_131 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64) + sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[9] = value2;
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[10] = value3bytes[0];
                control[11] = value3bytes[1];
                control[12] = value3bytes[2];
                control[13] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1, byte value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_132 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64) + sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[9] = value2;
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[10] = value3bytes[0];
                control[11] = value3bytes[1];
                control[12] = value3bytes[2];
                control[13] = value3bytes[3];
                control[14] = value3bytes[4];
                control[15] = value3bytes[5];
                control[16] = value3bytes[6];
                control[17] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1, Int16 value2, byte value3)
    /// </summary>
    public class OverloadTestData_133 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64) + sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[11] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1, Int16 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_134 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64) + sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[11] = value3bytes[0];
                control[12] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1, Int16 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_135 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64) + sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[11] = value3bytes[0];
                control[12] = value3bytes[1];
                control[13] = value3bytes[2];
                control[14] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1, Int16 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_136 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64) + sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[11] = value3bytes[0];
                control[12] = value3bytes[1];
                control[13] = value3bytes[2];
                control[14] = value3bytes[3];
                control[15] = value3bytes[4];
                control[16] = value3bytes[5];
                control[17] = value3bytes[6];
                control[18] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1, Int32 value2, byte value3)
    /// </summary>
    public class OverloadTestData_137 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64) + sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                control[11] = value2bytes[2];
                control[12] = value2bytes[3];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[13] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1, Int32 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_138 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64) + sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                control[11] = value2bytes[2];
                control[12] = value2bytes[3];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[13] = value3bytes[0];
                control[14] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1, Int32 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_139 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64) + sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                control[11] = value2bytes[2];
                control[12] = value2bytes[3];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[13] = value3bytes[0];
                control[14] = value3bytes[1];
                control[15] = value3bytes[2];
                control[16] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1, Int32 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_140 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64) + sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                control[11] = value2bytes[2];
                control[12] = value2bytes[3];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[13] = value3bytes[0];
                control[14] = value3bytes[1];
                control[15] = value3bytes[2];
                control[16] = value3bytes[3];
                control[17] = value3bytes[4];
                control[18] = value3bytes[5];
                control[19] = value3bytes[6];
                control[20] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1, Int64 value2, byte value3)
    /// </summary>
    public class OverloadTestData_141 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64) + sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                control[11] = value2bytes[2];
                control[12] = value2bytes[3];
                control[13] = value2bytes[4];
                control[14] = value2bytes[5];
                control[15] = value2bytes[6];
                control[16] = value2bytes[7];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[17] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1, Int64 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_142 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64) + sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                control[11] = value2bytes[2];
                control[12] = value2bytes[3];
                control[13] = value2bytes[4];
                control[14] = value2bytes[5];
                control[15] = value2bytes[6];
                control[16] = value2bytes[7];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[17] = value3bytes[0];
                control[18] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1, Int64 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_143 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64) + sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                control[11] = value2bytes[2];
                control[12] = value2bytes[3];
                control[13] = value2bytes[4];
                control[14] = value2bytes[5];
                control[15] = value2bytes[6];
                control[16] = value2bytes[7];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[17] = value3bytes[0];
                control[18] = value3bytes[1];
                control[19] = value3bytes[2];
                control[20] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (byte value0, Int64 value1, Int64 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_144 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(byte) + sizeof(Int64) + sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[0] = value0;
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[1] = value1bytes[0];
                control[2] = value1bytes[1];
                control[3] = value1bytes[2];
                control[4] = value1bytes[3];
                control[5] = value1bytes[4];
                control[6] = value1bytes[5];
                control[7] = value1bytes[6];
                control[8] = value1bytes[7];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                control[11] = value2bytes[2];
                control[12] = value2bytes[3];
                control[13] = value2bytes[4];
                control[14] = value2bytes[5];
                control[15] = value2bytes[6];
                control[16] = value2bytes[7];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[17] = value3bytes[0];
                control[18] = value3bytes[1];
                control[19] = value3bytes[2];
                control[20] = value3bytes[3];
                control[21] = value3bytes[4];
                control[22] = value3bytes[5];
                control[23] = value3bytes[6];
                control[24] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1, byte value2, byte value3)
    /// </summary>
    public class OverloadTestData_145 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte) + sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[3] = value2;
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1, byte value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_146 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte) + sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[3] = value2;
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[4] = value3bytes[0];
                control[5] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1, byte value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_147 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte) + sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[3] = value2;
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[4] = value3bytes[0];
                control[5] = value3bytes[1];
                control[6] = value3bytes[2];
                control[7] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1, byte value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_148 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte) + sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[3] = value2;
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[4] = value3bytes[0];
                control[5] = value3bytes[1];
                control[6] = value3bytes[2];
                control[7] = value3bytes[3];
                control[8] = value3bytes[4];
                control[9] = value3bytes[5];
                control[10] = value3bytes[6];
                control[11] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1, Int16 value2, byte value3)
    /// </summary>
    public class OverloadTestData_149 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte) + sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[5] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1, Int16 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_150 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte) + sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[5] = value3bytes[0];
                control[6] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1, Int16 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_151 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte) + sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[5] = value3bytes[0];
                control[6] = value3bytes[1];
                control[7] = value3bytes[2];
                control[8] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1, Int16 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_152 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte) + sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[5] = value3bytes[0];
                control[6] = value3bytes[1];
                control[7] = value3bytes[2];
                control[8] = value3bytes[3];
                control[9] = value3bytes[4];
                control[10] = value3bytes[5];
                control[11] = value3bytes[6];
                control[12] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1, Int32 value2, byte value3)
    /// </summary>
    public class OverloadTestData_153 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte) + sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                control[5] = value2bytes[2];
                control[6] = value2bytes[3];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[7] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1, Int32 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_154 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte) + sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                control[5] = value2bytes[2];
                control[6] = value2bytes[3];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[7] = value3bytes[0];
                control[8] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1, Int32 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_155 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte) + sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                control[5] = value2bytes[2];
                control[6] = value2bytes[3];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[7] = value3bytes[0];
                control[8] = value3bytes[1];
                control[9] = value3bytes[2];
                control[10] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1, Int32 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_156 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte) + sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                control[5] = value2bytes[2];
                control[6] = value2bytes[3];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[7] = value3bytes[0];
                control[8] = value3bytes[1];
                control[9] = value3bytes[2];
                control[10] = value3bytes[3];
                control[11] = value3bytes[4];
                control[12] = value3bytes[5];
                control[13] = value3bytes[6];
                control[14] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1, Int64 value2, byte value3)
    /// </summary>
    public class OverloadTestData_157 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte) + sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                control[5] = value2bytes[2];
                control[6] = value2bytes[3];
                control[7] = value2bytes[4];
                control[8] = value2bytes[5];
                control[9] = value2bytes[6];
                control[10] = value2bytes[7];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[11] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1, Int64 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_158 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte) + sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                control[5] = value2bytes[2];
                control[6] = value2bytes[3];
                control[7] = value2bytes[4];
                control[8] = value2bytes[5];
                control[9] = value2bytes[6];
                control[10] = value2bytes[7];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[11] = value3bytes[0];
                control[12] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1, Int64 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_159 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte) + sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                control[5] = value2bytes[2];
                control[6] = value2bytes[3];
                control[7] = value2bytes[4];
                control[8] = value2bytes[5];
                control[9] = value2bytes[6];
                control[10] = value2bytes[7];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[11] = value3bytes[0];
                control[12] = value3bytes[1];
                control[13] = value3bytes[2];
                control[14] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, byte value1, Int64 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_160 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(byte) + sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[2] = value1;
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[3] = value2bytes[0];
                control[4] = value2bytes[1];
                control[5] = value2bytes[2];
                control[6] = value2bytes[3];
                control[7] = value2bytes[4];
                control[8] = value2bytes[5];
                control[9] = value2bytes[6];
                control[10] = value2bytes[7];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[11] = value3bytes[0];
                control[12] = value3bytes[1];
                control[13] = value3bytes[2];
                control[14] = value3bytes[3];
                control[15] = value3bytes[4];
                control[16] = value3bytes[5];
                control[17] = value3bytes[6];
                control[18] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1, byte value2, byte value3)
    /// </summary>
    public class OverloadTestData_161 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16) + sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value2;
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[5] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1, byte value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_162 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16) + sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value2;
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[5] = value3bytes[0];
                control[6] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1, byte value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_163 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16) + sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value2;
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[5] = value3bytes[0];
                control[6] = value3bytes[1];
                control[7] = value3bytes[2];
                control[8] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1, byte value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_164 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16) + sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value2;
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[5] = value3bytes[0];
                control[6] = value3bytes[1];
                control[7] = value3bytes[2];
                control[8] = value3bytes[3];
                control[9] = value3bytes[4];
                control[10] = value3bytes[5];
                control[11] = value3bytes[6];
                control[12] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1, Int16 value2, byte value3)
    /// </summary>
    public class OverloadTestData_165 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16) + sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[4] = value2bytes[0];
                control[5] = value2bytes[1];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[6] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1, Int16 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_166 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16) + sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[4] = value2bytes[0];
                control[5] = value2bytes[1];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[6] = value3bytes[0];
                control[7] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1, Int16 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_167 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16) + sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[4] = value2bytes[0];
                control[5] = value2bytes[1];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[6] = value3bytes[0];
                control[7] = value3bytes[1];
                control[8] = value3bytes[2];
                control[9] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1, Int16 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_168 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16) + sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[4] = value2bytes[0];
                control[5] = value2bytes[1];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[6] = value3bytes[0];
                control[7] = value3bytes[1];
                control[8] = value3bytes[2];
                control[9] = value3bytes[3];
                control[10] = value3bytes[4];
                control[11] = value3bytes[5];
                control[12] = value3bytes[6];
                control[13] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1, Int32 value2, byte value3)
    /// </summary>
    public class OverloadTestData_169 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16) + sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[4] = value2bytes[0];
                control[5] = value2bytes[1];
                control[6] = value2bytes[2];
                control[7] = value2bytes[3];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1, Int32 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_170 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16) + sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[4] = value2bytes[0];
                control[5] = value2bytes[1];
                control[6] = value2bytes[2];
                control[7] = value2bytes[3];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[8] = value3bytes[0];
                control[9] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1, Int32 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_171 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16) + sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[4] = value2bytes[0];
                control[5] = value2bytes[1];
                control[6] = value2bytes[2];
                control[7] = value2bytes[3];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[8] = value3bytes[0];
                control[9] = value3bytes[1];
                control[10] = value3bytes[2];
                control[11] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1, Int32 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_172 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16) + sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[4] = value2bytes[0];
                control[5] = value2bytes[1];
                control[6] = value2bytes[2];
                control[7] = value2bytes[3];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[8] = value3bytes[0];
                control[9] = value3bytes[1];
                control[10] = value3bytes[2];
                control[11] = value3bytes[3];
                control[12] = value3bytes[4];
                control[13] = value3bytes[5];
                control[14] = value3bytes[6];
                control[15] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1, Int64 value2, byte value3)
    /// </summary>
    public class OverloadTestData_173 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16) + sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[4] = value2bytes[0];
                control[5] = value2bytes[1];
                control[6] = value2bytes[2];
                control[7] = value2bytes[3];
                control[8] = value2bytes[4];
                control[9] = value2bytes[5];
                control[10] = value2bytes[6];
                control[11] = value2bytes[7];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[12] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1, Int64 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_174 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16) + sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[4] = value2bytes[0];
                control[5] = value2bytes[1];
                control[6] = value2bytes[2];
                control[7] = value2bytes[3];
                control[8] = value2bytes[4];
                control[9] = value2bytes[5];
                control[10] = value2bytes[6];
                control[11] = value2bytes[7];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[12] = value3bytes[0];
                control[13] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1, Int64 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_175 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16) + sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[4] = value2bytes[0];
                control[5] = value2bytes[1];
                control[6] = value2bytes[2];
                control[7] = value2bytes[3];
                control[8] = value2bytes[4];
                control[9] = value2bytes[5];
                control[10] = value2bytes[6];
                control[11] = value2bytes[7];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[12] = value3bytes[0];
                control[13] = value3bytes[1];
                control[14] = value3bytes[2];
                control[15] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int16 value1, Int64 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_176 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int16) + sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[4] = value2bytes[0];
                control[5] = value2bytes[1];
                control[6] = value2bytes[2];
                control[7] = value2bytes[3];
                control[8] = value2bytes[4];
                control[9] = value2bytes[5];
                control[10] = value2bytes[6];
                control[11] = value2bytes[7];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[12] = value3bytes[0];
                control[13] = value3bytes[1];
                control[14] = value3bytes[2];
                control[15] = value3bytes[3];
                control[16] = value3bytes[4];
                control[17] = value3bytes[5];
                control[18] = value3bytes[6];
                control[19] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1, byte value2, byte value3)
    /// </summary>
    public class OverloadTestData_177 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32) + sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[6] = value2;
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[7] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1, byte value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_178 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32) + sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[6] = value2;
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[7] = value3bytes[0];
                control[8] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1, byte value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_179 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32) + sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[6] = value2;
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[7] = value3bytes[0];
                control[8] = value3bytes[1];
                control[9] = value3bytes[2];
                control[10] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1, byte value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_180 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32) + sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[6] = value2;
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[7] = value3bytes[0];
                control[8] = value3bytes[1];
                control[9] = value3bytes[2];
                control[10] = value3bytes[3];
                control[11] = value3bytes[4];
                control[12] = value3bytes[5];
                control[13] = value3bytes[6];
                control[14] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1, Int16 value2, byte value3)
    /// </summary>
    public class OverloadTestData_181 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32) + sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1, Int16 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_182 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32) + sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[8] = value3bytes[0];
                control[9] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1, Int16 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_183 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32) + sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[8] = value3bytes[0];
                control[9] = value3bytes[1];
                control[10] = value3bytes[2];
                control[11] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1, Int16 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_184 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32) + sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[8] = value3bytes[0];
                control[9] = value3bytes[1];
                control[10] = value3bytes[2];
                control[11] = value3bytes[3];
                control[12] = value3bytes[4];
                control[13] = value3bytes[5];
                control[14] = value3bytes[6];
                control[15] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1, Int32 value2, byte value3)
    /// </summary>
    public class OverloadTestData_185 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32) + sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                control[8] = value2bytes[2];
                control[9] = value2bytes[3];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[10] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1, Int32 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_186 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32) + sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                control[8] = value2bytes[2];
                control[9] = value2bytes[3];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[10] = value3bytes[0];
                control[11] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1, Int32 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_187 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32) + sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                control[8] = value2bytes[2];
                control[9] = value2bytes[3];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[10] = value3bytes[0];
                control[11] = value3bytes[1];
                control[12] = value3bytes[2];
                control[13] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1, Int32 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_188 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32) + sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                control[8] = value2bytes[2];
                control[9] = value2bytes[3];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[10] = value3bytes[0];
                control[11] = value3bytes[1];
                control[12] = value3bytes[2];
                control[13] = value3bytes[3];
                control[14] = value3bytes[4];
                control[15] = value3bytes[5];
                control[16] = value3bytes[6];
                control[17] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1, Int64 value2, byte value3)
    /// </summary>
    public class OverloadTestData_189 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32) + sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                control[8] = value2bytes[2];
                control[9] = value2bytes[3];
                control[10] = value2bytes[4];
                control[11] = value2bytes[5];
                control[12] = value2bytes[6];
                control[13] = value2bytes[7];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[14] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1, Int64 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_190 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32) + sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                control[8] = value2bytes[2];
                control[9] = value2bytes[3];
                control[10] = value2bytes[4];
                control[11] = value2bytes[5];
                control[12] = value2bytes[6];
                control[13] = value2bytes[7];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[14] = value3bytes[0];
                control[15] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1, Int64 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_191 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32) + sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                control[8] = value2bytes[2];
                control[9] = value2bytes[3];
                control[10] = value2bytes[4];
                control[11] = value2bytes[5];
                control[12] = value2bytes[6];
                control[13] = value2bytes[7];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[14] = value3bytes[0];
                control[15] = value3bytes[1];
                control[16] = value3bytes[2];
                control[17] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int32 value1, Int64 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_192 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int32) + sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                control[8] = value2bytes[2];
                control[9] = value2bytes[3];
                control[10] = value2bytes[4];
                control[11] = value2bytes[5];
                control[12] = value2bytes[6];
                control[13] = value2bytes[7];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[14] = value3bytes[0];
                control[15] = value3bytes[1];
                control[16] = value3bytes[2];
                control[17] = value3bytes[3];
                control[18] = value3bytes[4];
                control[19] = value3bytes[5];
                control[20] = value3bytes[6];
                control[21] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1, byte value2, byte value3)
    /// </summary>
    public class OverloadTestData_193 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64) + sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[10] = value2;
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[11] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1, byte value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_194 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64) + sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[10] = value2;
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[11] = value3bytes[0];
                control[12] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1, byte value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_195 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64) + sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[10] = value2;
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[11] = value3bytes[0];
                control[12] = value3bytes[1];
                control[13] = value3bytes[2];
                control[14] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1, byte value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_196 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64) + sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[10] = value2;
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[11] = value3bytes[0];
                control[12] = value3bytes[1];
                control[13] = value3bytes[2];
                control[14] = value3bytes[3];
                control[15] = value3bytes[4];
                control[16] = value3bytes[5];
                control[17] = value3bytes[6];
                control[18] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1, Int16 value2, byte value3)
    /// </summary>
    public class OverloadTestData_197 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64) + sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[12] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1, Int16 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_198 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64) + sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[12] = value3bytes[0];
                control[13] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1, Int16 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_199 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64) + sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[12] = value3bytes[0];
                control[13] = value3bytes[1];
                control[14] = value3bytes[2];
                control[15] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1, Int16 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_200 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64) + sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[12] = value3bytes[0];
                control[13] = value3bytes[1];
                control[14] = value3bytes[2];
                control[15] = value3bytes[3];
                control[16] = value3bytes[4];
                control[17] = value3bytes[5];
                control[18] = value3bytes[6];
                control[19] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1, Int32 value2, byte value3)
    /// </summary>
    public class OverloadTestData_201 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64) + sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                control[12] = value2bytes[2];
                control[13] = value2bytes[3];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[14] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1, Int32 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_202 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64) + sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                control[12] = value2bytes[2];
                control[13] = value2bytes[3];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[14] = value3bytes[0];
                control[15] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1, Int32 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_203 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64) + sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                control[12] = value2bytes[2];
                control[13] = value2bytes[3];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[14] = value3bytes[0];
                control[15] = value3bytes[1];
                control[16] = value3bytes[2];
                control[17] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1, Int32 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_204 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64) + sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                control[12] = value2bytes[2];
                control[13] = value2bytes[3];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[14] = value3bytes[0];
                control[15] = value3bytes[1];
                control[16] = value3bytes[2];
                control[17] = value3bytes[3];
                control[18] = value3bytes[4];
                control[19] = value3bytes[5];
                control[20] = value3bytes[6];
                control[21] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1, Int64 value2, byte value3)
    /// </summary>
    public class OverloadTestData_205 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64) + sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                control[12] = value2bytes[2];
                control[13] = value2bytes[3];
                control[14] = value2bytes[4];
                control[15] = value2bytes[5];
                control[16] = value2bytes[6];
                control[17] = value2bytes[7];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[18] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1, Int64 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_206 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64) + sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                control[12] = value2bytes[2];
                control[13] = value2bytes[3];
                control[14] = value2bytes[4];
                control[15] = value2bytes[5];
                control[16] = value2bytes[6];
                control[17] = value2bytes[7];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[18] = value3bytes[0];
                control[19] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1, Int64 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_207 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64) + sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                control[12] = value2bytes[2];
                control[13] = value2bytes[3];
                control[14] = value2bytes[4];
                control[15] = value2bytes[5];
                control[16] = value2bytes[6];
                control[17] = value2bytes[7];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[18] = value3bytes[0];
                control[19] = value3bytes[1];
                control[20] = value3bytes[2];
                control[21] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int16 value0, Int64 value1, Int64 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_208 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int16) + sizeof(Int64) + sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[2] = value1bytes[0];
                control[3] = value1bytes[1];
                control[4] = value1bytes[2];
                control[5] = value1bytes[3];
                control[6] = value1bytes[4];
                control[7] = value1bytes[5];
                control[8] = value1bytes[6];
                control[9] = value1bytes[7];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                control[12] = value2bytes[2];
                control[13] = value2bytes[3];
                control[14] = value2bytes[4];
                control[15] = value2bytes[5];
                control[16] = value2bytes[6];
                control[17] = value2bytes[7];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[18] = value3bytes[0];
                control[19] = value3bytes[1];
                control[20] = value3bytes[2];
                control[21] = value3bytes[3];
                control[22] = value3bytes[4];
                control[23] = value3bytes[5];
                control[24] = value3bytes[6];
                control[25] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1, byte value2, byte value3)
    /// </summary>
    public class OverloadTestData_209 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte) + sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[5] = value2;
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[6] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1, byte value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_210 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte) + sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[5] = value2;
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[6] = value3bytes[0];
                control[7] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1, byte value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_211 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte) + sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[5] = value2;
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[6] = value3bytes[0];
                control[7] = value3bytes[1];
                control[8] = value3bytes[2];
                control[9] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1, byte value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_212 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte) + sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[5] = value2;
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[6] = value3bytes[0];
                control[7] = value3bytes[1];
                control[8] = value3bytes[2];
                control[9] = value3bytes[3];
                control[10] = value3bytes[4];
                control[11] = value3bytes[5];
                control[12] = value3bytes[6];
                control[13] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1, Int16 value2, byte value3)
    /// </summary>
    public class OverloadTestData_213 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte) + sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[7] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1, Int16 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_214 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte) + sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[7] = value3bytes[0];
                control[8] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1, Int16 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_215 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte) + sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[7] = value3bytes[0];
                control[8] = value3bytes[1];
                control[9] = value3bytes[2];
                control[10] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1, Int16 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_216 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte) + sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[7] = value3bytes[0];
                control[8] = value3bytes[1];
                control[9] = value3bytes[2];
                control[10] = value3bytes[3];
                control[11] = value3bytes[4];
                control[12] = value3bytes[5];
                control[13] = value3bytes[6];
                control[14] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1, Int32 value2, byte value3)
    /// </summary>
    public class OverloadTestData_217 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte) + sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                control[7] = value2bytes[2];
                control[8] = value2bytes[3];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[9] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1, Int32 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_218 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte) + sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                control[7] = value2bytes[2];
                control[8] = value2bytes[3];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[9] = value3bytes[0];
                control[10] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1, Int32 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_219 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte) + sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                control[7] = value2bytes[2];
                control[8] = value2bytes[3];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[9] = value3bytes[0];
                control[10] = value3bytes[1];
                control[11] = value3bytes[2];
                control[12] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1, Int32 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_220 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte) + sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                control[7] = value2bytes[2];
                control[8] = value2bytes[3];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[9] = value3bytes[0];
                control[10] = value3bytes[1];
                control[11] = value3bytes[2];
                control[12] = value3bytes[3];
                control[13] = value3bytes[4];
                control[14] = value3bytes[5];
                control[15] = value3bytes[6];
                control[16] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1, Int64 value2, byte value3)
    /// </summary>
    public class OverloadTestData_221 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte) + sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                control[7] = value2bytes[2];
                control[8] = value2bytes[3];
                control[9] = value2bytes[4];
                control[10] = value2bytes[5];
                control[11] = value2bytes[6];
                control[12] = value2bytes[7];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[13] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1, Int64 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_222 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte) + sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                control[7] = value2bytes[2];
                control[8] = value2bytes[3];
                control[9] = value2bytes[4];
                control[10] = value2bytes[5];
                control[11] = value2bytes[6];
                control[12] = value2bytes[7];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[13] = value3bytes[0];
                control[14] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1, Int64 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_223 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte) + sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                control[7] = value2bytes[2];
                control[8] = value2bytes[3];
                control[9] = value2bytes[4];
                control[10] = value2bytes[5];
                control[11] = value2bytes[6];
                control[12] = value2bytes[7];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[13] = value3bytes[0];
                control[14] = value3bytes[1];
                control[15] = value3bytes[2];
                control[16] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, byte value1, Int64 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_224 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(byte) + sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[4] = value1;
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[5] = value2bytes[0];
                control[6] = value2bytes[1];
                control[7] = value2bytes[2];
                control[8] = value2bytes[3];
                control[9] = value2bytes[4];
                control[10] = value2bytes[5];
                control[11] = value2bytes[6];
                control[12] = value2bytes[7];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[13] = value3bytes[0];
                control[14] = value3bytes[1];
                control[15] = value3bytes[2];
                control[16] = value3bytes[3];
                control[17] = value3bytes[4];
                control[18] = value3bytes[5];
                control[19] = value3bytes[6];
                control[20] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1, byte value2, byte value3)
    /// </summary>
    public class OverloadTestData_225 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16) + sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[6] = value2;
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[7] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1, byte value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_226 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16) + sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[6] = value2;
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[7] = value3bytes[0];
                control[8] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1, byte value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_227 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16) + sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[6] = value2;
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[7] = value3bytes[0];
                control[8] = value3bytes[1];
                control[9] = value3bytes[2];
                control[10] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1, byte value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_228 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16) + sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[6] = value2;
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[7] = value3bytes[0];
                control[8] = value3bytes[1];
                control[9] = value3bytes[2];
                control[10] = value3bytes[3];
                control[11] = value3bytes[4];
                control[12] = value3bytes[5];
                control[13] = value3bytes[6];
                control[14] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1, Int16 value2, byte value3)
    /// </summary>
    public class OverloadTestData_229 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16) + sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1, Int16 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_230 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16) + sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[8] = value3bytes[0];
                control[9] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1, Int16 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_231 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16) + sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[8] = value3bytes[0];
                control[9] = value3bytes[1];
                control[10] = value3bytes[2];
                control[11] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1, Int16 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_232 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16) + sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[8] = value3bytes[0];
                control[9] = value3bytes[1];
                control[10] = value3bytes[2];
                control[11] = value3bytes[3];
                control[12] = value3bytes[4];
                control[13] = value3bytes[5];
                control[14] = value3bytes[6];
                control[15] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1, Int32 value2, byte value3)
    /// </summary>
    public class OverloadTestData_233 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16) + sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                control[8] = value2bytes[2];
                control[9] = value2bytes[3];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[10] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1, Int32 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_234 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16) + sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                control[8] = value2bytes[2];
                control[9] = value2bytes[3];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[10] = value3bytes[0];
                control[11] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1, Int32 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_235 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16) + sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                control[8] = value2bytes[2];
                control[9] = value2bytes[3];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[10] = value3bytes[0];
                control[11] = value3bytes[1];
                control[12] = value3bytes[2];
                control[13] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1, Int32 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_236 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16) + sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                control[8] = value2bytes[2];
                control[9] = value2bytes[3];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[10] = value3bytes[0];
                control[11] = value3bytes[1];
                control[12] = value3bytes[2];
                control[13] = value3bytes[3];
                control[14] = value3bytes[4];
                control[15] = value3bytes[5];
                control[16] = value3bytes[6];
                control[17] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1, Int64 value2, byte value3)
    /// </summary>
    public class OverloadTestData_237 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16) + sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                control[8] = value2bytes[2];
                control[9] = value2bytes[3];
                control[10] = value2bytes[4];
                control[11] = value2bytes[5];
                control[12] = value2bytes[6];
                control[13] = value2bytes[7];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[14] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1, Int64 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_238 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16) + sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                control[8] = value2bytes[2];
                control[9] = value2bytes[3];
                control[10] = value2bytes[4];
                control[11] = value2bytes[5];
                control[12] = value2bytes[6];
                control[13] = value2bytes[7];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[14] = value3bytes[0];
                control[15] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1, Int64 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_239 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16) + sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                control[8] = value2bytes[2];
                control[9] = value2bytes[3];
                control[10] = value2bytes[4];
                control[11] = value2bytes[5];
                control[12] = value2bytes[6];
                control[13] = value2bytes[7];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[14] = value3bytes[0];
                control[15] = value3bytes[1];
                control[16] = value3bytes[2];
                control[17] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int16 value1, Int64 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_240 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int16) + sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[6] = value2bytes[0];
                control[7] = value2bytes[1];
                control[8] = value2bytes[2];
                control[9] = value2bytes[3];
                control[10] = value2bytes[4];
                control[11] = value2bytes[5];
                control[12] = value2bytes[6];
                control[13] = value2bytes[7];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[14] = value3bytes[0];
                control[15] = value3bytes[1];
                control[16] = value3bytes[2];
                control[17] = value3bytes[3];
                control[18] = value3bytes[4];
                control[19] = value3bytes[5];
                control[20] = value3bytes[6];
                control[21] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1, byte value2, byte value3)
    /// </summary>
    public class OverloadTestData_241 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32) + sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value2;
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[9] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1, byte value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_242 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32) + sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value2;
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[9] = value3bytes[0];
                control[10] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1, byte value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_243 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32) + sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value2;
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[9] = value3bytes[0];
                control[10] = value3bytes[1];
                control[11] = value3bytes[2];
                control[12] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1, byte value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_244 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32) + sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value2;
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[9] = value3bytes[0];
                control[10] = value3bytes[1];
                control[11] = value3bytes[2];
                control[12] = value3bytes[3];
                control[13] = value3bytes[4];
                control[14] = value3bytes[5];
                control[15] = value3bytes[6];
                control[16] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1, Int16 value2, byte value3)
    /// </summary>
    public class OverloadTestData_245 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32) + sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[8] = value2bytes[0];
                control[9] = value2bytes[1];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[10] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1, Int16 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_246 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32) + sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[8] = value2bytes[0];
                control[9] = value2bytes[1];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[10] = value3bytes[0];
                control[11] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1, Int16 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_247 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32) + sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[8] = value2bytes[0];
                control[9] = value2bytes[1];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[10] = value3bytes[0];
                control[11] = value3bytes[1];
                control[12] = value3bytes[2];
                control[13] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1, Int16 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_248 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32) + sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[8] = value2bytes[0];
                control[9] = value2bytes[1];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[10] = value3bytes[0];
                control[11] = value3bytes[1];
                control[12] = value3bytes[2];
                control[13] = value3bytes[3];
                control[14] = value3bytes[4];
                control[15] = value3bytes[5];
                control[16] = value3bytes[6];
                control[17] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1, Int32 value2, byte value3)
    /// </summary>
    public class OverloadTestData_249 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32) + sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[8] = value2bytes[0];
                control[9] = value2bytes[1];
                control[10] = value2bytes[2];
                control[11] = value2bytes[3];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[12] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1, Int32 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_250 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32) + sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[8] = value2bytes[0];
                control[9] = value2bytes[1];
                control[10] = value2bytes[2];
                control[11] = value2bytes[3];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[12] = value3bytes[0];
                control[13] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1, Int32 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_251 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32) + sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[8] = value2bytes[0];
                control[9] = value2bytes[1];
                control[10] = value2bytes[2];
                control[11] = value2bytes[3];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[12] = value3bytes[0];
                control[13] = value3bytes[1];
                control[14] = value3bytes[2];
                control[15] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1, Int32 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_252 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32) + sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[8] = value2bytes[0];
                control[9] = value2bytes[1];
                control[10] = value2bytes[2];
                control[11] = value2bytes[3];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[12] = value3bytes[0];
                control[13] = value3bytes[1];
                control[14] = value3bytes[2];
                control[15] = value3bytes[3];
                control[16] = value3bytes[4];
                control[17] = value3bytes[5];
                control[18] = value3bytes[6];
                control[19] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1, Int64 value2, byte value3)
    /// </summary>
    public class OverloadTestData_253 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32) + sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[8] = value2bytes[0];
                control[9] = value2bytes[1];
                control[10] = value2bytes[2];
                control[11] = value2bytes[3];
                control[12] = value2bytes[4];
                control[13] = value2bytes[5];
                control[14] = value2bytes[6];
                control[15] = value2bytes[7];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[16] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1, Int64 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_254 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32) + sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[8] = value2bytes[0];
                control[9] = value2bytes[1];
                control[10] = value2bytes[2];
                control[11] = value2bytes[3];
                control[12] = value2bytes[4];
                control[13] = value2bytes[5];
                control[14] = value2bytes[6];
                control[15] = value2bytes[7];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[16] = value3bytes[0];
                control[17] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1, Int64 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_255 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32) + sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[8] = value2bytes[0];
                control[9] = value2bytes[1];
                control[10] = value2bytes[2];
                control[11] = value2bytes[3];
                control[12] = value2bytes[4];
                control[13] = value2bytes[5];
                control[14] = value2bytes[6];
                control[15] = value2bytes[7];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[16] = value3bytes[0];
                control[17] = value3bytes[1];
                control[18] = value3bytes[2];
                control[19] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int32 value1, Int64 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_256 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int32) + sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[8] = value2bytes[0];
                control[9] = value2bytes[1];
                control[10] = value2bytes[2];
                control[11] = value2bytes[3];
                control[12] = value2bytes[4];
                control[13] = value2bytes[5];
                control[14] = value2bytes[6];
                control[15] = value2bytes[7];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[16] = value3bytes[0];
                control[17] = value3bytes[1];
                control[18] = value3bytes[2];
                control[19] = value3bytes[3];
                control[20] = value3bytes[4];
                control[21] = value3bytes[5];
                control[22] = value3bytes[6];
                control[23] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1, byte value2, byte value3)
    /// </summary>
    public class OverloadTestData_257 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64) + sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[12] = value2;
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[13] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1, byte value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_258 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64) + sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[12] = value2;
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[13] = value3bytes[0];
                control[14] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1, byte value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_259 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64) + sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[12] = value2;
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[13] = value3bytes[0];
                control[14] = value3bytes[1];
                control[15] = value3bytes[2];
                control[16] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1, byte value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_260 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64) + sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[12] = value2;
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[13] = value3bytes[0];
                control[14] = value3bytes[1];
                control[15] = value3bytes[2];
                control[16] = value3bytes[3];
                control[17] = value3bytes[4];
                control[18] = value3bytes[5];
                control[19] = value3bytes[6];
                control[20] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1, Int16 value2, byte value3)
    /// </summary>
    public class OverloadTestData_261 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64) + sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[14] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1, Int16 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_262 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64) + sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[14] = value3bytes[0];
                control[15] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1, Int16 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_263 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64) + sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[14] = value3bytes[0];
                control[15] = value3bytes[1];
                control[16] = value3bytes[2];
                control[17] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1, Int16 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_264 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64) + sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[14] = value3bytes[0];
                control[15] = value3bytes[1];
                control[16] = value3bytes[2];
                control[17] = value3bytes[3];
                control[18] = value3bytes[4];
                control[19] = value3bytes[5];
                control[20] = value3bytes[6];
                control[21] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1, Int32 value2, byte value3)
    /// </summary>
    public class OverloadTestData_265 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64) + sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                control[14] = value2bytes[2];
                control[15] = value2bytes[3];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[16] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1, Int32 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_266 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64) + sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                control[14] = value2bytes[2];
                control[15] = value2bytes[3];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[16] = value3bytes[0];
                control[17] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1, Int32 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_267 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64) + sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                control[14] = value2bytes[2];
                control[15] = value2bytes[3];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[16] = value3bytes[0];
                control[17] = value3bytes[1];
                control[18] = value3bytes[2];
                control[19] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1, Int32 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_268 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64) + sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                control[14] = value2bytes[2];
                control[15] = value2bytes[3];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[16] = value3bytes[0];
                control[17] = value3bytes[1];
                control[18] = value3bytes[2];
                control[19] = value3bytes[3];
                control[20] = value3bytes[4];
                control[21] = value3bytes[5];
                control[22] = value3bytes[6];
                control[23] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1, Int64 value2, byte value3)
    /// </summary>
    public class OverloadTestData_269 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64) + sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                control[14] = value2bytes[2];
                control[15] = value2bytes[3];
                control[16] = value2bytes[4];
                control[17] = value2bytes[5];
                control[18] = value2bytes[6];
                control[19] = value2bytes[7];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[20] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1, Int64 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_270 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64) + sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                control[14] = value2bytes[2];
                control[15] = value2bytes[3];
                control[16] = value2bytes[4];
                control[17] = value2bytes[5];
                control[18] = value2bytes[6];
                control[19] = value2bytes[7];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[20] = value3bytes[0];
                control[21] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1, Int64 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_271 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64) + sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                control[14] = value2bytes[2];
                control[15] = value2bytes[3];
                control[16] = value2bytes[4];
                control[17] = value2bytes[5];
                control[18] = value2bytes[6];
                control[19] = value2bytes[7];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[20] = value3bytes[0];
                control[21] = value3bytes[1];
                control[22] = value3bytes[2];
                control[23] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int32 value0, Int64 value1, Int64 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_272 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int32) + sizeof(Int64) + sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[4] = value1bytes[0];
                control[5] = value1bytes[1];
                control[6] = value1bytes[2];
                control[7] = value1bytes[3];
                control[8] = value1bytes[4];
                control[9] = value1bytes[5];
                control[10] = value1bytes[6];
                control[11] = value1bytes[7];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                control[14] = value2bytes[2];
                control[15] = value2bytes[3];
                control[16] = value2bytes[4];
                control[17] = value2bytes[5];
                control[18] = value2bytes[6];
                control[19] = value2bytes[7];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[20] = value3bytes[0];
                control[21] = value3bytes[1];
                control[22] = value3bytes[2];
                control[23] = value3bytes[3];
                control[24] = value3bytes[4];
                control[25] = value3bytes[5];
                control[26] = value3bytes[6];
                control[27] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1, byte value2, byte value3)
    /// </summary>
    public class OverloadTestData_273 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte) + sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[9] = value2;
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[10] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1, byte value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_274 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte) + sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[9] = value2;
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[10] = value3bytes[0];
                control[11] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1, byte value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_275 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte) + sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[9] = value2;
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[10] = value3bytes[0];
                control[11] = value3bytes[1];
                control[12] = value3bytes[2];
                control[13] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1, byte value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_276 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte) + sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[9] = value2;
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[10] = value3bytes[0];
                control[11] = value3bytes[1];
                control[12] = value3bytes[2];
                control[13] = value3bytes[3];
                control[14] = value3bytes[4];
                control[15] = value3bytes[5];
                control[16] = value3bytes[6];
                control[17] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1, Int16 value2, byte value3)
    /// </summary>
    public class OverloadTestData_277 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte) + sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[11] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1, Int16 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_278 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte) + sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[11] = value3bytes[0];
                control[12] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1, Int16 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_279 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte) + sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[11] = value3bytes[0];
                control[12] = value3bytes[1];
                control[13] = value3bytes[2];
                control[14] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1, Int16 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_280 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte) + sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[11] = value3bytes[0];
                control[12] = value3bytes[1];
                control[13] = value3bytes[2];
                control[14] = value3bytes[3];
                control[15] = value3bytes[4];
                control[16] = value3bytes[5];
                control[17] = value3bytes[6];
                control[18] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1, Int32 value2, byte value3)
    /// </summary>
    public class OverloadTestData_281 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte) + sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                control[11] = value2bytes[2];
                control[12] = value2bytes[3];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[13] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1, Int32 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_282 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte) + sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                control[11] = value2bytes[2];
                control[12] = value2bytes[3];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[13] = value3bytes[0];
                control[14] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1, Int32 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_283 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte) + sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                control[11] = value2bytes[2];
                control[12] = value2bytes[3];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[13] = value3bytes[0];
                control[14] = value3bytes[1];
                control[15] = value3bytes[2];
                control[16] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1, Int32 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_284 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte) + sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                control[11] = value2bytes[2];
                control[12] = value2bytes[3];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[13] = value3bytes[0];
                control[14] = value3bytes[1];
                control[15] = value3bytes[2];
                control[16] = value3bytes[3];
                control[17] = value3bytes[4];
                control[18] = value3bytes[5];
                control[19] = value3bytes[6];
                control[20] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1, Int64 value2, byte value3)
    /// </summary>
    public class OverloadTestData_285 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte) + sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                control[11] = value2bytes[2];
                control[12] = value2bytes[3];
                control[13] = value2bytes[4];
                control[14] = value2bytes[5];
                control[15] = value2bytes[6];
                control[16] = value2bytes[7];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[17] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1, Int64 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_286 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte) + sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                control[11] = value2bytes[2];
                control[12] = value2bytes[3];
                control[13] = value2bytes[4];
                control[14] = value2bytes[5];
                control[15] = value2bytes[6];
                control[16] = value2bytes[7];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[17] = value3bytes[0];
                control[18] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1, Int64 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_287 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte) + sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                control[11] = value2bytes[2];
                control[12] = value2bytes[3];
                control[13] = value2bytes[4];
                control[14] = value2bytes[5];
                control[15] = value2bytes[6];
                control[16] = value2bytes[7];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[17] = value3bytes[0];
                control[18] = value3bytes[1];
                control[19] = value3bytes[2];
                control[20] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, byte value1, Int64 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_288 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(byte) + sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[8] = value1;
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[9] = value2bytes[0];
                control[10] = value2bytes[1];
                control[11] = value2bytes[2];
                control[12] = value2bytes[3];
                control[13] = value2bytes[4];
                control[14] = value2bytes[5];
                control[15] = value2bytes[6];
                control[16] = value2bytes[7];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[17] = value3bytes[0];
                control[18] = value3bytes[1];
                control[19] = value3bytes[2];
                control[20] = value3bytes[3];
                control[21] = value3bytes[4];
                control[22] = value3bytes[5];
                control[23] = value3bytes[6];
                control[24] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1, byte value2, byte value3)
    /// </summary>
    public class OverloadTestData_289 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16) + sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[10] = value2;
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[11] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1, byte value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_290 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16) + sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[10] = value2;
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[11] = value3bytes[0];
                control[12] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1, byte value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_291 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16) + sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[10] = value2;
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[11] = value3bytes[0];
                control[12] = value3bytes[1];
                control[13] = value3bytes[2];
                control[14] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1, byte value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_292 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16) + sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[10] = value2;
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[11] = value3bytes[0];
                control[12] = value3bytes[1];
                control[13] = value3bytes[2];
                control[14] = value3bytes[3];
                control[15] = value3bytes[4];
                control[16] = value3bytes[5];
                control[17] = value3bytes[6];
                control[18] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1, Int16 value2, byte value3)
    /// </summary>
    public class OverloadTestData_293 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16) + sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[12] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1, Int16 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_294 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16) + sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[12] = value3bytes[0];
                control[13] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1, Int16 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_295 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16) + sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[12] = value3bytes[0];
                control[13] = value3bytes[1];
                control[14] = value3bytes[2];
                control[15] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1, Int16 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_296 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16) + sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[12] = value3bytes[0];
                control[13] = value3bytes[1];
                control[14] = value3bytes[2];
                control[15] = value3bytes[3];
                control[16] = value3bytes[4];
                control[17] = value3bytes[5];
                control[18] = value3bytes[6];
                control[19] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1, Int32 value2, byte value3)
    /// </summary>
    public class OverloadTestData_297 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16) + sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                control[12] = value2bytes[2];
                control[13] = value2bytes[3];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[14] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1, Int32 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_298 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16) + sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                control[12] = value2bytes[2];
                control[13] = value2bytes[3];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[14] = value3bytes[0];
                control[15] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1, Int32 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_299 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16) + sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                control[12] = value2bytes[2];
                control[13] = value2bytes[3];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[14] = value3bytes[0];
                control[15] = value3bytes[1];
                control[16] = value3bytes[2];
                control[17] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1, Int32 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_300 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16) + sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                control[12] = value2bytes[2];
                control[13] = value2bytes[3];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[14] = value3bytes[0];
                control[15] = value3bytes[1];
                control[16] = value3bytes[2];
                control[17] = value3bytes[3];
                control[18] = value3bytes[4];
                control[19] = value3bytes[5];
                control[20] = value3bytes[6];
                control[21] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1, Int64 value2, byte value3)
    /// </summary>
    public class OverloadTestData_301 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16) + sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                control[12] = value2bytes[2];
                control[13] = value2bytes[3];
                control[14] = value2bytes[4];
                control[15] = value2bytes[5];
                control[16] = value2bytes[6];
                control[17] = value2bytes[7];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[18] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1, Int64 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_302 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16) + sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                control[12] = value2bytes[2];
                control[13] = value2bytes[3];
                control[14] = value2bytes[4];
                control[15] = value2bytes[5];
                control[16] = value2bytes[6];
                control[17] = value2bytes[7];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[18] = value3bytes[0];
                control[19] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1, Int64 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_303 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16) + sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                control[12] = value2bytes[2];
                control[13] = value2bytes[3];
                control[14] = value2bytes[4];
                control[15] = value2bytes[5];
                control[16] = value2bytes[6];
                control[17] = value2bytes[7];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[18] = value3bytes[0];
                control[19] = value3bytes[1];
                control[20] = value3bytes[2];
                control[21] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int16 value1, Int64 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_304 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int16) + sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[10] = value2bytes[0];
                control[11] = value2bytes[1];
                control[12] = value2bytes[2];
                control[13] = value2bytes[3];
                control[14] = value2bytes[4];
                control[15] = value2bytes[5];
                control[16] = value2bytes[6];
                control[17] = value2bytes[7];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[18] = value3bytes[0];
                control[19] = value3bytes[1];
                control[20] = value3bytes[2];
                control[21] = value3bytes[3];
                control[22] = value3bytes[4];
                control[23] = value3bytes[5];
                control[24] = value3bytes[6];
                control[25] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1, byte value2, byte value3)
    /// </summary>
    public class OverloadTestData_305 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32) + sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[12] = value2;
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[13] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1, byte value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_306 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32) + sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[12] = value2;
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[13] = value3bytes[0];
                control[14] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1, byte value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_307 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32) + sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[12] = value2;
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[13] = value3bytes[0];
                control[14] = value3bytes[1];
                control[15] = value3bytes[2];
                control[16] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1, byte value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_308 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32) + sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[12] = value2;
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[13] = value3bytes[0];
                control[14] = value3bytes[1];
                control[15] = value3bytes[2];
                control[16] = value3bytes[3];
                control[17] = value3bytes[4];
                control[18] = value3bytes[5];
                control[19] = value3bytes[6];
                control[20] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1, Int16 value2, byte value3)
    /// </summary>
    public class OverloadTestData_309 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32) + sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[14] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1, Int16 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_310 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32) + sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[14] = value3bytes[0];
                control[15] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1, Int16 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_311 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32) + sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[14] = value3bytes[0];
                control[15] = value3bytes[1];
                control[16] = value3bytes[2];
                control[17] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1, Int16 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_312 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32) + sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[14] = value3bytes[0];
                control[15] = value3bytes[1];
                control[16] = value3bytes[2];
                control[17] = value3bytes[3];
                control[18] = value3bytes[4];
                control[19] = value3bytes[5];
                control[20] = value3bytes[6];
                control[21] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1, Int32 value2, byte value3)
    /// </summary>
    public class OverloadTestData_313 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32) + sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                control[14] = value2bytes[2];
                control[15] = value2bytes[3];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[16] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1, Int32 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_314 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32) + sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                control[14] = value2bytes[2];
                control[15] = value2bytes[3];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[16] = value3bytes[0];
                control[17] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1, Int32 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_315 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32) + sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                control[14] = value2bytes[2];
                control[15] = value2bytes[3];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[16] = value3bytes[0];
                control[17] = value3bytes[1];
                control[18] = value3bytes[2];
                control[19] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1, Int32 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_316 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32) + sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                control[14] = value2bytes[2];
                control[15] = value2bytes[3];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[16] = value3bytes[0];
                control[17] = value3bytes[1];
                control[18] = value3bytes[2];
                control[19] = value3bytes[3];
                control[20] = value3bytes[4];
                control[21] = value3bytes[5];
                control[22] = value3bytes[6];
                control[23] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1, Int64 value2, byte value3)
    /// </summary>
    public class OverloadTestData_317 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32) + sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                control[14] = value2bytes[2];
                control[15] = value2bytes[3];
                control[16] = value2bytes[4];
                control[17] = value2bytes[5];
                control[18] = value2bytes[6];
                control[19] = value2bytes[7];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[20] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1, Int64 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_318 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32) + sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                control[14] = value2bytes[2];
                control[15] = value2bytes[3];
                control[16] = value2bytes[4];
                control[17] = value2bytes[5];
                control[18] = value2bytes[6];
                control[19] = value2bytes[7];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[20] = value3bytes[0];
                control[21] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1, Int64 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_319 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32) + sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                control[14] = value2bytes[2];
                control[15] = value2bytes[3];
                control[16] = value2bytes[4];
                control[17] = value2bytes[5];
                control[18] = value2bytes[6];
                control[19] = value2bytes[7];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[20] = value3bytes[0];
                control[21] = value3bytes[1];
                control[22] = value3bytes[2];
                control[23] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int32 value1, Int64 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_320 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int32) + sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[12] = value2bytes[0];
                control[13] = value2bytes[1];
                control[14] = value2bytes[2];
                control[15] = value2bytes[3];
                control[16] = value2bytes[4];
                control[17] = value2bytes[5];
                control[18] = value2bytes[6];
                control[19] = value2bytes[7];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[20] = value3bytes[0];
                control[21] = value3bytes[1];
                control[22] = value3bytes[2];
                control[23] = value3bytes[3];
                control[24] = value3bytes[4];
                control[25] = value3bytes[5];
                control[26] = value3bytes[6];
                control[27] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1, byte value2, byte value3)
    /// </summary>
    public class OverloadTestData_321 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64) + sizeof(byte) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[16] = value2;
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[17] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1, byte value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_322 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64) + sizeof(byte) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[16] = value2;
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[17] = value3bytes[0];
                control[18] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1, byte value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_323 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64) + sizeof(byte) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[16] = value2;
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[17] = value3bytes[0];
                control[18] = value3bytes[1];
                control[19] = value3bytes[2];
                control[20] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1, byte value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_324 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64) + sizeof(byte) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                var value2 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[16] = value2;
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[17] = value3bytes[0];
                control[18] = value3bytes[1];
                control[19] = value3bytes[2];
                control[20] = value3bytes[3];
                control[21] = value3bytes[4];
                control[22] = value3bytes[5];
                control[23] = value3bytes[6];
                control[24] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1, Int16 value2, byte value3)
    /// </summary>
    public class OverloadTestData_325 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64) + sizeof(Int16) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[16] = value2bytes[0];
                control[17] = value2bytes[1];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[18] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1, Int16 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_326 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64) + sizeof(Int16) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[16] = value2bytes[0];
                control[17] = value2bytes[1];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[18] = value3bytes[0];
                control[19] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1, Int16 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_327 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64) + sizeof(Int16) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[16] = value2bytes[0];
                control[17] = value2bytes[1];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[18] = value3bytes[0];
                control[19] = value3bytes[1];
                control[20] = value3bytes[2];
                control[21] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1, Int16 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_328 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64) + sizeof(Int16) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                var value2 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value2bytes = value2.ToSpan();
                control[16] = value2bytes[0];
                control[17] = value2bytes[1];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[18] = value3bytes[0];
                control[19] = value3bytes[1];
                control[20] = value3bytes[2];
                control[21] = value3bytes[3];
                control[22] = value3bytes[4];
                control[23] = value3bytes[5];
                control[24] = value3bytes[6];
                control[25] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1, Int32 value2, byte value3)
    /// </summary>
    public class OverloadTestData_329 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64) + sizeof(Int32) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[16] = value2bytes[0];
                control[17] = value2bytes[1];
                control[18] = value2bytes[2];
                control[19] = value2bytes[3];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[20] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1, Int32 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_330 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64) + sizeof(Int32) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[16] = value2bytes[0];
                control[17] = value2bytes[1];
                control[18] = value2bytes[2];
                control[19] = value2bytes[3];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[20] = value3bytes[0];
                control[21] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1, Int32 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_331 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64) + sizeof(Int32) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[16] = value2bytes[0];
                control[17] = value2bytes[1];
                control[18] = value2bytes[2];
                control[19] = value2bytes[3];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[20] = value3bytes[0];
                control[21] = value3bytes[1];
                control[22] = value3bytes[2];
                control[23] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1, Int32 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_332 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64) + sizeof(Int32) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                var value2 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[16] = value2bytes[0];
                control[17] = value2bytes[1];
                control[18] = value2bytes[2];
                control[19] = value2bytes[3];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[20] = value3bytes[0];
                control[21] = value3bytes[1];
                control[22] = value3bytes[2];
                control[23] = value3bytes[3];
                control[24] = value3bytes[4];
                control[25] = value3bytes[5];
                control[26] = value3bytes[6];
                control[27] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1, Int64 value2, byte value3)
    /// </summary>
    public class OverloadTestData_333 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64) + sizeof(Int64) + sizeof(byte);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[16] = value2bytes[0];
                control[17] = value2bytes[1];
                control[18] = value2bytes[2];
                control[19] = value2bytes[3];
                control[20] = value2bytes[4];
                control[21] = value2bytes[5];
                control[22] = value2bytes[6];
                control[23] = value2bytes[7];
                var value3 = (byte)random.Next(byte.MinValue, byte.MaxValue);
                control[24] = value3;
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1, Int64 value2, Int16 value3)
    /// </summary>
    public class OverloadTestData_334 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64) + sizeof(Int64) + sizeof(Int16);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[16] = value2bytes[0];
                control[17] = value2bytes[1];
                control[18] = value2bytes[2];
                control[19] = value2bytes[3];
                control[20] = value2bytes[4];
                control[21] = value2bytes[5];
                control[22] = value2bytes[6];
                control[23] = value2bytes[7];
                var value3 = (Int16)random.Next(Int16.MinValue, Int16.MaxValue);
                var value3bytes = value3.ToSpan();
                control[24] = value3bytes[0];
                control[25] = value3bytes[1];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1, Int64 value2, Int32 value3)
    /// </summary>
    public class OverloadTestData_335 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64) + sizeof(Int64) + sizeof(Int32);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[16] = value2bytes[0];
                control[17] = value2bytes[1];
                control[18] = value2bytes[2];
                control[19] = value2bytes[3];
                control[20] = value2bytes[4];
                control[21] = value2bytes[5];
                control[22] = value2bytes[6];
                control[23] = value2bytes[7];
                var value3 = random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[24] = value3bytes[0];
                control[25] = value3bytes[1];
                control[26] = value3bytes[2];
                control[27] = value3bytes[3];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// Contains test cases for methods with these arguments:
    /// (Int64 value0, Int64 value1, Int64 value2, Int64 value3)
    /// </summary>
    public class OverloadTestData_336 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            var size = sizeof(Int64) + sizeof(Int64) + sizeof(Int64) + sizeof(Int64);
            var random = new Random();
            for (byte i = 0; i < NumberOfTestCases; i++)
            {
                Span<byte> control = stackalloc byte[size];
                var value0 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value0bytes = value0.ToSpan();
                control[0] = value0bytes[0];
                control[1] = value0bytes[1];
                control[2] = value0bytes[2];
                control[3] = value0bytes[3];
                control[4] = value0bytes[4];
                control[5] = value0bytes[5];
                control[6] = value0bytes[6];
                control[7] = value0bytes[7];
                var value1 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value1bytes = value1.ToSpan();
                control[8] = value1bytes[0];
                control[9] = value1bytes[1];
                control[10] = value1bytes[2];
                control[11] = value1bytes[3];
                control[12] = value1bytes[4];
                control[13] = value1bytes[5];
                control[14] = value1bytes[6];
                control[15] = value1bytes[7];
                var value2 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value2bytes = value2.ToSpan();
                control[16] = value2bytes[0];
                control[17] = value2bytes[1];
                control[18] = value2bytes[2];
                control[19] = value2bytes[3];
                control[20] = value2bytes[4];
                control[21] = value2bytes[5];
                control[22] = value2bytes[6];
                control[23] = value2bytes[7];
                var value3 = (Int64)random.Next(Int32.MinValue, Int32.MaxValue);
                var value3bytes = value3.ToSpan();
                control[24] = value3bytes[0];
                control[25] = value3bytes[1];
                control[26] = value3bytes[2];
                control[27] = value3bytes[3];
                control[28] = value3bytes[4];
                control[29] = value3bytes[5];
                control[30] = value3bytes[6];
                control[31] = value3bytes[7];
                yield return new object[]
                {
                    value0,
                    value1,
                    value2,
                    control.ToArray()
                };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
