using System;
using System.Threading;

namespace AutoResetEventDemo
{
    class Program
    {
        static AutoResetEvent autoEvent = new AutoResetEvent(false);

        static void ThreadMethod()
        {
            Console.WriteLine("Thread started...");
            Console.WriteLine("Wait for the signal...");

            autoEvent.WaitOne();

            Console.WriteLine("Signal received, doing work...");
            Thread.Sleep(1000);
            Console.WriteLine("Work done, thread ends.");
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(ThreadMethod);
            t.Start();
            Console.WriteLine("Preparing work for Thread...");
            Thread.Sleep(1000);
            //Let the thread go!
            autoEvent.Set();
            //Wait for the thread to finish.
            t.Join();
            Console.ReadLine();
        }
    }
}
