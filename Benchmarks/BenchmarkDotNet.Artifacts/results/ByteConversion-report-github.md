``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.1.300-rc1-008673
  [Host]     : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT
  Job-AMMCTW : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

LaunchCount=5  

```
|             Method |      Mean |     Error |    StdDev |    Median | Rank |
|------------------- |----------:|----------:|----------:|----------:|-----:|
| Int16_BitConverter |  7.109 ns | 0.0682 ns | 0.1699 ns |  7.094 ns |    4 |
| Int32_BitConverter |  7.359 ns | 0.0799 ns | 0.1974 ns |  7.324 ns |    5 |
| Int64_BitConverter |  7.513 ns | 0.1405 ns | 0.4581 ns |  7.409 ns |    6 |
|         Int16_Span | 10.277 ns | 0.1474 ns | 0.4932 ns | 10.138 ns |    7 |
|         Int32_Span | 11.122 ns | 0.1376 ns | 0.6677 ns | 10.899 ns |    8 |
|         Int64_Span | 14.193 ns | 0.3028 ns | 0.9209 ns | 13.848 ns |    9 |
|       Int16_Struct |  1.579 ns | 0.0321 ns | 0.0905 ns |  1.567 ns |    1 |
|       Int32_Struct |  1.980 ns | 0.0459 ns | 0.1402 ns |  1.936 ns |    3 |
|       Int64_Struct |  1.605 ns | 0.0247 ns | 0.0634 ns |  1.609 ns |    2 |
