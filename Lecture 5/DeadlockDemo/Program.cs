using System;
using System.Threading;

namespace DeadlockDemo
{
    class Program
    {
        static object lockOne = new object();
        static object lockTwo = new object();

        static void ThreadMethod()
        {
            Console.WriteLine("Thread started...");
            lock (lockOne)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Entered lockOne...");
                lock (lockTwo)
                {
                    Thread.Sleep(1000);
                }
            }
            Console.WriteLine("Thread ends.");
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(ThreadMethod);
            t.Start();
            Console.WriteLine("Main gets lockTwo");
            lock (lockTwo)
            {
                Thread.Sleep(500);
                Console.WriteLine("Main tries got get lockOne");
                lock (lockOne)
                {
                    Thread.Sleep(1000);
                }
            }
            Console.WriteLine("Main leaves both locks.");

        }
    }
}
