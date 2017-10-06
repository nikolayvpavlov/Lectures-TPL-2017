using System;
using System.Collections.Generic;
using System.Threading;

namespace ThreadPriority
{
    class Program
    {
        static bool ShouldRun = true;

        static void ThreadWorker()
        {
            while (ShouldRun) ;
        }

        static void Main(string[] args)
        {
            var threads = new List<Thread>();
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                var t = new Thread(ThreadWorker);
                t.Priority = System.Threading.ThreadPriority.Lowest;
                t.Start();
                threads.Add(t);
            }
            Console.WriteLine("Working, press 'c' to stop.");
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    if (key.KeyChar == 'c')
                    {
                        ShouldRun = false;
                        foreach (var t in threads) t.Join();
                        break;
                    }
                }
            }
        }
    }
}
