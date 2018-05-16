using BenchmarkDotNet.Running;

namespace Benchmarks
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<Experiments.ArrayAllocation>();
            BenchmarkRunner.Run<Experiments.ByteConversion>();
            BenchmarkRunner.Run<Experiments.ByteConversion_MultipleValues>();
            BenchmarkRunner.Run<Experiments.DefaultAssignments>();
        }
    }
}
