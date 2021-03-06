﻿using Common.Extensions.Memory;
using System;
using Tests.Data;
using Xunit;
using static Common.Extensions.Memory.IntegerReadOnlyMemoryByteMapMapper;
using static Tests.Assertions.ByteArrayEqualityAssertor;

namespace Tests
{
    public class IntegerReadOnlyMemoryByteMapMapper_GetMemory
    {
        [Theory]
        [ClassData(typeof(OverloadTestData_1))]
        public void GetMemory_produces_equivalent_array_as_control_1(byte value0, byte value1, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_2))]
        public void GetMemory_produces_equivalent_array_as_control_2(byte value0, Int16 value1, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_3))]
        public void GetMemory_produces_equivalent_array_as_control_3(byte value0, Int32 value1, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_4))]
        public void GetMemory_produces_equivalent_array_as_control_4(byte value0, Int64 value1, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_5))]
        public void GetMemory_produces_equivalent_array_as_control_5(Int16 value0, byte value1, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_6))]
        public void GetMemory_produces_equivalent_array_as_control_6(Int16 value0, Int16 value1, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_7))]
        public void GetMemory_produces_equivalent_array_as_control_7(Int16 value0, Int32 value1, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_8))]
        public void GetMemory_produces_equivalent_array_as_control_8(Int16 value0, Int64 value1, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_9))]
        public void GetMemory_produces_equivalent_array_as_control_9(Int32 value0, byte value1, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_10))]
        public void GetMemory_produces_equivalent_array_as_control_10(Int32 value0, Int16 value1, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_11))]
        public void GetMemory_produces_equivalent_array_as_control_11(Int32 value0, Int32 value1, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_12))]
        public void GetMemory_produces_equivalent_array_as_control_12(Int32 value0, Int64 value1, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_13))]
        public void GetMemory_produces_equivalent_array_as_control_13(Int64 value0, byte value1, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_14))]
        public void GetMemory_produces_equivalent_array_as_control_14(Int64 value0, Int16 value1, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_15))]
        public void GetMemory_produces_equivalent_array_as_control_15(Int64 value0, Int32 value1, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_16))]
        public void GetMemory_produces_equivalent_array_as_control_16(Int64 value0, Int64 value1, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_17))]
        public void GetMemory_produces_equivalent_array_as_control_17(byte value0, byte value1, byte value2, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1, value2).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_18))]
        public void GetMemory_produces_equivalent_array_as_control_18(byte value0, byte value1, Int16 value2, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1, new Int16ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_19))]
        public void GetMemory_produces_equivalent_array_as_control_19(byte value0, byte value1, Int32 value2, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1, new Int32ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_20))]
        public void GetMemory_produces_equivalent_array_as_control_20(byte value0, byte value1, Int64 value2, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1, new Int64ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_21))]
        public void GetMemory_produces_equivalent_array_as_control_21(byte value0, Int16 value1, byte value2, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1), value2).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_22))]
        public void GetMemory_produces_equivalent_array_as_control_22(byte value0, Int16 value1, Int16 value2, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1), new Int16ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_23))]
        public void GetMemory_produces_equivalent_array_as_control_23(byte value0, Int16 value1, Int32 value2, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1), new Int32ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_24))]
        public void GetMemory_produces_equivalent_array_as_control_24(byte value0, Int16 value1, Int64 value2, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1), new Int64ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_25))]
        public void GetMemory_produces_equivalent_array_as_control_25(byte value0, Int32 value1, byte value2, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1), value2).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_26))]
        public void GetMemory_produces_equivalent_array_as_control_26(byte value0, Int32 value1, Int16 value2, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1), new Int16ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_27))]
        public void GetMemory_produces_equivalent_array_as_control_27(byte value0, Int32 value1, Int32 value2, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1), new Int32ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_28))]
        public void GetMemory_produces_equivalent_array_as_control_28(byte value0, Int32 value1, Int64 value2, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1), new Int64ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_29))]
        public void GetMemory_produces_equivalent_array_as_control_29(byte value0, Int64 value1, byte value2, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1), value2).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_30))]
        public void GetMemory_produces_equivalent_array_as_control_30(byte value0, Int64 value1, Int16 value2, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1), new Int16ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_31))]
        public void GetMemory_produces_equivalent_array_as_control_31(byte value0, Int64 value1, Int32 value2, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1), new Int32ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_32))]
        public void GetMemory_produces_equivalent_array_as_control_32(byte value0, Int64 value1, Int64 value2, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1), new Int64ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_33))]
        public void GetMemory_produces_equivalent_array_as_control_33(Int16 value0, byte value1, byte value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1, value2).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_34))]
        public void GetMemory_produces_equivalent_array_as_control_34(Int16 value0, byte value1, Int16 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1, new Int16ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_35))]
        public void GetMemory_produces_equivalent_array_as_control_35(Int16 value0, byte value1, Int32 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1, new Int32ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_36))]
        public void GetMemory_produces_equivalent_array_as_control_36(Int16 value0, byte value1, Int64 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1, new Int64ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_37))]
        public void GetMemory_produces_equivalent_array_as_control_37(Int16 value0, Int16 value1, byte value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1), value2).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_38))]
        public void GetMemory_produces_equivalent_array_as_control_38(Int16 value0, Int16 value1, Int16 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1), new Int16ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_39))]
        public void GetMemory_produces_equivalent_array_as_control_39(Int16 value0, Int16 value1, Int32 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1), new Int32ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_40))]
        public void GetMemory_produces_equivalent_array_as_control_40(Int16 value0, Int16 value1, Int64 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1), new Int64ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_41))]
        public void GetMemory_produces_equivalent_array_as_control_41(Int16 value0, Int32 value1, byte value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1), value2).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_42))]
        public void GetMemory_produces_equivalent_array_as_control_42(Int16 value0, Int32 value1, Int16 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1), new Int16ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_43))]
        public void GetMemory_produces_equivalent_array_as_control_43(Int16 value0, Int32 value1, Int32 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1), new Int32ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_44))]
        public void GetMemory_produces_equivalent_array_as_control_44(Int16 value0, Int32 value1, Int64 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1), new Int64ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_45))]
        public void GetMemory_produces_equivalent_array_as_control_45(Int16 value0, Int64 value1, byte value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1), value2).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_46))]
        public void GetMemory_produces_equivalent_array_as_control_46(Int16 value0, Int64 value1, Int16 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1), new Int16ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_47))]
        public void GetMemory_produces_equivalent_array_as_control_47(Int16 value0, Int64 value1, Int32 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1), new Int32ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_48))]
        public void GetMemory_produces_equivalent_array_as_control_48(Int16 value0, Int64 value1, Int64 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1), new Int64ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_49))]
        public void GetMemory_produces_equivalent_array_as_control_49(Int32 value0, byte value1, byte value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1, value2).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_50))]
        public void GetMemory_produces_equivalent_array_as_control_50(Int32 value0, byte value1, Int16 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1, new Int16ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_51))]
        public void GetMemory_produces_equivalent_array_as_control_51(Int32 value0, byte value1, Int32 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1, new Int32ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_52))]
        public void GetMemory_produces_equivalent_array_as_control_52(Int32 value0, byte value1, Int64 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1, new Int64ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_53))]
        public void GetMemory_produces_equivalent_array_as_control_53(Int32 value0, Int16 value1, byte value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1), value2).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_54))]
        public void GetMemory_produces_equivalent_array_as_control_54(Int32 value0, Int16 value1, Int16 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1), new Int16ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_55))]
        public void GetMemory_produces_equivalent_array_as_control_55(Int32 value0, Int16 value1, Int32 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1), new Int32ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_56))]
        public void GetMemory_produces_equivalent_array_as_control_56(Int32 value0, Int16 value1, Int64 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1), new Int64ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_57))]
        public void GetMemory_produces_equivalent_array_as_control_57(Int32 value0, Int32 value1, byte value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1), value2).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_58))]
        public void GetMemory_produces_equivalent_array_as_control_58(Int32 value0, Int32 value1, Int16 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1), new Int16ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_59))]
        public void GetMemory_produces_equivalent_array_as_control_59(Int32 value0, Int32 value1, Int32 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1), new Int32ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_60))]
        public void GetMemory_produces_equivalent_array_as_control_60(Int32 value0, Int32 value1, Int64 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1), new Int64ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_61))]
        public void GetMemory_produces_equivalent_array_as_control_61(Int32 value0, Int64 value1, byte value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1), value2).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_62))]
        public void GetMemory_produces_equivalent_array_as_control_62(Int32 value0, Int64 value1, Int16 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1), new Int16ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_63))]
        public void GetMemory_produces_equivalent_array_as_control_63(Int32 value0, Int64 value1, Int32 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1), new Int32ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_64))]
        public void GetMemory_produces_equivalent_array_as_control_64(Int32 value0, Int64 value1, Int64 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1), new Int64ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_65))]
        public void GetMemory_produces_equivalent_array_as_control_65(Int64 value0, byte value1, byte value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1, value2).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_66))]
        public void GetMemory_produces_equivalent_array_as_control_66(Int64 value0, byte value1, Int16 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1, new Int16ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_67))]
        public void GetMemory_produces_equivalent_array_as_control_67(Int64 value0, byte value1, Int32 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1, new Int32ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_68))]
        public void GetMemory_produces_equivalent_array_as_control_68(Int64 value0, byte value1, Int64 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1, new Int64ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_69))]
        public void GetMemory_produces_equivalent_array_as_control_69(Int64 value0, Int16 value1, byte value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1), value2).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_70))]
        public void GetMemory_produces_equivalent_array_as_control_70(Int64 value0, Int16 value1, Int16 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1), new Int16ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_71))]
        public void GetMemory_produces_equivalent_array_as_control_71(Int64 value0, Int16 value1, Int32 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1), new Int32ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_72))]
        public void GetMemory_produces_equivalent_array_as_control_72(Int64 value0, Int16 value1, Int64 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1), new Int64ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_73))]
        public void GetMemory_produces_equivalent_array_as_control_73(Int64 value0, Int32 value1, byte value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1), value2).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_74))]
        public void GetMemory_produces_equivalent_array_as_control_74(Int64 value0, Int32 value1, Int16 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1), new Int16ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_75))]
        public void GetMemory_produces_equivalent_array_as_control_75(Int64 value0, Int32 value1, Int32 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1), new Int32ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_76))]
        public void GetMemory_produces_equivalent_array_as_control_76(Int64 value0, Int32 value1, Int64 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1), new Int64ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_77))]
        public void GetMemory_produces_equivalent_array_as_control_77(Int64 value0, Int64 value1, byte value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1), value2).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_78))]
        public void GetMemory_produces_equivalent_array_as_control_78(Int64 value0, Int64 value1, Int16 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1), new Int16ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_79))]
        public void GetMemory_produces_equivalent_array_as_control_79(Int64 value0, Int64 value1, Int32 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1), new Int32ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_80))]
        public void GetMemory_produces_equivalent_array_as_control_80(Int64 value0, Int64 value1, Int64 value2, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1), new Int64ByteMap(value2)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_81))]
        public void GetMemory_produces_equivalent_array_as_control_81(byte value0, byte value1, byte value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1, value2, value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_82))]
        public void GetMemory_produces_equivalent_array_as_control_82(byte value0, byte value1, byte value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1, value2, new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_83))]
        public void GetMemory_produces_equivalent_array_as_control_83(byte value0, byte value1, byte value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1, value2, new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_84))]
        public void GetMemory_produces_equivalent_array_as_control_84(byte value0, byte value1, byte value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1, value2, new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_85))]
        public void GetMemory_produces_equivalent_array_as_control_85(byte value0, byte value1, Int16 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1, new Int16ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_86))]
        public void GetMemory_produces_equivalent_array_as_control_86(byte value0, byte value1, Int16 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1, new Int16ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_87))]
        public void GetMemory_produces_equivalent_array_as_control_87(byte value0, byte value1, Int16 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1, new Int16ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_88))]
        public void GetMemory_produces_equivalent_array_as_control_88(byte value0, byte value1, Int16 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1, new Int16ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_89))]
        public void GetMemory_produces_equivalent_array_as_control_89(byte value0, byte value1, Int32 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1, new Int32ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_90))]
        public void GetMemory_produces_equivalent_array_as_control_90(byte value0, byte value1, Int32 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1, new Int32ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_91))]
        public void GetMemory_produces_equivalent_array_as_control_91(byte value0, byte value1, Int32 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1, new Int32ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_92))]
        public void GetMemory_produces_equivalent_array_as_control_92(byte value0, byte value1, Int32 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1, new Int32ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_93))]
        public void GetMemory_produces_equivalent_array_as_control_93(byte value0, byte value1, Int64 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1, new Int64ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_94))]
        public void GetMemory_produces_equivalent_array_as_control_94(byte value0, byte value1, Int64 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1, new Int64ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_95))]
        public void GetMemory_produces_equivalent_array_as_control_95(byte value0, byte value1, Int64 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1, new Int64ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_96))]
        public void GetMemory_produces_equivalent_array_as_control_96(byte value0, byte value1, Int64 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, value1, new Int64ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_97))]
        public void GetMemory_produces_equivalent_array_as_control_97(byte value0, Int16 value1, byte value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1), value2, value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_98))]
        public void GetMemory_produces_equivalent_array_as_control_98(byte value0, Int16 value1, byte value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1), value2, new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_99))]
        public void GetMemory_produces_equivalent_array_as_control_99(byte value0, Int16 value1, byte value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1), value2, new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_100))]
        public void GetMemory_produces_equivalent_array_as_control_100(byte value0, Int16 value1, byte value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1), value2, new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_101))]
        public void GetMemory_produces_equivalent_array_as_control_101(byte value0, Int16 value1, Int16 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1), new Int16ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_102))]
        public void GetMemory_produces_equivalent_array_as_control_102(byte value0, Int16 value1, Int16 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1), new Int16ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_103))]
        public void GetMemory_produces_equivalent_array_as_control_103(byte value0, Int16 value1, Int16 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1), new Int16ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_104))]
        public void GetMemory_produces_equivalent_array_as_control_104(byte value0, Int16 value1, Int16 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1), new Int16ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_105))]
        public void GetMemory_produces_equivalent_array_as_control_105(byte value0, Int16 value1, Int32 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1), new Int32ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_106))]
        public void GetMemory_produces_equivalent_array_as_control_106(byte value0, Int16 value1, Int32 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1), new Int32ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_107))]
        public void GetMemory_produces_equivalent_array_as_control_107(byte value0, Int16 value1, Int32 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1), new Int32ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_108))]
        public void GetMemory_produces_equivalent_array_as_control_108(byte value0, Int16 value1, Int32 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1), new Int32ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_109))]
        public void GetMemory_produces_equivalent_array_as_control_109(byte value0, Int16 value1, Int64 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1), new Int64ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_110))]
        public void GetMemory_produces_equivalent_array_as_control_110(byte value0, Int16 value1, Int64 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1), new Int64ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_111))]
        public void GetMemory_produces_equivalent_array_as_control_111(byte value0, Int16 value1, Int64 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1), new Int64ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_112))]
        public void GetMemory_produces_equivalent_array_as_control_112(byte value0, Int16 value1, Int64 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int16ByteMap(value1), new Int64ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_113))]
        public void GetMemory_produces_equivalent_array_as_control_113(byte value0, Int32 value1, byte value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1), value2, value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_114))]
        public void GetMemory_produces_equivalent_array_as_control_114(byte value0, Int32 value1, byte value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1), value2, new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_115))]
        public void GetMemory_produces_equivalent_array_as_control_115(byte value0, Int32 value1, byte value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1), value2, new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_116))]
        public void GetMemory_produces_equivalent_array_as_control_116(byte value0, Int32 value1, byte value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1), value2, new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_117))]
        public void GetMemory_produces_equivalent_array_as_control_117(byte value0, Int32 value1, Int16 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1), new Int16ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_118))]
        public void GetMemory_produces_equivalent_array_as_control_118(byte value0, Int32 value1, Int16 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1), new Int16ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_119))]
        public void GetMemory_produces_equivalent_array_as_control_119(byte value0, Int32 value1, Int16 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1), new Int16ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_120))]
        public void GetMemory_produces_equivalent_array_as_control_120(byte value0, Int32 value1, Int16 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1), new Int16ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_121))]
        public void GetMemory_produces_equivalent_array_as_control_121(byte value0, Int32 value1, Int32 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1), new Int32ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_122))]
        public void GetMemory_produces_equivalent_array_as_control_122(byte value0, Int32 value1, Int32 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1), new Int32ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_123))]
        public void GetMemory_produces_equivalent_array_as_control_123(byte value0, Int32 value1, Int32 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1), new Int32ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_124))]
        public void GetMemory_produces_equivalent_array_as_control_124(byte value0, Int32 value1, Int32 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1), new Int32ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_125))]
        public void GetMemory_produces_equivalent_array_as_control_125(byte value0, Int32 value1, Int64 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1), new Int64ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_126))]
        public void GetMemory_produces_equivalent_array_as_control_126(byte value0, Int32 value1, Int64 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1), new Int64ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_127))]
        public void GetMemory_produces_equivalent_array_as_control_127(byte value0, Int32 value1, Int64 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1), new Int64ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_128))]
        public void GetMemory_produces_equivalent_array_as_control_128(byte value0, Int32 value1, Int64 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int32ByteMap(value1), new Int64ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_129))]
        public void GetMemory_produces_equivalent_array_as_control_129(byte value0, Int64 value1, byte value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1), value2, value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_130))]
        public void GetMemory_produces_equivalent_array_as_control_130(byte value0, Int64 value1, byte value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1), value2, new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_131))]
        public void GetMemory_produces_equivalent_array_as_control_131(byte value0, Int64 value1, byte value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1), value2, new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_132))]
        public void GetMemory_produces_equivalent_array_as_control_132(byte value0, Int64 value1, byte value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1), value2, new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_133))]
        public void GetMemory_produces_equivalent_array_as_control_133(byte value0, Int64 value1, Int16 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1), new Int16ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_134))]
        public void GetMemory_produces_equivalent_array_as_control_134(byte value0, Int64 value1, Int16 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1), new Int16ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_135))]
        public void GetMemory_produces_equivalent_array_as_control_135(byte value0, Int64 value1, Int16 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1), new Int16ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_136))]
        public void GetMemory_produces_equivalent_array_as_control_136(byte value0, Int64 value1, Int16 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1), new Int16ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_137))]
        public void GetMemory_produces_equivalent_array_as_control_137(byte value0, Int64 value1, Int32 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1), new Int32ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_138))]
        public void GetMemory_produces_equivalent_array_as_control_138(byte value0, Int64 value1, Int32 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1), new Int32ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_139))]
        public void GetMemory_produces_equivalent_array_as_control_139(byte value0, Int64 value1, Int32 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1), new Int32ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_140))]
        public void GetMemory_produces_equivalent_array_as_control_140(byte value0, Int64 value1, Int32 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1), new Int32ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_141))]
        public void GetMemory_produces_equivalent_array_as_control_141(byte value0, Int64 value1, Int64 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1), new Int64ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_142))]
        public void GetMemory_produces_equivalent_array_as_control_142(byte value0, Int64 value1, Int64 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1), new Int64ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_143))]
        public void GetMemory_produces_equivalent_array_as_control_143(byte value0, Int64 value1, Int64 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1), new Int64ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_144))]
        public void GetMemory_produces_equivalent_array_as_control_144(byte value0, Int64 value1, Int64 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(value0, new Int64ByteMap(value1), new Int64ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_145))]
        public void GetMemory_produces_equivalent_array_as_control_145(Int16 value0, byte value1, byte value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1, value2, value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_146))]
        public void GetMemory_produces_equivalent_array_as_control_146(Int16 value0, byte value1, byte value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1, value2, new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_147))]
        public void GetMemory_produces_equivalent_array_as_control_147(Int16 value0, byte value1, byte value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1, value2, new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_148))]
        public void GetMemory_produces_equivalent_array_as_control_148(Int16 value0, byte value1, byte value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1, value2, new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_149))]
        public void GetMemory_produces_equivalent_array_as_control_149(Int16 value0, byte value1, Int16 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1, new Int16ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_150))]
        public void GetMemory_produces_equivalent_array_as_control_150(Int16 value0, byte value1, Int16 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1, new Int16ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_151))]
        public void GetMemory_produces_equivalent_array_as_control_151(Int16 value0, byte value1, Int16 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1, new Int16ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_152))]
        public void GetMemory_produces_equivalent_array_as_control_152(Int16 value0, byte value1, Int16 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1, new Int16ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_153))]
        public void GetMemory_produces_equivalent_array_as_control_153(Int16 value0, byte value1, Int32 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1, new Int32ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_154))]
        public void GetMemory_produces_equivalent_array_as_control_154(Int16 value0, byte value1, Int32 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1, new Int32ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_155))]
        public void GetMemory_produces_equivalent_array_as_control_155(Int16 value0, byte value1, Int32 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1, new Int32ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_156))]
        public void GetMemory_produces_equivalent_array_as_control_156(Int16 value0, byte value1, Int32 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1, new Int32ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_157))]
        public void GetMemory_produces_equivalent_array_as_control_157(Int16 value0, byte value1, Int64 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1, new Int64ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_158))]
        public void GetMemory_produces_equivalent_array_as_control_158(Int16 value0, byte value1, Int64 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1, new Int64ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_159))]
        public void GetMemory_produces_equivalent_array_as_control_159(Int16 value0, byte value1, Int64 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1, new Int64ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_160))]
        public void GetMemory_produces_equivalent_array_as_control_160(Int16 value0, byte value1, Int64 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), value1, new Int64ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_161))]
        public void GetMemory_produces_equivalent_array_as_control_161(Int16 value0, Int16 value1, byte value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1), value2, value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_162))]
        public void GetMemory_produces_equivalent_array_as_control_162(Int16 value0, Int16 value1, byte value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1), value2, new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_163))]
        public void GetMemory_produces_equivalent_array_as_control_163(Int16 value0, Int16 value1, byte value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1), value2, new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_164))]
        public void GetMemory_produces_equivalent_array_as_control_164(Int16 value0, Int16 value1, byte value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1), value2, new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_165))]
        public void GetMemory_produces_equivalent_array_as_control_165(Int16 value0, Int16 value1, Int16 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1), new Int16ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_166))]
        public void GetMemory_produces_equivalent_array_as_control_166(Int16 value0, Int16 value1, Int16 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1), new Int16ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_167))]
        public void GetMemory_produces_equivalent_array_as_control_167(Int16 value0, Int16 value1, Int16 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1), new Int16ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_168))]
        public void GetMemory_produces_equivalent_array_as_control_168(Int16 value0, Int16 value1, Int16 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1), new Int16ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_169))]
        public void GetMemory_produces_equivalent_array_as_control_169(Int16 value0, Int16 value1, Int32 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1), new Int32ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_170))]
        public void GetMemory_produces_equivalent_array_as_control_170(Int16 value0, Int16 value1, Int32 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1), new Int32ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_171))]
        public void GetMemory_produces_equivalent_array_as_control_171(Int16 value0, Int16 value1, Int32 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1), new Int32ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_172))]
        public void GetMemory_produces_equivalent_array_as_control_172(Int16 value0, Int16 value1, Int32 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1), new Int32ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_173))]
        public void GetMemory_produces_equivalent_array_as_control_173(Int16 value0, Int16 value1, Int64 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1), new Int64ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_174))]
        public void GetMemory_produces_equivalent_array_as_control_174(Int16 value0, Int16 value1, Int64 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1), new Int64ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_175))]
        public void GetMemory_produces_equivalent_array_as_control_175(Int16 value0, Int16 value1, Int64 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1), new Int64ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_176))]
        public void GetMemory_produces_equivalent_array_as_control_176(Int16 value0, Int16 value1, Int64 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int16ByteMap(value1), new Int64ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_177))]
        public void GetMemory_produces_equivalent_array_as_control_177(Int16 value0, Int32 value1, byte value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1), value2, value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_178))]
        public void GetMemory_produces_equivalent_array_as_control_178(Int16 value0, Int32 value1, byte value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1), value2, new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_179))]
        public void GetMemory_produces_equivalent_array_as_control_179(Int16 value0, Int32 value1, byte value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1), value2, new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_180))]
        public void GetMemory_produces_equivalent_array_as_control_180(Int16 value0, Int32 value1, byte value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1), value2, new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_181))]
        public void GetMemory_produces_equivalent_array_as_control_181(Int16 value0, Int32 value1, Int16 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1), new Int16ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_182))]
        public void GetMemory_produces_equivalent_array_as_control_182(Int16 value0, Int32 value1, Int16 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1), new Int16ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_183))]
        public void GetMemory_produces_equivalent_array_as_control_183(Int16 value0, Int32 value1, Int16 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1), new Int16ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_184))]
        public void GetMemory_produces_equivalent_array_as_control_184(Int16 value0, Int32 value1, Int16 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1), new Int16ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_185))]
        public void GetMemory_produces_equivalent_array_as_control_185(Int16 value0, Int32 value1, Int32 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1), new Int32ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_186))]
        public void GetMemory_produces_equivalent_array_as_control_186(Int16 value0, Int32 value1, Int32 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1), new Int32ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_187))]
        public void GetMemory_produces_equivalent_array_as_control_187(Int16 value0, Int32 value1, Int32 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1), new Int32ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_188))]
        public void GetMemory_produces_equivalent_array_as_control_188(Int16 value0, Int32 value1, Int32 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1), new Int32ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_189))]
        public void GetMemory_produces_equivalent_array_as_control_189(Int16 value0, Int32 value1, Int64 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1), new Int64ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_190))]
        public void GetMemory_produces_equivalent_array_as_control_190(Int16 value0, Int32 value1, Int64 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1), new Int64ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_191))]
        public void GetMemory_produces_equivalent_array_as_control_191(Int16 value0, Int32 value1, Int64 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1), new Int64ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_192))]
        public void GetMemory_produces_equivalent_array_as_control_192(Int16 value0, Int32 value1, Int64 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int32ByteMap(value1), new Int64ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_193))]
        public void GetMemory_produces_equivalent_array_as_control_193(Int16 value0, Int64 value1, byte value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1), value2, value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_194))]
        public void GetMemory_produces_equivalent_array_as_control_194(Int16 value0, Int64 value1, byte value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1), value2, new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_195))]
        public void GetMemory_produces_equivalent_array_as_control_195(Int16 value0, Int64 value1, byte value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1), value2, new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_196))]
        public void GetMemory_produces_equivalent_array_as_control_196(Int16 value0, Int64 value1, byte value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1), value2, new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_197))]
        public void GetMemory_produces_equivalent_array_as_control_197(Int16 value0, Int64 value1, Int16 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1), new Int16ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_198))]
        public void GetMemory_produces_equivalent_array_as_control_198(Int16 value0, Int64 value1, Int16 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1), new Int16ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_199))]
        public void GetMemory_produces_equivalent_array_as_control_199(Int16 value0, Int64 value1, Int16 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1), new Int16ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_200))]
        public void GetMemory_produces_equivalent_array_as_control_200(Int16 value0, Int64 value1, Int16 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1), new Int16ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_201))]
        public void GetMemory_produces_equivalent_array_as_control_201(Int16 value0, Int64 value1, Int32 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1), new Int32ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_202))]
        public void GetMemory_produces_equivalent_array_as_control_202(Int16 value0, Int64 value1, Int32 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1), new Int32ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_203))]
        public void GetMemory_produces_equivalent_array_as_control_203(Int16 value0, Int64 value1, Int32 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1), new Int32ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_204))]
        public void GetMemory_produces_equivalent_array_as_control_204(Int16 value0, Int64 value1, Int32 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1), new Int32ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_205))]
        public void GetMemory_produces_equivalent_array_as_control_205(Int16 value0, Int64 value1, Int64 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1), new Int64ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_206))]
        public void GetMemory_produces_equivalent_array_as_control_206(Int16 value0, Int64 value1, Int64 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1), new Int64ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_207))]
        public void GetMemory_produces_equivalent_array_as_control_207(Int16 value0, Int64 value1, Int64 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1), new Int64ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_208))]
        public void GetMemory_produces_equivalent_array_as_control_208(Int16 value0, Int64 value1, Int64 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int16ByteMap(value0), new Int64ByteMap(value1), new Int64ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_209))]
        public void GetMemory_produces_equivalent_array_as_control_209(Int32 value0, byte value1, byte value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1, value2, value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_210))]
        public void GetMemory_produces_equivalent_array_as_control_210(Int32 value0, byte value1, byte value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1, value2, new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_211))]
        public void GetMemory_produces_equivalent_array_as_control_211(Int32 value0, byte value1, byte value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1, value2, new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_212))]
        public void GetMemory_produces_equivalent_array_as_control_212(Int32 value0, byte value1, byte value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1, value2, new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_213))]
        public void GetMemory_produces_equivalent_array_as_control_213(Int32 value0, byte value1, Int16 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1, new Int16ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_214))]
        public void GetMemory_produces_equivalent_array_as_control_214(Int32 value0, byte value1, Int16 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1, new Int16ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_215))]
        public void GetMemory_produces_equivalent_array_as_control_215(Int32 value0, byte value1, Int16 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1, new Int16ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_216))]
        public void GetMemory_produces_equivalent_array_as_control_216(Int32 value0, byte value1, Int16 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1, new Int16ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_217))]
        public void GetMemory_produces_equivalent_array_as_control_217(Int32 value0, byte value1, Int32 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1, new Int32ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_218))]
        public void GetMemory_produces_equivalent_array_as_control_218(Int32 value0, byte value1, Int32 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1, new Int32ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_219))]
        public void GetMemory_produces_equivalent_array_as_control_219(Int32 value0, byte value1, Int32 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1, new Int32ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_220))]
        public void GetMemory_produces_equivalent_array_as_control_220(Int32 value0, byte value1, Int32 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1, new Int32ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_221))]
        public void GetMemory_produces_equivalent_array_as_control_221(Int32 value0, byte value1, Int64 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1, new Int64ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_222))]
        public void GetMemory_produces_equivalent_array_as_control_222(Int32 value0, byte value1, Int64 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1, new Int64ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_223))]
        public void GetMemory_produces_equivalent_array_as_control_223(Int32 value0, byte value1, Int64 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1, new Int64ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_224))]
        public void GetMemory_produces_equivalent_array_as_control_224(Int32 value0, byte value1, Int64 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), value1, new Int64ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_225))]
        public void GetMemory_produces_equivalent_array_as_control_225(Int32 value0, Int16 value1, byte value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1), value2, value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_226))]
        public void GetMemory_produces_equivalent_array_as_control_226(Int32 value0, Int16 value1, byte value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1), value2, new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_227))]
        public void GetMemory_produces_equivalent_array_as_control_227(Int32 value0, Int16 value1, byte value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1), value2, new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_228))]
        public void GetMemory_produces_equivalent_array_as_control_228(Int32 value0, Int16 value1, byte value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1), value2, new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_229))]
        public void GetMemory_produces_equivalent_array_as_control_229(Int32 value0, Int16 value1, Int16 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1), new Int16ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_230))]
        public void GetMemory_produces_equivalent_array_as_control_230(Int32 value0, Int16 value1, Int16 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1), new Int16ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_231))]
        public void GetMemory_produces_equivalent_array_as_control_231(Int32 value0, Int16 value1, Int16 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1), new Int16ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_232))]
        public void GetMemory_produces_equivalent_array_as_control_232(Int32 value0, Int16 value1, Int16 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1), new Int16ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_233))]
        public void GetMemory_produces_equivalent_array_as_control_233(Int32 value0, Int16 value1, Int32 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1), new Int32ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_234))]
        public void GetMemory_produces_equivalent_array_as_control_234(Int32 value0, Int16 value1, Int32 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1), new Int32ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_235))]
        public void GetMemory_produces_equivalent_array_as_control_235(Int32 value0, Int16 value1, Int32 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1), new Int32ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_236))]
        public void GetMemory_produces_equivalent_array_as_control_236(Int32 value0, Int16 value1, Int32 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1), new Int32ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_237))]
        public void GetMemory_produces_equivalent_array_as_control_237(Int32 value0, Int16 value1, Int64 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1), new Int64ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_238))]
        public void GetMemory_produces_equivalent_array_as_control_238(Int32 value0, Int16 value1, Int64 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1), new Int64ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_239))]
        public void GetMemory_produces_equivalent_array_as_control_239(Int32 value0, Int16 value1, Int64 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1), new Int64ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_240))]
        public void GetMemory_produces_equivalent_array_as_control_240(Int32 value0, Int16 value1, Int64 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int16ByteMap(value1), new Int64ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_241))]
        public void GetMemory_produces_equivalent_array_as_control_241(Int32 value0, Int32 value1, byte value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1), value2, value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_242))]
        public void GetMemory_produces_equivalent_array_as_control_242(Int32 value0, Int32 value1, byte value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1), value2, new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_243))]
        public void GetMemory_produces_equivalent_array_as_control_243(Int32 value0, Int32 value1, byte value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1), value2, new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_244))]
        public void GetMemory_produces_equivalent_array_as_control_244(Int32 value0, Int32 value1, byte value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1), value2, new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_245))]
        public void GetMemory_produces_equivalent_array_as_control_245(Int32 value0, Int32 value1, Int16 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1), new Int16ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_246))]
        public void GetMemory_produces_equivalent_array_as_control_246(Int32 value0, Int32 value1, Int16 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1), new Int16ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_247))]
        public void GetMemory_produces_equivalent_array_as_control_247(Int32 value0, Int32 value1, Int16 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1), new Int16ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_248))]
        public void GetMemory_produces_equivalent_array_as_control_248(Int32 value0, Int32 value1, Int16 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1), new Int16ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_249))]
        public void GetMemory_produces_equivalent_array_as_control_249(Int32 value0, Int32 value1, Int32 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1), new Int32ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_250))]
        public void GetMemory_produces_equivalent_array_as_control_250(Int32 value0, Int32 value1, Int32 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1), new Int32ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_251))]
        public void GetMemory_produces_equivalent_array_as_control_251(Int32 value0, Int32 value1, Int32 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1), new Int32ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_252))]
        public void GetMemory_produces_equivalent_array_as_control_252(Int32 value0, Int32 value1, Int32 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1), new Int32ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_253))]
        public void GetMemory_produces_equivalent_array_as_control_253(Int32 value0, Int32 value1, Int64 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1), new Int64ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_254))]
        public void GetMemory_produces_equivalent_array_as_control_254(Int32 value0, Int32 value1, Int64 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1), new Int64ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_255))]
        public void GetMemory_produces_equivalent_array_as_control_255(Int32 value0, Int32 value1, Int64 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1), new Int64ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_256))]
        public void GetMemory_produces_equivalent_array_as_control_256(Int32 value0, Int32 value1, Int64 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int32ByteMap(value1), new Int64ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_257))]
        public void GetMemory_produces_equivalent_array_as_control_257(Int32 value0, Int64 value1, byte value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1), value2, value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_258))]
        public void GetMemory_produces_equivalent_array_as_control_258(Int32 value0, Int64 value1, byte value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1), value2, new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_259))]
        public void GetMemory_produces_equivalent_array_as_control_259(Int32 value0, Int64 value1, byte value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1), value2, new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_260))]
        public void GetMemory_produces_equivalent_array_as_control_260(Int32 value0, Int64 value1, byte value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1), value2, new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_261))]
        public void GetMemory_produces_equivalent_array_as_control_261(Int32 value0, Int64 value1, Int16 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1), new Int16ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_262))]
        public void GetMemory_produces_equivalent_array_as_control_262(Int32 value0, Int64 value1, Int16 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1), new Int16ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_263))]
        public void GetMemory_produces_equivalent_array_as_control_263(Int32 value0, Int64 value1, Int16 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1), new Int16ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_264))]
        public void GetMemory_produces_equivalent_array_as_control_264(Int32 value0, Int64 value1, Int16 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1), new Int16ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_265))]
        public void GetMemory_produces_equivalent_array_as_control_265(Int32 value0, Int64 value1, Int32 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1), new Int32ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_266))]
        public void GetMemory_produces_equivalent_array_as_control_266(Int32 value0, Int64 value1, Int32 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1), new Int32ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_267))]
        public void GetMemory_produces_equivalent_array_as_control_267(Int32 value0, Int64 value1, Int32 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1), new Int32ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_268))]
        public void GetMemory_produces_equivalent_array_as_control_268(Int32 value0, Int64 value1, Int32 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1), new Int32ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_269))]
        public void GetMemory_produces_equivalent_array_as_control_269(Int32 value0, Int64 value1, Int64 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1), new Int64ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_270))]
        public void GetMemory_produces_equivalent_array_as_control_270(Int32 value0, Int64 value1, Int64 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1), new Int64ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_271))]
        public void GetMemory_produces_equivalent_array_as_control_271(Int32 value0, Int64 value1, Int64 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1), new Int64ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_272))]
        public void GetMemory_produces_equivalent_array_as_control_272(Int32 value0, Int64 value1, Int64 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int32ByteMap(value0), new Int64ByteMap(value1), new Int64ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_273))]
        public void GetMemory_produces_equivalent_array_as_control_273(Int64 value0, byte value1, byte value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1, value2, value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_274))]
        public void GetMemory_produces_equivalent_array_as_control_274(Int64 value0, byte value1, byte value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1, value2, new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_275))]
        public void GetMemory_produces_equivalent_array_as_control_275(Int64 value0, byte value1, byte value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1, value2, new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_276))]
        public void GetMemory_produces_equivalent_array_as_control_276(Int64 value0, byte value1, byte value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1, value2, new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_277))]
        public void GetMemory_produces_equivalent_array_as_control_277(Int64 value0, byte value1, Int16 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1, new Int16ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_278))]
        public void GetMemory_produces_equivalent_array_as_control_278(Int64 value0, byte value1, Int16 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1, new Int16ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_279))]
        public void GetMemory_produces_equivalent_array_as_control_279(Int64 value0, byte value1, Int16 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1, new Int16ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_280))]
        public void GetMemory_produces_equivalent_array_as_control_280(Int64 value0, byte value1, Int16 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1, new Int16ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_281))]
        public void GetMemory_produces_equivalent_array_as_control_281(Int64 value0, byte value1, Int32 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1, new Int32ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_282))]
        public void GetMemory_produces_equivalent_array_as_control_282(Int64 value0, byte value1, Int32 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1, new Int32ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_283))]
        public void GetMemory_produces_equivalent_array_as_control_283(Int64 value0, byte value1, Int32 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1, new Int32ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_284))]
        public void GetMemory_produces_equivalent_array_as_control_284(Int64 value0, byte value1, Int32 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1, new Int32ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_285))]
        public void GetMemory_produces_equivalent_array_as_control_285(Int64 value0, byte value1, Int64 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1, new Int64ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_286))]
        public void GetMemory_produces_equivalent_array_as_control_286(Int64 value0, byte value1, Int64 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1, new Int64ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_287))]
        public void GetMemory_produces_equivalent_array_as_control_287(Int64 value0, byte value1, Int64 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1, new Int64ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_288))]
        public void GetMemory_produces_equivalent_array_as_control_288(Int64 value0, byte value1, Int64 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), value1, new Int64ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_289))]
        public void GetMemory_produces_equivalent_array_as_control_289(Int64 value0, Int16 value1, byte value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1), value2, value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_290))]
        public void GetMemory_produces_equivalent_array_as_control_290(Int64 value0, Int16 value1, byte value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1), value2, new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_291))]
        public void GetMemory_produces_equivalent_array_as_control_291(Int64 value0, Int16 value1, byte value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1), value2, new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_292))]
        public void GetMemory_produces_equivalent_array_as_control_292(Int64 value0, Int16 value1, byte value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1), value2, new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_293))]
        public void GetMemory_produces_equivalent_array_as_control_293(Int64 value0, Int16 value1, Int16 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1), new Int16ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_294))]
        public void GetMemory_produces_equivalent_array_as_control_294(Int64 value0, Int16 value1, Int16 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1), new Int16ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_295))]
        public void GetMemory_produces_equivalent_array_as_control_295(Int64 value0, Int16 value1, Int16 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1), new Int16ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_296))]
        public void GetMemory_produces_equivalent_array_as_control_296(Int64 value0, Int16 value1, Int16 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1), new Int16ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_297))]
        public void GetMemory_produces_equivalent_array_as_control_297(Int64 value0, Int16 value1, Int32 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1), new Int32ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_298))]
        public void GetMemory_produces_equivalent_array_as_control_298(Int64 value0, Int16 value1, Int32 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1), new Int32ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_299))]
        public void GetMemory_produces_equivalent_array_as_control_299(Int64 value0, Int16 value1, Int32 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1), new Int32ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_300))]
        public void GetMemory_produces_equivalent_array_as_control_300(Int64 value0, Int16 value1, Int32 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1), new Int32ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_301))]
        public void GetMemory_produces_equivalent_array_as_control_301(Int64 value0, Int16 value1, Int64 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1), new Int64ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_302))]
        public void GetMemory_produces_equivalent_array_as_control_302(Int64 value0, Int16 value1, Int64 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1), new Int64ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_303))]
        public void GetMemory_produces_equivalent_array_as_control_303(Int64 value0, Int16 value1, Int64 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1), new Int64ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_304))]
        public void GetMemory_produces_equivalent_array_as_control_304(Int64 value0, Int16 value1, Int64 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int16ByteMap(value1), new Int64ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_305))]
        public void GetMemory_produces_equivalent_array_as_control_305(Int64 value0, Int32 value1, byte value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1), value2, value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_306))]
        public void GetMemory_produces_equivalent_array_as_control_306(Int64 value0, Int32 value1, byte value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1), value2, new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_307))]
        public void GetMemory_produces_equivalent_array_as_control_307(Int64 value0, Int32 value1, byte value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1), value2, new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_308))]
        public void GetMemory_produces_equivalent_array_as_control_308(Int64 value0, Int32 value1, byte value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1), value2, new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_309))]
        public void GetMemory_produces_equivalent_array_as_control_309(Int64 value0, Int32 value1, Int16 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1), new Int16ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_310))]
        public void GetMemory_produces_equivalent_array_as_control_310(Int64 value0, Int32 value1, Int16 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1), new Int16ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_311))]
        public void GetMemory_produces_equivalent_array_as_control_311(Int64 value0, Int32 value1, Int16 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1), new Int16ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_312))]
        public void GetMemory_produces_equivalent_array_as_control_312(Int64 value0, Int32 value1, Int16 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1), new Int16ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_313))]
        public void GetMemory_produces_equivalent_array_as_control_313(Int64 value0, Int32 value1, Int32 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1), new Int32ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_314))]
        public void GetMemory_produces_equivalent_array_as_control_314(Int64 value0, Int32 value1, Int32 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1), new Int32ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_315))]
        public void GetMemory_produces_equivalent_array_as_control_315(Int64 value0, Int32 value1, Int32 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1), new Int32ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_316))]
        public void GetMemory_produces_equivalent_array_as_control_316(Int64 value0, Int32 value1, Int32 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1), new Int32ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_317))]
        public void GetMemory_produces_equivalent_array_as_control_317(Int64 value0, Int32 value1, Int64 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1), new Int64ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_318))]
        public void GetMemory_produces_equivalent_array_as_control_318(Int64 value0, Int32 value1, Int64 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1), new Int64ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_319))]
        public void GetMemory_produces_equivalent_array_as_control_319(Int64 value0, Int32 value1, Int64 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1), new Int64ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_320))]
        public void GetMemory_produces_equivalent_array_as_control_320(Int64 value0, Int32 value1, Int64 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int32ByteMap(value1), new Int64ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_321))]
        public void GetMemory_produces_equivalent_array_as_control_321(Int64 value0, Int64 value1, byte value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1), value2, value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_322))]
        public void GetMemory_produces_equivalent_array_as_control_322(Int64 value0, Int64 value1, byte value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1), value2, new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_323))]
        public void GetMemory_produces_equivalent_array_as_control_323(Int64 value0, Int64 value1, byte value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1), value2, new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_324))]
        public void GetMemory_produces_equivalent_array_as_control_324(Int64 value0, Int64 value1, byte value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1), value2, new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_325))]
        public void GetMemory_produces_equivalent_array_as_control_325(Int64 value0, Int64 value1, Int16 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1), new Int16ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_326))]
        public void GetMemory_produces_equivalent_array_as_control_326(Int64 value0, Int64 value1, Int16 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1), new Int16ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_327))]
        public void GetMemory_produces_equivalent_array_as_control_327(Int64 value0, Int64 value1, Int16 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1), new Int16ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_328))]
        public void GetMemory_produces_equivalent_array_as_control_328(Int64 value0, Int64 value1, Int16 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1), new Int16ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_329))]
        public void GetMemory_produces_equivalent_array_as_control_329(Int64 value0, Int64 value1, Int32 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1), new Int32ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_330))]
        public void GetMemory_produces_equivalent_array_as_control_330(Int64 value0, Int64 value1, Int32 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1), new Int32ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_331))]
        public void GetMemory_produces_equivalent_array_as_control_331(Int64 value0, Int64 value1, Int32 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1), new Int32ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_332))]
        public void GetMemory_produces_equivalent_array_as_control_332(Int64 value0, Int64 value1, Int32 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1), new Int32ByteMap(value2), new Int64ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_333))]
        public void GetMemory_produces_equivalent_array_as_control_333(Int64 value0, Int64 value1, Int64 value2, byte value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1), new Int64ByteMap(value2), value3).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_334))]
        public void GetMemory_produces_equivalent_array_as_control_334(Int64 value0, Int64 value1, Int64 value2, Int16 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1), new Int64ByteMap(value2), new Int16ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_335))]
        public void GetMemory_produces_equivalent_array_as_control_335(Int64 value0, Int64 value1, Int64 value2, Int32 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1), new Int64ByteMap(value2), new Int32ByteMap(value3)).ToArray());

        [Theory]
        [ClassData(typeof(OverloadTestData_336))]
        public void GetMemory_produces_equivalent_array_as_control_336(Int64 value0, Int64 value1, Int64 value2, Int64 value3, byte[] control)
            => AssertEqual(control, GetMemory(new Int64ByteMap(value0), new Int64ByteMap(value1), new Int64ByteMap(value2), new Int64ByteMap(value3)).ToArray());
    }
}
