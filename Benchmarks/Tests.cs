using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Running;
using System;

namespace Benchmarks
{
    [SimpleJob(5)]
    [RPlotExporter, RankColumn]
    public class Tests
    {
        [Benchmark]
        public ReadOnlySpan<byte> NewArray()
            => new byte[]
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8
            };

        [Benchmark]
        public ReadOnlySpan<byte> StackallocThenArray()
        {
            ReadOnlySpan<byte> result = stackalloc byte[8]
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8
            };
            return result.ToArray();
        }
    }
}
