using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResponsiveUIDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ThreadNetworkCall()
        {
            try
            {
                var client = new WebClient();
                client.OpenRead("http://80.80.80.1");
                MessageBox.Show("Ready!");
            }
            catch
            {
                MessageBox.Show("Error.");
            }
        }

        private void ButtonCallNetwork_Click(object sender, EventArgs e)
        {
            var thread = new Thread(ThreadNetworkCall);
            thread.Start();
        }
    }
}
