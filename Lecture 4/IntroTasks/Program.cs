using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task simpleTask = new Task(() => Console.WriteLine("Hi from a task!"));
            simpleTask.Start(); //Starts the task in parallel.
            simpleTask.Wait(); //Blocks until the task is completed.

            Task<int> taskWithResult = new Task<int>(
                () => 42);
            taskWithResult.Start();
            //1.
            //int result = taskWithResult.Result; //Blocks until task is completed.
            //Console.WriteLine("Task returned: " + result);

            //2. Spin until task is completed.
            while (!taskWithResult.IsCompleted)
            {
                Console.WriteLine("Wait for the task to complete...");
            }
            Console.WriteLine("Task returned: " + taskWithResult.Result);


            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
