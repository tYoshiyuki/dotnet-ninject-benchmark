# dotnet-ninject-benchmark
Ninject のベンチマークテスト

## Feature
- .NET Framework
- Ninject
- Microsoft.Extensions.DependencyInjection

## Note
- DIコンテナを生成しインスタンスを取得する
- 3インスタンスと10インスタンスで比較

- 30回繰り返し

|                   Method |         Mean |        Error |       StdDev |
|------------------------- |-------------:|-------------:|-------------:|
|             NinjectLogic | 408,476.4 us |  5,850.64 us |  5,472.69 us |
|          NinjectX10Logic | 413,250.5 us |  4,444.40 us |  3,939.84 us |
|    NinjectLogicWithChild | 750,526.6 us |  8,946.51 us |  8,368.57 us |
| NinjectX10LogicWithChild | 763,375.9 us | 13,042.64 us | 12,200.10 us |
|                MsDiLogic |     144.5 us |      1.74 us |      1.54 us |
|             MsDiX10Logic |     655.0 us |      3.48 us |      3.25 us |

- 300回繰り返し

|                   Method |          Mean |         Error |        StdDev |
|------------------------- |--------------:|--------------:|--------------:|
|             NinjectLogic |  7,821.678 ms |   484.9649 ms | 1,429.9300 ms |
|          NinjectX10Logic |  9,230.080 ms |   618.1676 ms | 1,822.6812 ms |
|    NinjectLogicWithChild | 18,926.659 ms | 1,041.0251 ms | 3,069.4860 ms |
| NinjectX10LogicWithChild | 19,820.623 ms | 1,132.9167 ms | 3,340.4304 ms |
|                MsDiLogic |      1.419 ms |     0.0210 ms |     0.0196 ms |
|             MsDiX10Logic |      6.427 ms |     0.0250 ms |     0.0234 ms |
