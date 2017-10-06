using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class Program
    {
        delegate void SimpleDelegate();

        static void DoSimple()
        {
            Console.WriteLine("Simple method.");
        }

        static int b;

        static bool IsGreaterThanX(int n)
        {
            return n > b;
        }

        static void Main(string[] args)
        {
            SimpleDelegate d = DoSimple;

            d();

            List<int> numbers = Enumerable.Range(0, 10).ToList();

            

            Console.WriteLine("Enter a boundary:");
            int boundary = Int32.Parse(Console.ReadLine());
            b = boundary;

            Predicate<int> p = IsGreaterThanX;
            numbers.Find(p);

            var i = numbers.Find(n => n > boundary);
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
