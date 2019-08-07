using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Text;

namespace StringPerformances
{
    /*class Program
    {
        static void Main(string[] args)
        {
            StringBuilder x = new StringBuilder();
            string a, b;
            var watch = new Stopwatch();
            watch.Start();
            for(int i=0; i<1000; i++)
            {
                a = "Hello";
                b = "World !";
                a = a + b;
            }

            Console.WriteLine($"Time taken by string {watch.ElapsedTicks}");
            a = "Hello";
            watch.Reset();
            watch.Start();
            for(int i=0; i<1000; i++)
            {
                x.Append("Hey");
                x.Append(a);
            }
                
            
            Console.WriteLine($"Time taken by string builder {watch.ElapsedTicks}");
            watch.Stop();
        }
    }*/
}
