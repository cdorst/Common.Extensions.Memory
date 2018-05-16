``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.1.300-rc1-008673
  [Host]     : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT
  Job-NMOVSW : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

LaunchCount=5  

```
|   Method |      Mean |     Error |    StdDev |    Median | Rank |
|--------- |----------:|----------:|----------:|----------:|-----:|
| Multiple | 0.0101 ns | 0.0090 ns | 0.0227 ns | 0.0000 ns |    1 |
|   Single | 2.2847 ns | 0.0360 ns | 0.0955 ns | 2.2649 ns |    2 |
