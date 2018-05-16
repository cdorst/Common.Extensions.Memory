using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Running;
using Common.Extensions.Memory;
using System;

namespace Benchmarks.Experiments
{
    [SimpleJob(5)]
    [RPlotExporter, RankColumn]
    public class ByteConversion_MultipleValues
    {
        private const byte _byte = 100;
        private const Int16 _int16 = 10_000;
        private const Int32 _int32 = 1_000_000;
        private const Int64 _int64 = 1_000_000_000_000;

        [Benchmark]
        public ReadOnlySpan<byte> BlockCopy_32_bytes()
        {
            var result = new byte[32];
            Buffer.BlockCopy(new[] { _byte, _int16, _int32, _int64 }, 0, result, 0, 32);
            return result;
        }

        [Benchmark]
        public ReadOnlySpan<byte> Span_15_bytes()
            => IntegerReadOnlySpanMapper.MapSpan(_byte, _int16, _int32, _int64);
    }
}
