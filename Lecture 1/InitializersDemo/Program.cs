using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitializersDemo
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = new List<string>();
            text.Add("One");
            text.Add("Two");

            var anotherText = new List<string>()
            {
                "The", "Quick", "Brown", "Fox"
            };

            var p = new Person() { Name = "Ivan", Age=20 };


        }
    }
}
