using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigatingParallel
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "abcdefghijklmnopqrstuvwxyz";

            var res = Parallel.For(0, text.Length,
                (index, state) =>
                {
                    Console.WriteLine(text[index] + " at index: " + index);
                    if (index == 10)
                    {
                        state.Break();
                    } 
                });

            Console.WriteLine();
            Console.WriteLine("Press ENTER to quit");
            Console.ReadLine();
        }
    }
}
