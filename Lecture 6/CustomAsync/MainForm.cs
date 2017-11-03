using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomAsync
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void ButtonSimple_Click(object sender, EventArgs e)
        {
            ButtonSimple.Enabled = false;
            progressBar.Style = ProgressBarStyle.Marquee;

            var worker = new MyWorker();
            await worker.DoSomethingAsync();

            progressBar.Style = ProgressBarStyle.Blocks;
            ButtonSimple.Enabled = true;
        }

        private async void bGetResult_Click(object sender, EventArgs e)
        {
            var worker = new MyWorker();

            string result;
            result = await worker.GetAnswerAsync();

            int randomSum =
                await worker.GetRandomNumberAsync()
                +
                await worker.GetRandomNumberAsync();

            MessageBox.Show(result);
        }

        private async void ButtonFaulty_Click(object sender, EventArgs e)
        {
            try
            {
                var worker = new MyWorker();
                await worker.FaultyMethod();
            }
            catch (MyWorkerException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var worker = new MyWorker();
            worker.NEVER_DO_THIS();
            MessageBox.Show("NEVER returned.");
        }
    }
}
