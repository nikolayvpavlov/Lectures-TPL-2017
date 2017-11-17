using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncMethods
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void bDoWork_Click(object sender, EventArgs e)
        {
            bDoWork.Enabled = false;
            var dp = new DataProcessor();
            await dp.GetSortedData();
            bDoWork.Enabled = true;
        }

        private async void ButtonGetQuote_Click(object sender, EventArgs e)
        {
            SomeClass someClass = new SomeClass();
            Text = await someClass.GetSomeData();
        }
    }
}
