using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonGetPrimes_Click(object sender, EventArgs e)
        {
            PrimeEngine pe = new PrimeEngine();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var primes = pe.GetPrimeNumbers();
            watch.Stop();
            string s =
                $"Primes count: {primes.Count()} \n" +
                $"Elapsed time: {watch.ElapsedMilliseconds} ms.";
            richTextBox.AppendText(s);
            richTextBox.AppendText("\n\n");
        }

        private void ButtonGetPrimesWithTasks_Click(object sender, EventArgs e)
        {
            PrimeEngine pe = new PrimeEngine();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var primes = pe.GetPrimeNumbers2();
            watch.Stop();
            string s =
                $"Primes count: {primes.Count()} \n" +
                $"Elapsed time (Tasks): {watch.ElapsedMilliseconds} ms.";
            richTextBox.AppendText(s);
            richTextBox.AppendText("\n\n");
        }

        private void ButtonGetPrimesParallel_Click(object sender, EventArgs e)
        {
            PrimeEngine pe = new PrimeEngine();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var primes = pe.GetPrimeNumbersParallel();
            watch.Stop();
            string s =
                $"Primes count: {primes.Count()} \n" +
                $"Elapsed time (Parallel): {watch.ElapsedMilliseconds} ms.";
            richTextBox.AppendText(s);
            richTextBox.AppendText("\n\n");
        }

        private void ButtonPrimesParallelLockless_Click(object sender, EventArgs e)
        {
            PrimeEngine pe = new PrimeEngine();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var primes = pe.GetPrimeNumbersParallelLockless();
            watch.Stop();
            string s =
                $"Primes count: {primes.Count()} \n" +
                $"Elapsed time (Parallel, Lockless): {watch.ElapsedMilliseconds} ms.";
            richTextBox.AppendText(s);
            richTextBox.AppendText("\n\n");
        }
    }
}
