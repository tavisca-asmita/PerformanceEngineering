using System;
using System.Diagnostics;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Reports;

namespace LoopPerformances
{
    public class PerformanceForLoop
    {

        [Benchmark]
        public static void Main(string[] args)
        {           
            
            var newCheck = new NewCheck();

            bool i = newCheck.LoopChecks();
            var benchmark = BenchmarkRunner.Run<NewCheck>().BenchmarksCases;

            var x = benchmark.ToString();
            //var reports = benchmark.Reports.OfType<bool>();
            //var report = benchmark.Reports;
            //reports.ToString();
            
            
        }
    }

    public class NewCheck
    {
        [Benchmark]
        public bool LoopChecks()
        {
            var watch = new Stopwatch();
            int sum = 0;
            var numberArray = new int[1000];
            for (int i = 0; i < 1000; i++)
                numberArray[i] = i + 1;

            watch.Start();
            for (int i = 0; i < 1000; i++)
                sum += numberArray[i];

            Console.WriteLine($"Sum of array is {sum}");
            Console.WriteLine($"Time taken by For loop is {watch.ElapsedTicks}");

            sum = 0;
            watch.Reset();
            watch.Start();
            foreach (var num in numberArray)
                sum += num;

            Console.WriteLine($"Sum of array is {sum}");
            Console.WriteLine($"Time taken by ForEach loop is {watch.ElapsedTicks}");

            watch.Stop();
            return true;

        }


    }
}


