using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksAndErrors
{
    class Program
    {
        static public string FaultyCode()
        {
            Task.Delay(1000).Wait();
            throw new Exception("Some error occurred.");
        }

        static void Main(string[] args)
        {
            Task<string> t1 = new Task<string>(FaultyCode);
            t1.Start();

            while(!t1.IsCompleted)
            {
                Console.Write(".");
                Task.Delay(100).Wait();
            }
            Console.WriteLine();
            //1. Check status,
            if (t1.IsFaulted)
            {
                Console.WriteLine("Ops! " + t1.Exception.InnerException.Message);
                //Tasks always return their errors in AggregateException.  Check its InnerException for details.
            }

            //2. Just try to get the result.
            //try
            //{
            //    string result = t1.Result; //This will throw now.
            //}
            //catch (AggregateException x)
            //{
            //    Console.WriteLine(x.InnerException.Message);
            //}

            
            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
