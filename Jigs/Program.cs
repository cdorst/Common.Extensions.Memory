using System.IO;
using System.Linq;
using System.Text;

namespace Jigs
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeSpanByteMapMapperCode();
            MakeSpanMapperCode();
            MakeTestData();
            MakeIntegerReadOnlySpanMapper_MapSpan_Tests();
            MakeIntegerReadOnlySpanByteMapMapper_GetSpan_Tests();
        }

        private static void MakeSpanByteMapMapperCode()
        {
            var sb = new StringBuilder();
            foreach (var item in IntegerTypeCombinations.GetDoubles())
            {
                var (item0, item1) = item;
                sb.AppendLine("public static ReadOnlySpan<byte> GetSpan(")
                    .AppendLine($"\tin {GetIntMapType(item0)} item0,")
                    .AppendLine($"\tin {GetIntMapType(item1)} item1)")
                    .AppendLine("\t=> new[]")
                    .AppendLine("\t{");
                AppendBytes(sb, item0, 0);
                AppendBytes(sb, item1, 1, false);
                sb.AppendLine("\t};")
                    .AppendLine();
            }
            foreach (var item in IntegerTypeCombinations.GetTriples())
            {
                var (item0, item1, item2) = item;
                sb.AppendLine("public static ReadOnlySpan<byte> GetSpan(")
                    .AppendLine($"\tin {GetIntMapType(item0)} item0,")
                    .AppendLine($"\tin {GetIntMapType(item1)} item1,")
                    .AppendLine($"\tin {GetIntMapType(item2)} item2)")
                    .AppendLine("\t=> new[]")
                    .AppendLine("\t{");
                AppendBytes(sb, item0, 0);
                AppendBytes(sb, item1, 1);
                AppendBytes(sb, item2, 2, false);
                sb.AppendLine("\t};")
                    .AppendLine();
            }
            foreach (var item in IntegerTypeCombinations.GetQuadruples())
            {
                var (item0, item1, item2, item3) = item;
                sb.AppendLine("public static ReadOnlySpan<byte> GetSpan(")
                    .AppendLine($"\tin {GetIntMapType(item0)} item0,")
                    .AppendLine($"\tin {GetIntMapType(item1)} item1,")
                    .AppendLine($"\tin {GetIntMapType(item2)} item2,")
                    .AppendLine($"\tin {GetIntMapType(item3)} item3)")
                    .AppendLine("\t=> new[]")
                    .AppendLine("\t{");
                AppendBytes(sb, item0, 0);
                AppendBytes(sb, item1, 1);
                AppendBytes(sb, item2, 2);
                AppendBytes(sb, item3, 3, false);
                sb.AppendLine("\t};")
                    .AppendLine();
            }
            File.WriteAllText("IntegerReadOnlySpanByteMapMapper.cs.txt", sb.ToString().Replace("\r\n,", ",\r\n"));

            void AppendBytes(in StringBuilder builder, in IntegerTypes type, in byte position, in bool appendComma = true, in byte tabCount = 4)
            {
                var tabs = new string('\t', tabCount);
                var prefix = string.Concat(tabs, "item", position);
                if (type == IntegerTypes.Byte)
                {
                    sb.AppendLine(prefix);
                    if (appendComma) sb.Append(",");
                }
                else
                {
                    AppendByteLine(sb, prefix, 0);
                    AppendByteLine(sb, prefix, 1, appendComma);
                    if (type != IntegerTypes.Short)
                    {
                        if (!appendComma) sb.Append(",");
                        AppendByteLine(sb, prefix, 2);
                        AppendByteLine(sb, prefix, 3, appendComma);
                        if (type == IntegerTypes.Long)
                        {
                            if (!appendComma) sb.Append(",");
                            AppendByteLine(sb, prefix, 4);
                            AppendByteLine(sb, prefix, 5);
                            AppendByteLine(sb, prefix, 6);
                            AppendByteLine(sb, prefix, 7, appendComma);
                        }
                    }
                }
            }
            void AppendByteLine(in StringBuilder builder, in string prefix, in byte position, in bool appendComma = true)
                => sb.AppendLine(string.Concat(prefix, Byte(position), appendComma ? "," : string.Empty));
            string Byte(in byte position) => string.Concat(".Byte", position);
            string GetIntMapType(in IntegerTypes type)
                => type == IntegerTypes.Short ? "Int16ByteMap"
                : type == IntegerTypes.Int ? "Int32ByteMap"
                : type == IntegerTypes.Long ? "Int64ByteMap" : "byte";
        }

        private static void MakeSpanMapperCode()
        {
            var sb = new StringBuilder();
            foreach (var item in IntegerTypeCombinations.GetDoubles())
            {
                var (item0, item1) = item;
                sb.AppendLine("public static ReadOnlySpan<byte> MapSpan(")
                    .AppendLine($"\tin {GetIntType(item0)} item0,")
                    .AppendLine($"\tin {GetIntType(item1)} item1)")
                    .AppendLine($"\t=> GetSpan({GetMapArg(item0, 0)}, {GetMapArg(item1, 1)});")
                    .AppendLine();
            }
            foreach (var item in IntegerTypeCombinations.GetTriples())
            {
                var (item0, item1, item2) = item;
                sb.AppendLine("public static ReadOnlySpan<byte> MapSpan(")
                    .AppendLine($"\tin {GetIntType(item0)} item0,")
                    .AppendLine($"\tin {GetIntType(item1)} item1,")
                    .AppendLine($"\tin {GetIntType(item2)} item2)")
                    .AppendLine($"\t=> GetSpan({GetMapArg(item0, 0)}, {GetMapArg(item1, 1)}, {GetMapArg(item2, 2)});")
                    .AppendLine();
            }
            foreach (var item in IntegerTypeCombinations.GetQuadruples())
            {
                var (item0, item1, item2, item3) = item;
                sb.AppendLine("public static ReadOnlySpan<byte> MapSpan(")
                    .AppendLine($"\tin {GetIntType(item0)} item0,")
                    .AppendLine($"\tin {GetIntType(item1)} item1,")
                    .AppendLine($"\tin {GetIntType(item2)} item2,")
                    .AppendLine($"\tin {GetIntType(item3)} item3)")
                    .AppendLine($"\t=> GetSpan({GetMapArg(item0, 0)}, {GetMapArg(item1, 1)}, {GetMapArg(item2, 2)}, {GetMapArg(item3, 3)});")
                    .AppendLine();
            }
            string GetIntType(IntegerTypes type)
                => type == IntegerTypes.Short ? "Int16"
                : type == IntegerTypes.Int ? "Int32"
                : type == IntegerTypes.Long ? "Int64" : "byte";
            string GetMapArg(IntegerTypes type, byte position)
                => type == IntegerTypes.Byte
                    ? $"item{position}"
                    : $"Map(item{position})";
            File.WriteAllText("IntegerReadOnlySpanMapper.cs.txt", sb.ToString().Replace("\r\n,", ",\r\n"));
        }

        private static void MakeTestData()
        {
            var sb = new StringBuilder()
                .AppendLine("using Common.Extensions.Memory;")
                .AppendLine("using System;")
                .AppendLine("using System.Collections;")
                .AppendLine("using System.Collections.Generic;")
                .AppendLine("using static Tests.Data.OverloadTestDataIterations;")
                .AppendLine()
                .AppendLine("namespace Tests.Data")
                .AppendLine("{");

            var overloadNumber = 1;
            foreach (var item in IntegerTypeCombinations.GetDoubles())
            {
                var (item0, item1) = item;
                var type0 = GetIntType(item0);
                var type1 = GetIntType(item1);
                sb
                    .AppendLine("\t/// <summary>")
                    .AppendLine("\t/// Contains test cases for methods with these arguments:")
                    .AppendLine($"\t/// ({type0} value0, {type1} value1)")
                    .AppendLine("\t/// </summary>")
                    .AppendLine($"\tpublic class OverloadTestData_{overloadNumber} : IEnumerable<object[]>")
                    .AppendLine("\t{")
                    .AppendLine("\t\tpublic IEnumerator<object[]> GetEnumerator()")
                    .AppendLine("\t\t{")
                    .AppendLine($"\t\t\tvar size = sizeof({type0}) + sizeof({type1});")
                    .AppendLine("\t\t\tvar random = new Random();")
                    .AppendLine($"\t\t\tfor (byte i = 0; i < NumberOfTestCases; i++)")
                    .AppendLine("\t\t\t{")
                    .AppendLine("\t\t\t\tSpan<byte> control = stackalloc byte[size];");
                byte position = 0;
                position = AppendByteAssignments(sb, 0, item0, position);
                AppendByteAssignments(sb, 1, item1, position);
                sb.AppendLine("\t\t\t\tyield return new object[]")
                    .AppendLine("\t\t\t\t{")
                    .AppendLine("\t\t\t\t\tvalue0,")
                    .AppendLine("\t\t\t\t\tvalue1,")
                    .AppendLine("\t\t\t\t\tcontrol.ToArray()")
                    .AppendLine("\t\t\t\t};")
                    .AppendLine("\t\t\t}")
                    .AppendLine("\t\t}")
                    .AppendLine()
                    .AppendLine("\t\tIEnumerator IEnumerable.GetEnumerator() => GetEnumerator();")
                    .AppendLine("\t}")
                    .AppendLine();
                overloadNumber++;
            }
            foreach (var item in IntegerTypeCombinations.GetTriples())
            {
                var (item0, item1, item2) = item;
                var type0 = GetIntType(item0);
                var type1 = GetIntType(item1);
                var type2 = GetIntType(item2);
                sb
                    .AppendLine("\t/// <summary>")
                    .AppendLine("\t/// Contains test cases for methods with these arguments:")
                    .AppendLine($"\t/// ({type0} value0, {type1} value1, {type2} value2)")
                    .AppendLine("\t/// </summary>")
                    .AppendLine($"\tpublic class OverloadTestData_{overloadNumber} : IEnumerable<object[]>")
                    .AppendLine("\t{")
                    .AppendLine("\t\tpublic IEnumerator<object[]> GetEnumerator()")
                    .AppendLine("\t\t{")
                    .AppendLine($"\t\t\tvar size = sizeof({type0}) + sizeof({type1}) + sizeof({type2});")
                    .AppendLine("\t\t\tvar random = new Random();")
                    .AppendLine($"\t\t\tfor (byte i = 0; i < NumberOfTestCases; i++)")
                    .AppendLine("\t\t\t{")
                    .AppendLine("\t\t\t\tSpan<byte> control = stackalloc byte[size];");
                byte position = 0;
                position = AppendByteAssignments(sb, 0, item0, position);
                position = AppendByteAssignments(sb, 1, item1, position);
                AppendByteAssignments(sb, 2, item2, position);
                sb.AppendLine("\t\t\t\tyield return new object[]")
                    .AppendLine("\t\t\t\t{")
                    .AppendLine("\t\t\t\t\tvalue0,")
                    .AppendLine("\t\t\t\t\tvalue1,")
                    .AppendLine("\t\t\t\t\tvalue2,")
                    .AppendLine("\t\t\t\t\tcontrol.ToArray()")
                    .AppendLine("\t\t\t\t};")
                    .AppendLine("\t\t\t}")
                    .AppendLine("\t\t}")
                    .AppendLine()
                    .AppendLine("\t\tIEnumerator IEnumerable.GetEnumerator() => GetEnumerator();")
                    .AppendLine("\t}")
                    .AppendLine();
                overloadNumber++;
            }
            foreach (var item in IntegerTypeCombinations.GetQuadruples())
            {
                var (item0, item1, item2, item3) = item;
                var type0 = GetIntType(item0);
                var type1 = GetIntType(item1);
                var type2 = GetIntType(item2);
                var type3 = GetIntType(item3);
                sb
                    .AppendLine("\t/// <summary>")
                    .AppendLine("\t/// Contains test cases for methods with these arguments:")
                    .AppendLine($"\t/// ({type0} value0, {type1} value1, {type2} value2, {type3} value3)")
                    .AppendLine("\t/// </summary>")
                    .AppendLine($"\tpublic class OverloadTestData_{overloadNumber} : IEnumerable<object[]>")
                    .AppendLine("\t{")
                    .AppendLine("\t\tpublic IEnumerator<object[]> GetEnumerator()")
                    .AppendLine("\t\t{")
                    .AppendLine($"\t\t\tvar size = sizeof({GetIntType(item0)}) + sizeof({GetIntType(item1)}) + sizeof({GetIntType(item2)}) + sizeof({GetIntType(item3)});")
                    .AppendLine("\t\t\tvar random = new Random();")
                    .AppendLine($"\t\t\tfor (byte i = 0; i < NumberOfTestCases; i++)")
                    .AppendLine("\t\t\t{")
                    .AppendLine("\t\t\t\tSpan<byte> control = stackalloc byte[size];");
                byte position = 0;
                position = AppendByteAssignments(sb, 0, item0, position);
                position = AppendByteAssignments(sb, 1, item1, position);
                position = AppendByteAssignments(sb, 2, item2, position);
                AppendByteAssignments(sb, 3, item3, position);
                sb.AppendLine("\t\t\t\tyield return new object[]")
                    .AppendLine("\t\t\t\t{")
                    .AppendLine("\t\t\t\t\tvalue0,")
                    .AppendLine("\t\t\t\t\tvalue1,")
                    .AppendLine("\t\t\t\t\tvalue2,")
                    .AppendLine("\t\t\t\t\tcontrol.ToArray()")
                    .AppendLine("\t\t\t\t};")
                    .AppendLine("\t\t\t}")
                    .AppendLine("\t\t}")
                    .AppendLine()
                    .AppendLine("\t\tIEnumerator IEnumerable.GetEnumerator() => GetEnumerator();")
                    .AppendLine("\t}");
                if (new[] { item0, item1, item2, item3 }.Any(type => type != IntegerTypes.Long))
                    sb.AppendLine();
                overloadNumber++;
            }
            byte AppendByteAssignments(StringBuilder builder, byte valuePosition, IntegerTypes type, byte nextIndex)
            {
                var intType = GetIntType(type);
                var value = string.Concat("value", valuePosition);
                var cast = type == IntegerTypes.Int ? string.Empty : string.Concat("(", intType, ")");
                intType = intType == "Int64" ? "Int32" : intType;
                builder.AppendLine($"\t\t\t\tvar {value} = {cast}random.Next({intType}.MinValue, {intType}.MaxValue);");
                if (type == IntegerTypes.Byte)
                {
                    AppendByteAssignmentStatement(builder, nextIndex, value);
                    nextIndex++;
                }
                else
                {
                    var valueBytes = string.Concat(value, "bytes");
                    builder.AppendLine($"\t\t\t\tvar {valueBytes} = {value}.ToSpan();");
                    for (int i = 0; i < (byte)type; i++)
                    {
                        AppendByteAssignmentStatement(builder, nextIndex, $"{valueBytes}[{i}]");
                        nextIndex++;
                    }
                }
                return nextIndex;
            }
            void AppendByteAssignmentStatement(StringBuilder builder, byte index, string value)
                => builder.AppendLine($"\t\t\t\tcontrol[{index}] = {value};");
            string GetIntType(IntegerTypes type)
                => type == IntegerTypes.Short ? "Int16"
                : type == IntegerTypes.Int ? "Int32"
                : type == IntegerTypes.Long ? "Int64" : "byte";

            sb.AppendLine("}");

            File.WriteAllText("OverloadTestData.cs.txt", sb.ToString().Replace("\r\n,", ",\r\n"));
        }

        private static void MakeIntegerReadOnlySpanMapper_MapSpan_Tests()
        {
            var sb = new StringBuilder()
                .AppendLine("using System;")
                .AppendLine("using Tests.Data;")
                .AppendLine("using Xunit;")
                .AppendLine("using static Common.Extensions.Memory.IntegerReadOnlySpanMapper;")
                .AppendLine("using static Tests.Assertions.ByteArrayEqualityAssertor;")
                .AppendLine()
                .AppendLine("namespace Tests")
                .AppendLine("{")
                .AppendLine($"\tpublic class IntegerReadOnlySpanMapper_MapSpan")
                .AppendLine("\t{");

            var overloadNumber = 1;
            foreach (var item in IntegerTypeCombinations.GetDoubles())
            {
                var (item0, item1) = item;
                var type0 = GetIntType(item0);
                var type1 = GetIntType(item1);
                sb.AppendLine("\t\t[Theory]")
                    .AppendLine($"\t\t[ClassData(typeof(OverloadTestData_{overloadNumber}))]")
                    .AppendLine($"\t\tpublic void MapSpan_produces_equivalent_array_as_control_{overloadNumber}({type0} value0, {type1} value1, byte[] control)")
                    .AppendLine("\t\t\t=> AssertEqual(control, MapSpan(value0, value1).ToArray());")
                    .AppendLine();
                overloadNumber++;
            }
            foreach (var item in IntegerTypeCombinations.GetTriples())
            {
                var (item0, item1, item2) = item;
                var type0 = GetIntType(item0);
                var type1 = GetIntType(item1);
                var type2 = GetIntType(item2);
                sb.AppendLine("\t\t[Theory]")
                    .AppendLine($"\t\t[ClassData(typeof(OverloadTestData_{overloadNumber}))]")
                    .AppendLine($"\t\tpublic void MapSpan_produces_equivalent_array_as_control_{overloadNumber}({type0} value0, {type1} value1, {type2} value2, byte[] control)")
                    .AppendLine("\t\t\t=> AssertEqual(control, MapSpan(value0, value1, value2).ToArray());")
                    .AppendLine();
                overloadNumber++;
            }
            foreach (var item in IntegerTypeCombinations.GetQuadruples())
            {
                var (item0, item1, item2, item3) = item;
                var type0 = GetIntType(item0);
                var type1 = GetIntType(item1);
                var type2 = GetIntType(item2);
                var type3 = GetIntType(item3);
                sb.AppendLine("\t\t[Theory]")
                    .AppendLine($"\t\t[ClassData(typeof(OverloadTestData_{overloadNumber}))]")
                    .AppendLine($"\t\tpublic void MapSpan_produces_equivalent_array_as_control_{overloadNumber}({type0} value0, {type1} value1, {type2} value2, {type3} value3, byte[] control)")
                    .AppendLine("\t\t\t=> AssertEqual(control, MapSpan(value0, value1, value2, value3).ToArray());");
                if (new[] { item0, item1, item2, item3 }.Any(type => type != IntegerTypes.Long))
                    sb.AppendLine();
                overloadNumber++;
            }
            string GetIntType(IntegerTypes type)
                => type == IntegerTypes.Short ? "Int16"
                : type == IntegerTypes.Int ? "Int32"
                : type == IntegerTypes.Long ? "Int64" : "byte";

            sb.AppendLine("\t}")
                .AppendLine("}");

            File.WriteAllText("IntegerReadOnlySpanMapper_MapSpan.cs.txt", sb.ToString());
        }

        private static void MakeIntegerReadOnlySpanByteMapMapper_GetSpan_Tests()
        {
            var sb = new StringBuilder()
                .AppendLine("using Common.Extensions.Memory;")
                .AppendLine("using System;")
                .AppendLine("using Tests.Data;")
                .AppendLine("using Xunit;")
                .AppendLine("using static Common.Extensions.Memory.IntegerReadOnlySpanByteMapMapper;")
                .AppendLine("using static Tests.Assertions.ByteArrayEqualityAssertor;")
                .AppendLine()
                .AppendLine("namespace Tests")
                .AppendLine("{")
                .AppendLine($"\tpublic class IntegerReadOnlySpanByteMapMapper_GetSpan")
                .AppendLine("\t{");

            var overloadNumber = 1;
            foreach (var item in IntegerTypeCombinations.GetDoubles())
            {
                var (item0, item1) = item;
                var type0 = GetIntType(item0);
                var type1 = GetIntType(item1);
                var value0 = GetValueType(0, type0);
                var value1 = GetValueType(1, type1);
                sb.AppendLine("\t\t[Theory]")
                    .AppendLine($"\t\t[ClassData(typeof(OverloadTestData_{overloadNumber}))]")
                    .AppendLine($"\t\tpublic void GetSpan_produces_equivalent_array_as_control_{overloadNumber}({type0} value0, {type1} value1, byte[] control)")
                    .AppendLine($"\t\t\t=> AssertEqual(control, GetSpan({value0}, {value1}).ToArray());")
                    .AppendLine();
                overloadNumber++;
            }
            foreach (var item in IntegerTypeCombinations.GetTriples())
            {
                var (item0, item1, item2) = item;
                var type0 = GetIntType(item0);
                var type1 = GetIntType(item1);
                var type2 = GetIntType(item2);
                var value0 = GetValueType(0, type0);
                var value1 = GetValueType(1, type1);
                var value2 = GetValueType(2, type2);
                sb.AppendLine("\t\t[Theory]")
                    .AppendLine($"\t\t[ClassData(typeof(OverloadTestData_{overloadNumber}))]")
                    .AppendLine($"\t\tpublic void GetSpan_produces_equivalent_array_as_control_{overloadNumber}({type0} value0, {type1} value1, {type2} value2, byte[] control)")
                    .AppendLine($"\t\t\t=> AssertEqual(control, GetSpan({value0}, {value1}, {value2}).ToArray());")
                    .AppendLine();
                overloadNumber++;
            }
            foreach (var item in IntegerTypeCombinations.GetQuadruples())
            {
                var (item0, item1, item2, item3) = item;
                var type0 = GetIntType(item0);
                var type1 = GetIntType(item1);
                var type2 = GetIntType(item2);
                var type3 = GetIntType(item3);
                var value0 = GetValueType(0, type0);
                var value1 = GetValueType(1, type1);
                var value2 = GetValueType(2, type2);
                var value3 = GetValueType(3, type3);
                sb.AppendLine("\t\t[Theory]")
                    .AppendLine($"\t\t[ClassData(typeof(OverloadTestData_{overloadNumber}))]")
                    .AppendLine($"\t\tpublic void GetSpan_produces_equivalent_array_as_control_{overloadNumber}({type0} value0, {type1} value1, {type2} value2, {type3} value3, byte[] control)")
                    .AppendLine($"\t\t\t=> AssertEqual(control, GetSpan({value0}, {value1}, {value2}, {value3}).ToArray());");
                if (new[] { item0, item1, item2, item3 }.Any(type => type != IntegerTypes.Long))
                    sb.AppendLine();
                overloadNumber++;
            }
            string GetIntType(IntegerTypes type)
                => type == IntegerTypes.Short ? "Int16"
                : type == IntegerTypes.Int ? "Int32"
                : type == IntegerTypes.Long ? "Int64" : "byte";
            string GetValueType(byte position, string type)
                => type == "byte" ? string.Concat("value", position)
                    : string.Concat("new ", type, "ByteMap(value", position, ")");

            sb.AppendLine("\t}")
                .AppendLine("}");

            File.WriteAllText("IntegerReadOnlySpanByteMapMapper_GetSpan.cs.txt", sb.ToString());
        }
    }
}
