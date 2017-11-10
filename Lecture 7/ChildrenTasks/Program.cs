using System;
using System.Threading;
using System.Threading.Tasks;

namespace ChildrenTasks
{
    class Program
    {
        static void ParentTask()
        {
            Console.WriteLine("Parent started...");

            var childOne = Task.Factory.StartNew(
                () =>
                {
                    Thread.Sleep(500);
                    Console.WriteLine("I am child 1");
                },
                TaskCreationOptions.AttachedToParent
                );

            var childTwo = Task.Run(
                () =>
                {
                    Thread.Sleep(700);
                    Console.WriteLine("I am child 2");
                }
                );

            Console.WriteLine("Parent did its job.");
        }

        static void Main(string[] args)
        {
            var end = Task.Factory.StartNew(ParentTask)
                .ContinueWith(
                    (previousTask) => 
                    Console.WriteLine("I run after the parent.")
                    );
            
            end.Wait();

            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
