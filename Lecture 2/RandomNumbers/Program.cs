using System;
using System.Linq;
using System.Threading;

namespace RandomNumbers
{
    class Program
    {
        static int[] Data;

        static bool[] Completed;

        static Random Rand = new Random();

        static void Generator(object data)
        {
            int index = (int)data;
            var num = Rand.Next(10);
            Data[index] = num;
            Completed[index] = true;
        }

        static void Main(string[] args)
        {
            int N = 5;

            Data = Enumerable.Repeat(0, N).ToArray();
            Completed = Enumerable.Repeat(false, N).ToArray();

            for (int i = 0; i < N; i++)
            {
                var t = new Thread(Generator);
                t.Start(i);
            }

            while (Completed.Any(item => !item));

            foreach (var n in Data) Console.WriteLine(n);

            Console.WriteLine("Total: " + Data.Sum());
            Console.ReadLine();
        }
    }
}
