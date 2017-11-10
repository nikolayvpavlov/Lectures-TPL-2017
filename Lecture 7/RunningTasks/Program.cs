using System;
using System.Threading.Tasks;

namespace RunningTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = new Task(() => Console.WriteLine("Hi from Task!"));
            t.Start();

            Task t2 = Task.Factory.StartNew(
                () => Console.WriteLine("Hi from Task")
                );

            Task t3 = Task.Run(() => Console.WriteLine("Hi from Task"));


        }
    }
}
