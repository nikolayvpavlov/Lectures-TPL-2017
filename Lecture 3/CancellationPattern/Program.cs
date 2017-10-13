using System;
using System.Threading;

namespace CancellationPattern
{
    class Program
    {
        static void SomeWorker(object tag)
        {
            CancellationToken token = (CancellationToken)tag;
            for (int i = 0; i < 10; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("I've been canceled.");
                    return;
                }
                Thread.Sleep(1000);
            }
            Console.WriteLine("I ran to completion.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Starting a thread.");
            var cts = new CancellationTokenSource();
            Thread t1 = new Thread(SomeWorker);
            t1.Start(cts.Token);

            Console.WriteLine("Do some waiting...");
            Thread.Sleep(4000);
            Console.WriteLine("I changed my mind, I will cancel.");

            cts.Cancel();
            t1.Join();

            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();


        }
    }
}
