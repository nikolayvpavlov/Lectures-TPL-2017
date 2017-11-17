using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentCollectionsDemp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var list = new ConcurrentBag<int>(); //Replace with List to get an exception.
            var t1 = Task.Run(() =>
            {
                while (true) list.Add(rand.Next(100));
            });
            var t2 = Task.Run(() =>
            {
                while (true)
                    if (list.Count > 0) list.TryTake(out int value);
            });


            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
