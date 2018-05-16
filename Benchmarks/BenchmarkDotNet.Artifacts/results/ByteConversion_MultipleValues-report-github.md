``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.1.300-rc1-008673
  [Host]     : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT
  Job-NMOVSW : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

LaunchCount=5  

```
|             Method |     Mean |     Error |    StdDev | Rank |
|------------------- |---------:|----------:|----------:|-----:|
| BlockCopy_32_bytes | 26.13 ns | 0.2230 ns | 0.6104 ns |    1 |
|      Span_15_bytes | 41.19 ns | 0.3393 ns | 0.8386 ns |    2 |
