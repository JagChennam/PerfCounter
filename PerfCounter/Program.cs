using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PerfCounter
{
    class Program
    {
        static PerformanceCounter processorTimeCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        static PerformanceCounter memoryUsage = new PerformanceCounter("Memory", "Available MBytes");
        static void Main(string[] args)
        {
            //var currentProcess = Process.GetCurrentProcess().ProcessName;
            //PerformanceCounter privateBytes =
            //    new PerformanceCounter(categoryName: "Process", counterName: "Private Bytes", instanceName: currentProcess);
            //PerformanceCounter gen2Collections =
            //    new PerformanceCounter(categoryName: ".NET CLR Memory", counterName: "# Gen 2 Collections", instanceName: currentProcess);
            //Console.WriteLine("private bytes = " + privateBytes.NextValue());
            //Console.WriteLine("gen 2 collections = " + gen2Collections.NextValue());
            //Console.WriteLine("---------------------------");
            //var performanceCounterCategories = PerformanceCounterCategory.GetCategories();

            //foreach (PerformanceCounterCategory performanceCounterCategory in performanceCounterCategories)

            //{

            //    Console.WriteLine(performanceCounterCategory.CategoryName);

            //}
            //Console.WriteLine("**********************************");
            //var performanceCounterCategories1 = PerformanceCounterCategory.GetCategories()

            //.FirstOrDefault(category => category.CategoryName == "Processor");

            //var performanceCounters = performanceCounterCategories1.GetCounters("_Total");

            //Console.WriteLine("Displaying performance counters for Processor category:--\n");

            //foreach (PerformanceCounter performanceCounter in performanceCounters)

            //{
            //    Console.WriteLine(performanceCounter.CounterName);

            //}


            //Console.Read();
         
            Console.WriteLine("CPU usage counter: ");
            Console.WriteLine("Category: {0}", processorTimeCounter.CategoryName);
            Console.WriteLine("Instance: {0}", processorTimeCounter.InstanceName);
            Console.WriteLine("Counter name: {0}", processorTimeCounter.CounterName);
            Console.WriteLine("Help text: {0}", processorTimeCounter.CounterHelp);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Memory usage counter: ");
            Console.WriteLine("Category: {0}", memoryUsage.CategoryName);
            Console.WriteLine("Counter name: {0}", memoryUsage.CounterName);
            Console.WriteLine("Help text: {0}", memoryUsage.CounterHelp);
            Console.WriteLine("------------------------------");
            //while (true)
            //{
                Console.WriteLine("CPU value: {0}", processorTimeCounter.NextValue());
                Console.WriteLine("Memory value: {0}", memoryUsage.NextValue());
                Thread.Sleep(3000);

            //}

            string x = DoSomething();
           
            
            Console.ReadLine();

        }

        private static string DoSomething()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("CPU value: {0}", processorTimeCounter.NextValue());
                Console.WriteLine("Memory value: {0}", memoryUsage.NextValue());

            }

                
            return "Done";
        }
    }
}
