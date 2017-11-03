using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomAsync
{
    class MyWorkerException : Exception { }

    class MyWorker
    {
        public Task DoSomethingAsync()
        {
            Task t = Task.Factory.StartNew(() => Thread.Sleep(5000));
            return t;
        }

        public Task<string> GetAnswerAsync()
        {
            Task<string> t = Task.Factory.StartNew(() => "The answer is 42!");
            return t;
        }

        private Random rand = new Random();

        public Task<int> GetRandomNumberAsync()
        {
            return Task.Factory.StartNew(() => rand.Next(10));
        }

        public Task FaultyMethod()
        {
            return Task.Factory.StartNew(
                () => throw new MyWorkerException());
        }

        public async Task<int> GetComplex()
        {
            int a = await GetRandomNumberAsync();
            int b = await GetRandomNumberAsync();
            return a + b;
        }

        public async void NEVER_DO_THIS()
        {
            System.Windows.Forms.MessageBox.Show("Step 0");
            int a = await GetRandomNumberAsync().ConfigureAwait(false);
            System.Windows.Forms.MessageBox.Show("Step 1");
            int b = await GetRandomNumberAsync().ConfigureAwait(false);
            System.Windows.Forms.MessageBox.Show("Step 2");
        }
    }
}
