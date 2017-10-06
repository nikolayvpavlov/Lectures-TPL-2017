using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace ParallelSorting
{
    class Program
    {
        static int[] Data;
        static int[][] SubData;

        static void GenerateData()
        {
            Random rand = new Random();
            Data = Enumerable.Repeat(0, 60000).Select(i => rand.Next(1000)).ToArray();
        }

        static void ThreadWorker(object array)
        {
            int[] data = (int[])array;
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
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Prepare data...");
            GenerateData();

            //Console.WriteLine("Sorting...");
            //var watch = new Stopwatch();
            //watch.Start();

            //var t = new Thread(ThreadWorker);
            //t.Start(Data);
            //t.Join();

            //watch.Stop();
            //Console.WriteLine("Ready. Duration: " + watch.ElapsedMilliseconds / 1000);

            var watch = new Stopwatch();
            watch.Start();

            SplitData();

            List<Thread> workers = new List<Thread>();
            foreach (var sd in SubData)
            {
                var t = new Thread(ThreadWorker);
                t.Start(sd);
                workers.Add(t);
            }
            foreach (var w in workers) w.Join();
            Merge();


            watch.Stop();
            Console.WriteLine("Ready. Duration: " + watch.ElapsedMilliseconds / 1000);
            Console.ReadLine();
        }

        private static void SplitData()
        {
            int N = 4;
            int subSize = Data.Length / N;
            int startIndex = 0;
            SubData = new int[N][];
            for (int i = 0; i < N - 1; i++)
            {
                SubData[i] = new int[subSize];
                Array.Copy(Data, startIndex, SubData[i], 0, subSize);
                startIndex = startIndex + subSize;
            }
            int lastSubSize = Data.Length - subSize * (N - 1);
            SubData[N - 1] = new int[lastSubSize];
            Array.Copy(Data, startIndex, SubData[N - 1], 0, lastSubSize);
        }


        static int GetIndexOfMin(int[] subIndexes)
        {
            int result = -1;
            int min = Int32.MaxValue;
            for (int i = 0; i < SubData.Length; i++)
            {
                int currentSubIndex = subIndexes[i];
                if (currentSubIndex >= SubData[i].Length) continue;
                if (SubData[i][currentSubIndex] < min)
                {
                    result = i;
                    min = SubData[i][currentSubIndex];
                }
            }
            return result;
        }
        static void Merge()
        {
            int[] subIndexes = Enumerable.Repeat(0, SubData.Length).ToArray();

            int outIndex = 0;
            while (outIndex < Data.Length)
            {
                int subIndexToUse = GetIndexOfMin(subIndexes);
                int i = subIndexes[subIndexToUse];
                Data[outIndex] = SubData[subIndexToUse][i];
                subIndexes[subIndexToUse]++;

                outIndex++;
            }
        }
    }
}
