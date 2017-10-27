using System;
using System.Threading;

namespace CountdownEventDemo
{
    class Program
    {
        static CountdownEvent countEvent;

        static void ThreadMethod(object id)
        {
            Console.WriteLine($"{id} doing some work...");
            Thread.Sleep(1000);
            Console.WriteLine($"{id} ends.");

            countEvent.Signal();
        }

        static void Main(string[] args)
        {
            countEvent = new CountdownEvent(3);
            for (int i = 1; i <= 3; i++)
            {
                Thread t = new Thread(ThreadMethod);
                t.Start(i);
            }
            countEvent.Wait();

            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
