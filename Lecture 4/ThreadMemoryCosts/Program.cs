using System;
using System.Collections.Generic;
using System.Threading;

namespace ThreadMemoryCosts
{
    class Program
    {
        static ManualResetEvent signal;

        static void IdleWorker()
        {
            signal.WaitOne();
        }

        static void Main(string[] args)
        {
            signal = new ManualResetEvent(false);
            List<Thread> threads = new List<Thread>();
            while (true)
            {
                try
                {
                    Thread t = new Thread(IdleWorker);
                    t.Start();
                    threads.Add(t);
                    if (threads.Count % 100 == 0)
                    {
                        Console.WriteLine($"Threads created: {threads.Count}. " + 
                            $"Memory consumed: {Environment.WorkingSet / (1024 * 1024)} MB");
                    }
                }
                catch (OutOfMemoryException)
                {
                    Console.WriteLine($"Ran out of memory at {threads.Count} threads.");
                    signal.Set();
                    break;
                }
            }
            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
