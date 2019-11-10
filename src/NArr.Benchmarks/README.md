# NArr Benchmark Results

### Machine Specifications
```
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
AMD Ryzen 5 2600X, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.0.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  DefaultJob : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
```

### Append
```
|                Method |              Mean |            Error |           StdDev |
|---------------------- |------------------:|-----------------:|-----------------:|
|   AppendSingleElement |          19.29 ns |         0.223 ns |         0.198 ns |
| AppendLargeCollection | 420,710,173.33 ns | 1,919,257.964 ns | 1,795,275.091 ns |
```

### Defragment
```
|             Method |               Mean |            Error |           StdDev |             Median |
|------------------- |-------------------:|-----------------:|-----------------:|-------------------:|
|  FewSmallFragments |           209.7 ns |          4.09 ns |          4.86 ns |           210.5 ns |
| ManySmallFragments |     4,143,565.8 ns |     82,396.68 ns |    128,281.71 ns |     4,146,140.2 ns |
|  FewLargeFragments |       975,339.7 ns |     18,843.72 ns |     21,700.46 ns |       972,296.9 ns |
| ManyLargeFragments | 1,726,073,376.0 ns | 34,124,434.61 ns | 68,933,040.88 ns | 1,760,803,700.0 ns |
```

### Fragment
```
|             Method |             Mean |           Error |          StdDev |
|------------------- |-----------------:|----------------:|----------------:|
|  FewSmallFragments |         489.5 ns |         9.77 ns |        18.82 ns |
| ManySmallFragments |   1,090,552.4 ns |    19,084.82 ns |    17,851.95 ns |
|  FewLargeFragments |     439,442.1 ns |     3,486.74 ns |     3,261.50 ns |
| ManyLargeFragments | 565,265,026.7 ns | 3,806,129.81 ns | 3,560,256.18 ns |
```

### Insert
```
|                        Method |         Mean |       Error |      StdDev |
|------------------------------ |-------------:|------------:|------------:|
| SmallCollectionIntoEmptyArray |     249.2 ns |     5.03 ns |     8.67 ns |
| LargeCollectionIntoEmptyArray |     283.9 ns |     5.33 ns |     4.99 ns |
| SmallCollectionIntoSmallArray |     471.5 ns |     9.25 ns |    10.28 ns |
| LargeCollectionIntoLargeArray | 540,283.8 ns | 2,825.61 ns | 2,359.52 ns |
```

### Move
```
|                      Method |         Mean |       Error |      StdDev |
|---------------------------- |-------------:|------------:|------------:|
| SmallCollectionInSmallArray |     171.1 ns |     3.40 ns |     3.64 ns |
| SmallCollectionInLargeArray | 147,475.6 ns | 2,930.33 ns | 3,257.05 ns |
| LargeCollectionInSmallArray | 135,878.8 ns | 2,506.73 ns | 2,222.15 ns |
```

### Remove
```
|                        Method |         Mean |       Error |      StdDev |
|------------------------------ |-------------:|------------:|------------:|
| SmallCollectionFromSmallArray |     289.2 ns |     5.79 ns |     8.30 ns |
| SmallCollectionFromLargeArray | 116,229.3 ns | 2,296.56 ns | 2,820.38 ns |
| LargeCollectionFromLargeArray |  55,799.6 ns | 1,113.18 ns | 1,859.87 ns |
```

### Resize
```
|                    Method |        Mean |      Error |     StdDev |
|-------------------------- |------------:|-----------:|-----------:|
|   SmallArrayToLargerArray |    28.07 ns |   0.627 ns |   1.640 ns |
| LargerArrayToSmallerArray |    23.98 ns |   0.823 ns |   0.770 ns |
|    SmallArrayToLargeArray | 4,763.04 ns |  50.498 ns |  47.236 ns |
|    LargeArrayToSmallArray | 5,821.59 ns | 109.663 ns | 102.579 ns |
```

### Search
```
|                             Method |     Mean |   Error |  StdDev |
|----------------------------------- |---------:|--------:|--------:|
|                      NoOccurrences | 114.3 ms | 1.64 ms | 1.54 ms |
|                   SingleOccurrence | 116.7 ms | 1.65 ms | 1.54 ms |
|    SingleOccurrenceWithNearMatches | 139.0 ms | 1.76 ms | 1.56 ms |
|                MultipleOccurrences | 136.8 ms | 1.41 ms | 1.25 ms |
| MultipleOccurrencesWithNearMatches | 115.1 ms | 0.77 ms | 0.72 ms |
```

### Select
```
|                   Method |      Mean |     Error |    StdDev |
|------------------------- |----------:|----------:|----------:|
| SmallCollectionFromArray |  7.251 us | 0.1273 us | 0.1307 us |
| LargeCollectionFromArray | 66.489 us | 1.3068 us | 2.6397 us |
```

### Shift
```
|                    Method |         Mean |       Error |      StdDev |
|-------------------------- |-------------:|------------:|------------:|
| PositiveShiftOfSmallArray |     128.8 ns |     2.67 ns |     5.75 ns |
| NegativeShiftOfSmallArray |     130.4 ns |     2.61 ns |     3.74 ns |
| PositiveShiftOfLargeArray | 101,295.3 ns | 1,976.37 ns | 3,409.14 ns |
| NegativeShiftOfLargeArray |  97,040.5 ns | 1,864.70 ns | 2,552.42 ns |
```