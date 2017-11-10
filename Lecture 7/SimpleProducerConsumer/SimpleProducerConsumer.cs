using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleProducerConsumer
{
    class SimpleProducerConsumer
    {
        private Queue<string> queue = new Queue<string>();
        private object queueLock = new object();
        private Random rand = new Random();
        private AutoResetEvent signal = new AutoResetEvent(false);

        public void Producer()
        {
            while (true)
            {
                lock (queueLock)
                {
                    queue.Enqueue(rand.Next(10).ToString());
                }
                signal.Set();
                //For simulation:
                Thread.Sleep(rand.Next(200)); //Sleeps for a random interval.
            }
        }

        public void Consumer()
        {
            while (true)
            {
                bool hasData;
                lock (queueLock) //Lock required if we have multiple consumers
                {
                    hasData = queue.Count > 0;
                }
                if (hasData)
                {
                    string item;
                    lock (queueLock)
                    {
                        item = queue.Dequeue();
                    }
                    Console.Write(item + " ");
                    //For simulation purposes.
                    Thread.Sleep(rand.Next(200));
                }
                else
                {
                    signal.WaitOne();
                }
                
            }
        }
    }
}
