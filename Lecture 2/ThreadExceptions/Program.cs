using System;
using System.Threading;

namespace ThreadExceptions
{
    class Program
    {
        static void DoSomethingWithError()
        {
            try
            {
                Console.WriteLine("Thread doing something...");
                Thread.Sleep(3000);
                int a = 5, b = 0;
                int c = a / b;
                Console.WriteLine(c);
            }
            catch
            {
                Console.WriteLine("Some error occurred.");
            }
        }
        static void Main(string[] args)
        {
            var t = new Thread(DoSomethingWithError);
            t.Start();

            Console.WriteLine("Something working here...");
            Console.ReadLine();
        }
    }
}
