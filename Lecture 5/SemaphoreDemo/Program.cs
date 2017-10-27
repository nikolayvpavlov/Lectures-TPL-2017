using System;
using System.Threading;

namespace SemaphoreDemo
{
    class Program
    {
        static Semaphore semaphore;

        static void Visitor(object name)
        {
            Console.WriteLine($"{name} tries to enter Da Club.");
            semaphore.WaitOne();
            Console.WriteLine($"{name} enters Da Club.");
            Thread.Sleep(2000);
            Console.WriteLine($"{name} goes home.");
            semaphore.Release();
        }

        static void Main(string[] args)
        {
            semaphore = new Semaphore(5, 5);
            int numberOfVisitors = 20;
            for (int i = 0; i < numberOfVisitors; i++)
            {
                Thread t = new Thread(Visitor);
                t.Start(i);
            }
        }
    }
}
