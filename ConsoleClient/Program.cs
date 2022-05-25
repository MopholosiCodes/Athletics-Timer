using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BusinessLayer;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            StopWatch stopwatch = new StopWatch();
            stopwatch.Start();
            Thread.Sleep(5000);
            stopwatch.Stop();

            Console.WriteLine(stopwatch.GetDuration().ToString());
            Console.ReadLine();
        }
    }
}
