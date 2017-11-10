using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProducerConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var scp = new SimpleProducerConsumer();
            var taskConsumer = Task.Run(() => scp.Consumer());
            var taskProducer = Task.Run(() => scp.Producer());
            var secondroducer = Task.Run(() => scp.Producer());

            Console.ReadLine();
        }
    }
}
