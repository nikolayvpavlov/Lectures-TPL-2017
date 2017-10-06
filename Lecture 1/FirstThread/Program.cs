using System;
using System.Threading;

namespace FirstThread
{
    class Program
    {
        static void ThreadWorker()
        {
            Console.WriteLine("Hello from my first thread!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main app started.");

            Thread thread = new Thread(ThreadWorker);
            thread.Start();

            Thread.Sleep(100);
            Console.WriteLine("Press ENTER to quit.");
            
            Console.ReadLine();
        }
    }
}
