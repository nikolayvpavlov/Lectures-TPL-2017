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

namespace GuiThreads
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ThreadWisdom()
        {
            var wisdom = new ServiceWisdom();
            var answer = wisdom.GetTheUltimateAnswer();
            Action displayAction =
                () =>
                {
                    LabelOutput.Text = answer;
                    ButtonDoSmthBad.Enabled = false;
                };
            Invoke(displayAction);
        }

        private void ButtonDoSmthBad_Click(object sender, EventArgs e)
        {
            ButtonDoSmthBad.Enabled = false;
            Thread thread = new Thread(ThreadWisdom);
            thread.Start();
        }
    }
}
