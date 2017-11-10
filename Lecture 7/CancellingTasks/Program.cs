using System;
using System.Threading;
using System.Threading.Tasks;

namespace CancellingTasks
{
    class Program
    {
        static void SlowWorker (CancellationToken token)
        {
            for (int i = 0; i < 200; i++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("I've been cancelled!");
                    return;
                }
                Thread.Sleep(10);
            }
            Console.WriteLine("Completed!");
        }


        static void Main(string[] args)
        {
            var cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            #region Simple case
            //Task sampleOne = Task.Run(
            //    () =>
            //    {
            //        Console.Write("SampleOne: ");
            //        SlowWorker(token);
            //    });
            //Console.WriteLine();
            #endregion

            #region Continuation
            var t1 = Task.Factory.StartNew(
                () =>
                {
                    Console.Write("1: ");
                    SlowWorker(token);
                }, token);
            var finalTask = t1
                .ContinueWith((previous) =>
                 {
                     Console.Write("2: ");
                     SlowWorker(token);
                 },
                 token)
                .ContinueWith((previous) =>
                 {
                     Console.Write("3: ");
                     SlowWorker(token);
                 },
                 token)
                .ContinueWith((previous) =>
                 {
                     Console.WriteLine("Work completed!");
                 },
                 token);
            #endregion

            Thread.Sleep(500);
            cts.Cancel();

            if (finalTask.IsCanceled)
            {
                Console.WriteLine("We stopped everything.");
            }
            else
            {
                finalTask.Wait();
            }




            Console.WriteLine();
            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
