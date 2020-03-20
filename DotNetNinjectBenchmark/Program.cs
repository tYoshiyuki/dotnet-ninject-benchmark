using System;
using BenchmarkDotNet.Running;
using DotNetNinjectBenchmark.Targets;

namespace DotNetNinjectBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Target>();
            Console.ReadKey();
        }
    }
}
