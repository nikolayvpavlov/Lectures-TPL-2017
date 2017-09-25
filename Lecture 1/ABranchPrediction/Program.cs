using System;
using System.Diagnostics;

class Program
{
    static int dataSize = 10_000_000;
    static int[] data;

    static void GenerateData()
    {
        data = new int[dataSize];
        Random rand = new Random();
        for (int i = 0; i < dataSize; i++)
        {
            data[i] = rand.Next(10);
        }
    }

    static int CountLess(int boundary)
    {
        int result = 0;
        for (int i = 0; i < dataSize; i++)
        {
            if (data[i] < boundary) result++;
            #region Alternative
            //result = result - ((data[i] - boundary) >> 31);
            #endregion
        }
        return result;
    }

    static void Main(string[] args)
    {
        GenerateData();
        Stopwatch watch = new Stopwatch();
        for (int i = 0; i < 11; i++)
        {
            watch.Restart();
            var ops = CountLess(i);
            watch.Stop();
            Console.WriteLine($"{i,2}. Count: {ops,8}, Time: {watch.ElapsedTicks,7}");
        }
        Console.WriteLine("Ready");
        Console.ReadLine();
    }
}
