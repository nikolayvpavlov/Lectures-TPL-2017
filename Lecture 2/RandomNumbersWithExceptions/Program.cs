using System;
using System.Linq;
using System.Threading;

namespace RandomNumbersWithExceptions
{
    enum Status { Working, Completed, Faulted };
    class Program
    {
        static int[] Data;

        static Status[] Completed;

        static Random Rand = new Random();

        static void Generator(object data)
        {
            int index = (int)data;
            try
            {
                bool raiseHell = Rand.Next(10) > 5;
                if (raiseHell)
                {
                    var up = new Exception("Some error occurred.");
                    throw up;
                }

                var num = Rand.Next(10);
                Data[index] = num;
                Completed[index] = Status.Completed;
            }
            catch
            {
                Completed[index] = Status.Faulted;
            }
        }

        static void Main(string[] args)
        {
            int N = 5;

            Data = Enumerable.Repeat(0, N).ToArray();
            Completed = Enumerable.Repeat(Status.Working, N).ToArray();

            for (int i = 0; i < N; i++)
            {
                var t = new Thread(Generator);
                t.Start(i);
            }

            while (Completed.Any(item => item == Status.Working));

            if (Completed.Any(item => item == Status.Faulted))
            {
                Console.WriteLine("Operation failed.");
            }
            else
            {
                foreach (var n in Data) Console.WriteLine(n);
                Console.WriteLine("Total: " + Data.Sum());
            }
            Console.ReadLine();
        }
    }
}
