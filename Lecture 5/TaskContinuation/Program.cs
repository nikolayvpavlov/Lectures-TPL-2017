using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TaskContinuation
{
    class Program
    {
        static Random rand = new Random();
        static int GenerateNumber()
        {
            Console.WriteLine($"T1 thread id: {Thread.CurrentThread.ManagedThreadId}.");
            return rand.Next(1000);
        }

        static int ProcessNumber(Task<int> priorTask)
        {
            Console.WriteLine($"T2 thread id: {Thread.CurrentThread.ManagedThreadId}.");
            int n = priorTask.Result;
            return n * n;
        }

        static string FinalizeProcess (Task<int> priorTask)
        {
            Console.WriteLine($"T3 thread id: {Thread.CurrentThread.ManagedThreadId}.");
            return $"And the result is: {priorTask.Result}!"; 
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Main thread id: {Thread.CurrentThread.ManagedThreadId}.");

            var t1 = new Task<int>(GenerateNumber);

            var t2 = t1.ContinueWith<int>(ProcessNumber);

            var t3 = t2.ContinueWith<string>(FinalizeProcess);

            t1.Start();
            Console.WriteLine("Wait for all work to finish...");
            t3.Wait();
            Console.WriteLine(t3.Result);

            Console.ReadLine();
        }
    }
}
