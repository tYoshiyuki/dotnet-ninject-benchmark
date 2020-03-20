using BenchmarkDotNet.Attributes;
using DotNetNinjectBenchmark.Classes;
using Microsoft.Extensions.DependencyInjection;
using Ninject;
using Ninject.Extensions.ChildKernel;

namespace DotNetNinjectBenchmark.Targets
{
    public class Target
    {
        private readonly int loopCnt = 30;

        [Benchmark]
        public void NinjectLogic()
        {
            var i = 0;

            while (true)
            {
                var kernel = new StandardKernel();
                kernel.Bind<SampleOne>().ToSelf().InTransientScope();
                kernel.Bind<SampleTwo>().ToSelf().InTransientScope();
                kernel.Bind<SampleThree>().ToSelf().InTransientScope();

                var one = kernel.Get<SampleOne>();
                var two = kernel.Get<SampleTwo>();
                var three = kernel.Get<SampleThree>();

                i++;
                if (i > loopCnt) break;
            }
        }

        [Benchmark]
        public void NinjectX10Logic()
        {
            var i = 0;

            while (true)
            {
                var kernel = new StandardKernel();
                kernel.Bind<SampleOne>().ToSelf().InTransientScope();
                kernel.Bind<SampleTwo>().ToSelf().InTransientScope();
                kernel.Bind<SampleThree>().ToSelf().InTransientScope();
                kernel.Bind<SampleFour>().ToSelf().InTransientScope();
                kernel.Bind<SampleFive>().ToSelf().InTransientScope();
                kernel.Bind<SampleSix>().ToSelf().InTransientScope();
                kernel.Bind<SampleSeven>().ToSelf().InTransientScope();
                kernel.Bind<SampleEight>().ToSelf().InTransientScope();
                kernel.Bind<SampleNine>().ToSelf().InTransientScope();
                kernel.Bind<SampleTen>().ToSelf().InTransientScope();

                var one = kernel.Get<SampleOne>();
                var two = kernel.Get<SampleTwo>();
                var three = kernel.Get<SampleThree>();
                var four = kernel.Get<SampleThree>();
                var five = kernel.Get<SampleThree>();
                var six = kernel.Get<SampleThree>();
                var seven = kernel.Get<SampleThree>();
                var eight = kernel.Get<SampleThree>();
                var nine = kernel.Get<SampleThree>();
                var ten = kernel.Get<SampleThree>();

                i++;
                if (i > loopCnt) break;
            }
        }

        [Benchmark]
        public void NinjectLogicWithChild()
        {
            var i = 0;

            while (true)
            {
                var kernel = new StandardKernel();
                kernel.Bind<SampleOne>().ToSelf().InTransientScope();
                kernel.Bind<SampleTwo>().ToSelf().InTransientScope();
                kernel.Bind<SampleThree>().ToSelf().InTransientScope();

                var child = new ChildKernel(kernel);
                var one = child.Get<SampleOne>();
                var two = child.Get<SampleTwo>();
                var three = child.Get<SampleThree>();

                i++;
                if (i > loopCnt) break;
            }
        }

        [Benchmark]
        public void NinjectX10LogicWithChild()
        {
            var i = 0;

            while (true)
            {
                var kernel = new StandardKernel();
                kernel.Bind<SampleOne>().ToSelf().InTransientScope();
                kernel.Bind<SampleTwo>().ToSelf().InTransientScope();
                kernel.Bind<SampleThree>().ToSelf().InTransientScope();
                kernel.Bind<SampleFour>().ToSelf().InTransientScope();
                kernel.Bind<SampleFive>().ToSelf().InTransientScope();
                kernel.Bind<SampleSix>().ToSelf().InTransientScope();
                kernel.Bind<SampleSeven>().ToSelf().InTransientScope();
                kernel.Bind<SampleEight>().ToSelf().InTransientScope();
                kernel.Bind<SampleNine>().ToSelf().InTransientScope();
                kernel.Bind<SampleTen>().ToSelf().InTransientScope();

                var child = new ChildKernel(kernel);
                var one = child.Get<SampleOne>();
                var two = child.Get<SampleTwo>();
                var three = child.Get<SampleThree>();
                var four = child.Get<SampleThree>();
                var five = child.Get<SampleThree>();
                var six = child.Get<SampleThree>();
                var seven = child.Get<SampleThree>();
                var eight = child.Get<SampleThree>();
                var nine = child.Get<SampleThree>();
                var ten = child.Get<SampleThree>();

                i++;
                if (i > loopCnt) break;
            }
        }



        [Benchmark]
        public void MsDiLogic()
        {
            var i = 0;

            while (true)
            {
                var serviceCollection = new ServiceCollection();
                serviceCollection.AddTransient<SampleOne>();
                serviceCollection.AddTransient<SampleTwo>();
                serviceCollection.AddTransient<SampleThree>();

                var serviceProvider = serviceCollection.BuildServiceProvider();
                var one = serviceProvider.GetService<SampleOne>();
                var two = serviceProvider.GetService<SampleTwo>();
                var three = serviceProvider.GetService<SampleThree>();

                i++;
                if (i > loopCnt) break;
            }

        }

        [Benchmark]
        public void MsDiX10Logic()
        {
            var i = 0;

            while (true)
            {
                var serviceCollection = new ServiceCollection();
                serviceCollection.AddTransient<SampleOne>();
                serviceCollection.AddTransient<SampleTwo>();
                serviceCollection.AddTransient<SampleThree>();
                serviceCollection.AddTransient<SampleFour>();
                serviceCollection.AddTransient<SampleFive>();
                serviceCollection.AddTransient<SampleSix>();
                serviceCollection.AddTransient<SampleSeven>();
                serviceCollection.AddTransient<SampleEight>();
                serviceCollection.AddTransient<SampleNine>();
                serviceCollection.AddTransient<SampleTen>();

                var serviceProvider = serviceCollection.BuildServiceProvider();
                var one = serviceProvider.GetService<SampleOne>();
                var two = serviceProvider.GetService<SampleTwo>();
                var three = serviceProvider.GetService<SampleThree>();
                var four = serviceProvider.GetService<SampleThree>();
                var five = serviceProvider.GetService<SampleThree>();
                var six = serviceProvider.GetService<SampleThree>();
                var seven = serviceProvider.GetService<SampleThree>();
                var eight = serviceProvider.GetService<SampleThree>();
                var nine = serviceProvider.GetService<SampleThree>();
                var ten = serviceProvider.GetService<SampleThree>();

                i++;
                if (i > loopCnt) break;
            }

        }

    }
}
