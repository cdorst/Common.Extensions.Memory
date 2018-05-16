``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.1.300-rc1-008673
  [Host]     : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT
  Job-AMMCTW : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

LaunchCount=5  

```
|              Method |       Mean |     Error |    StdDev | Rank |
|-------------------- |-----------:|----------:|----------:|-----:|
|            NewArray |  0.3226 ns | 0.0204 ns | 0.0600 ns |    1 |
| StackallocThenArray | 26.0157 ns | 0.2897 ns | 0.8677 ns |    2 |
