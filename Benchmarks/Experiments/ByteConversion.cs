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
    public class ByteConversion
    {
        private const Int16 _int16 = 5000;
        private const Int32 _int32 = 5000;
        private const Int64 _int64 = 5000;

        [Benchmark]
        public byte[] Int16_BitConverter()
            => BitConverter.GetBytes(_int16);

        [Benchmark]
        public byte[] Int32_BitConverter()
            => BitConverter.GetBytes(_int32);

        [Benchmark]
        public byte[] Int64_BitConverter()
            => BitConverter.GetBytes(_int64);

        [Benchmark]
        public ReadOnlySpan<byte> Int16_Span()
            => _int16.ToSpan();

        [Benchmark]
        public ReadOnlySpan<byte> Int32_Span()
            => _int32.ToSpan();

        [Benchmark]
        public ReadOnlySpan<byte> Int64_Span()
            => _int64.ToSpan();

        [Benchmark]
        public Int16ByteMap Int16_Struct()
            => new Int16ByteMap(_int16);

        [Benchmark]
        public Int32ByteMap Int32_Struct()
            => new Int32ByteMap(_int32);

        [Benchmark]
        public Int64ByteMap Int64_Struct()
            => new Int64ByteMap(_int64);
    }
}
