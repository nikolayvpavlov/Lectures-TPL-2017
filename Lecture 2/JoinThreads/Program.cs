using System;
using System.Threading;

namespace JoinThreads
{
    class Program
    {
        static void DoSomething()
        {
            Thread.Sleep(5000);
        }
        static void Main(string[] args)
        {
            var t = new Thread(DoSomething);
            t.Start();
            Console.WriteLine("Work started.   Waiting...");

            t.Join();

            Console.WriteLine("Work completed.");
            Console.ReadLine();
        }
    }
}
