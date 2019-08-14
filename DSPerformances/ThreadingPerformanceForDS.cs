using System;
using System.Diagnostics;
using System.Threading;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;

namespace DSPerformances
{
    
    public class ThreadingPerformanceForDS
    {
        //public BenchmarkDotNet.Reports.BenchmarkReport benchmark;

        [Benchmark]
        public static void Main(string[] args)
        {
            
            Thread thread1 = new Thread(Add); 

            Thread thread2 = new Thread(Addition);

            thread1.Start();
            //thread1.Join();
            thread2.Start();
            thread1.Join();
            //thread2.Join();
        }

        [Benchmark]
        public static void Add()
        {
            var watch = new Stopwatch();
            watch.Start();
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(i);
            Console.WriteLine($"Time in ticks taken by Add {watch.ElapsedTicks}");
            Thread.Sleep(1000);
            Console.WriteLine($"Time in miliseconds taken by Add {watch.ElapsedMilliseconds}");

        }

        [Benchmark]
        public static void Addition()
        {
            var watch = new Stopwatch();
            watch.Start();
            for (int i = 11; i <= 20; i++)
                Console.WriteLine(i);
            Console.WriteLine($"Time in ticks taken by Addition {watch.ElapsedTicks}");
            Thread.Sleep(2000);
            Console.WriteLine($"Time in miliseconds taken by Addition {watch.ElapsedMilliseconds}");

        }
    }
}

