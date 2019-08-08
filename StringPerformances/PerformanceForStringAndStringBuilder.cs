using System;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Reports;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Text;

namespace StringPerformances
{
    class PerformanceForStringAndStringBuilder
    {
        static void Main(string[] args)
        {
            NewCheck newCheck = new NewCheck();
            newCheck.Check();
            var benchmark = BenchmarkRunner.Run<NewCheck>();
        }
    }

    public class NewCheck
    {
        [Benchmark]
        public void Check()
        {
            StringBuilder x = new StringBuilder();
            string a = "Hello";
            var watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < 1000; i++)
            {                
                a += "World !";
            }

            Console.WriteLine($"Time taken by string {watch.ElapsedTicks}");
            a = "Hello";
            watch.Reset();
            watch.Start();
            for (int i = 0; i < 1000; i++)
            {
                x.Append("Hey");
                x.Append(a);
            }


            Console.WriteLine($"Time taken by string builder {watch.ElapsedTicks}");
            watch.Stop();
        }
        
    }
}
