using System;
using System.Diagnostics;

namespace LoopPerformances
{
    public class PerformanceForLoop
    {
        public static void Main(string[] args)
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


        }


    }
}


