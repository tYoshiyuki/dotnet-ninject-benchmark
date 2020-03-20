# dotnet-ninject-benchmark
Ninject のベンチマークテスト

## Feature
- .NET Framework
- Ninject
- Microsoft.Extensions.DependencyInjection

## Note
- DIコンテナを生成しインスタンスを取得する
- 30回繰り返し
- 3インスタンスと10インスタンスで比較

|                   Method |         Mean |        Error |       StdDev |
|------------------------- |-------------:|-------------:|-------------:|
|             NinjectLogic | 408,476.4 us |  5,850.64 us |  5,472.69 us |
|          NinjectX10Logic | 413,250.5 us |  4,444.40 us |  3,939.84 us |
|    NinjectLogicWithChild | 750,526.6 us |  8,946.51 us |  8,368.57 us |
| NinjectX10LogicWithChild | 763,375.9 us | 13,042.64 us | 12,200.10 us |
|                MsDiLogic |     144.5 us |      1.74 us |      1.54 us |
|             MsDiX10Logic |     655.0 us |      3.48 us |      3.25 us |