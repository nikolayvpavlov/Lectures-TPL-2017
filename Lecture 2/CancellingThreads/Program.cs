using System;
using System.Threading;

namespace CancellingThreads
{
    class Program
    {
        static bool Completed;

        static bool ShouldStop;

        static void DoSomethingSlow()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                if (ShouldStop)
                {
                    Console.WriteLine("I've been cancelled");
                    return;
                }
            }
            Completed = true;
        }

        static void Main(string[] args)
        {
            var t = new Thread(DoSomethingSlow);
            Completed = false;
            ShouldStop = false;
            t.Start();
            Console.WriteLine("Working...");
            Console.WriteLine("Press 'c' to cancel the operation.");

            while (!Completed)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    if (key.KeyChar == 'c')
                    {
                        ShouldStop = true;
                        t.Join();
                        break;
                    }
                }
            }

            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
        }
    }
}
