# Common.Extensions.Memory

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/common-extensions-memory.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/common-extensions-memory)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.Common.Extensions.Memory.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.Common.Extensions.Memory)

## Description

Extensions for representing integers as memory

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[System.Memory](https://github.com/CDorst/DevOps.Code.DataAccess.Metapackages.ApiControllers) | [![NuGet package status](https://img.shields.io/nuget/v/System.Memory.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/System.Memory)

## NuGet

This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.Common.Extensions.Memory](https://www.nuget.org/packages/CDorst.Common.Extensions.Memory)

## Version

1.2.0-rc1

## Usage Notes

Use the `Int16ByteMap`, `Int32ByteMap`, and `Int64ByteMap` `readonly ref struct` types to project integer values as collections of bytes.

```csharp
// Retrieve bytes at specified position
var firstByteOfFourByteInteger = new Int32ByteMap(5000).Byte0;
var thirdByteOfFourByteInteger = new Int32ByteMap(5000).Byte2;

// Retrieve readonly memory reference to integer as byte[]
var allEightBytesOf64BitIntegerAsSpan = new Int64ByteMap(long.MinValue).AsReadOnlySpan();
```

Use the static `IntegerByteMapper` class as convenience methods for `new Int{size}ByteMap({value})` syntax

```csharp
using static Common.Extensions.Memory.IntegerByteMapper;

var intBytes = Map(int.MaxValue).AsReadOnlySpan();
var shortBytes = Map(short.MaxValue).AsReadOnlySpan();
var longBytes = Map(long.MaxValue).AsReadOnlySpan();
```

Use the static `IntegerSpanExtensions` class as convenient extension methods for `IntegerByteMapper.Map({value})` syntax

```csharp
using Common.Extensions.Memory;

var intBytes = int.MaxValue.ToSpan();
var shortBytes = short.MaxValue.ToSpan();
var longBytes = long.MaxValue.ToSpan();
```

Use the static `IntegerReadOnlySpanByteMapMapper` class to concatenate integer byte-maps as memory

```csharp
using static Common.Extensions.Memory.IntegerReadOnlySpanByteMapMapper;

var fifteenBytes = GetSpan(
    byte.MaxValue, /* 1 byte */
    new Int16ByteMap(short.MaxValue), /* 2 bytes */
    new Int32ByteMap(int.MaxValue), /* 4 bytes */
    new Int64ByteMap(long.MaxValue) /* 8 bytes */); //  1+2+4+8 = 15
```

Use the static `IntegerReadOnlySpanMapper` class to concatenate integers as memory

```csharp
using static Common.Extensions.Memory.IntegerReadOnlySpanMapper;

var fifteenBytes = MapSpan(
    byte.MaxValue, /* 1 byte */
    short.MaxValue, /* 2 bytes */
    int.MaxValue, /* 4 bytes */
    long.MaxValue /* 8 bytes */); //  1+2+4+8 = 15
```

Use the `IntegerReadOnlyMemoryByteMapMapper.GetMemory` and `IntegerReadOnlyMemoryMapper.MapMemory` APIs similarly to their `Span` counterparts whenever `ReadOnlyMemory<byte>` is preferred over `ReadOnlySpan<byte>`.

```csharp
using static Common.Extensions.Memory.IntegerReadOnlyMemoryMapper;
var memory = MapMemory(
	int.MaxValue, 
	short.MaxValue, 
	short.MaxValue, 
	long.MaxValue);

[Flags] enum FlagsByte : byte { Foo, Bar }
class MyEntityType
{
    public int PrimaryKey { get; set; }
    public short ForeignKey1 { get; set; }
    public long ForeignKey2 { get; set; }
    public int ForeignKey3 { get; set; }
    public FlagsByte Flags { get; set; }

    public ReadOnlyMemory<byte> GetHttpApiBytesPayload()
        => MapMemory(ForeignKey1, ForeignKey2, ForeignKey3, (byte)Flags);
}
```
