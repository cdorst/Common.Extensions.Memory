using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using System.Runtime.InteropServices;

namespace Benchmarks.Experiments
{
    [SimpleJob(5)]
    [RPlotExporter, RankColumn]
    public class DefaultAssignments
    {
        private const int Value = 10_000;

        [Benchmark]
        public Int32ByteMap_MultipleAssignmentStatements Multiple()
            => new Int32ByteMap_MultipleAssignmentStatements(Value);

        [Benchmark]
        public Int32ByteMap_SingleAssignmentStatement Single()
            => new Int32ByteMap_SingleAssignmentStatement(Value);

        [StructLayout(LayoutKind.Explicit)]
        public readonly ref struct Int32ByteMap_MultipleAssignmentStatements
        {
            [FieldOffset(0)] public readonly byte Byte0;
            [FieldOffset(1)] public readonly byte Byte1;
            [FieldOffset(2)] public readonly byte Byte2;
            [FieldOffset(3)] public readonly byte Byte3;

            [FieldOffset(0)] public readonly int Value;

            public Int32ByteMap_MultipleAssignmentStatements(in int value)
            {
                Byte0 = default;
                Byte1 = default;
                Byte2 = default;
                Byte3 = default;
                Value = value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public readonly ref struct Int32ByteMap_SingleAssignmentStatement
        {
            [FieldOffset(0)] public readonly byte Byte0;
            [FieldOffset(1)] public readonly byte Byte1;
            [FieldOffset(2)] public readonly byte Byte2;
            [FieldOffset(3)] public readonly byte Byte3;

            [FieldOffset(0)] public readonly int Value;

            public Int32ByteMap_SingleAssignmentStatement(in int value)
            {
                Byte0 = Byte1 = Byte2 = Byte3 = default;
                Value = value;
            }
        }
    }
}
