using System;
using System.Diagnostics;
using System.Collections.Generic;

/*namespace DSPerformances
{
    class PerformanceForDS
    {
        static void Main(string[] args)
        {
            int i = 0;
            var watch = new Stopwatch();
            var array = new int[1000];
            var list = new List<int>();

            watch.Start();
            for (i = 0; i < 1000; i++)
                array[i] = i + 1;
            Console.WriteLine($"Time taken by For loop is {watch.ElapsedTicks}");

            watch.Reset();
            watch.Start();
            foreach (var item in list)
                list.Add(i++);
            Console.WriteLine($"Time taken by ForEach loop is {watch.ElapsedTicks}");

        }
    }
}*/
