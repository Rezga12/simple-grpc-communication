using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> list = new List<int>();
            var rand = new Random();
            for (int i=0;i<1000000000;i++)
            {
                list.Add(rand.Next());
            }
            
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int max = 0;
            foreach (var v in list)
            {
                if (max < v)
                {
                    max = v;
                }
            }
            watch.Stop();
            var elapsedMsFor = watch.ElapsedMilliseconds;
            
            watch = System.Diagnostics.Stopwatch.StartNew();
            int a = list.Max();
            watch.Stop();
            var elapsedMsLinq = watch.ElapsedMilliseconds;
            Console.WriteLine($"linq: {elapsedMsLinq}, for: {elapsedMsFor}");

        }
    }
}