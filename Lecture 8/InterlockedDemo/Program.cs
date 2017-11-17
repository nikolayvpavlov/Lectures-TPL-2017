using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterlockedDemo
{
    class Program
    {
        static int data = 100;

        static void Worker(string name)
        {
            for (int i = 0; i < 20; i++)
            {
                //data++; //Bad.  May not be atomic.
                Interlocked.Add(ref data, 1);
            }
        }
        static void Main(string[] args)
        {
            var t1 = Task.Run(() => Worker("A"));
            var t2 = Task.Run(() => Worker("B"));

            t1.Wait();
            t2.Wait();
            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
