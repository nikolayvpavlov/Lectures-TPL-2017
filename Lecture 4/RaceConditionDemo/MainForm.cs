using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceConditionDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int data;
        private object syncObj = new object();

        private void Race(object tag)
        {
            for (int i = 0; i < 10; i++)
            {
                int localCopy;
                lock (syncObj)
                {
                    data = data + 1;
                    Thread.Sleep(3);
                    data = data - 1;
                    localCopy = data;
                }
                Invoke((Action<object>)(
                    (name) =>
                    {
                        ListBoxOutput.Items.Add($"{name} thread.  Data = {localCopy}");
                    }), tag.ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data = 100;
            ListBoxOutput.Items.Clear();
            Thread t1 = new Thread(Race);
            Thread t2 = new Thread(Race);
            t1.Start("A");
            t2.Start("B");
        }
    }
}
