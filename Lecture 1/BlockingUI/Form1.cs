using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockingUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonDoSomethingSlow_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            try
            {
                client.OpenRead("http://80.80.80.1");
                MessageBox.Show("Ready!");
            }
            catch
            {
                MessageBox.Show("Some error occured.");
            }
        }
    }
}
