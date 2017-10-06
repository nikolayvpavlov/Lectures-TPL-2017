using System;
using System.Linq;
using System.Threading;

namespace WaitingForCompletion
{
    class Program
    {
        static int[] data;
        static bool isWorking;

        static void GenerateData()
        {
            Random rand = new Random();
            data = Enumerable.Repeat(0, 35000).Select(i => rand.Next(1000)).ToArray();
        }

        static void ThreadWorker()
        {
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[i] > data[j])
                    {
                        int temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
            isWorking = false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Our app starts.");
            GenerateData();

            var thread = new Thread(ThreadWorker);
            thread.Start();
            isWorking = true;
            while (isWorking)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
            Console.WriteLine();

            Console.WriteLine("Press ENTER to quit");
            Console.ReadLine();
        }
    }
}
