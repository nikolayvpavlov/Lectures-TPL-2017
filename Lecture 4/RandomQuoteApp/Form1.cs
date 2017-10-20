using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomQuoteApp
{
    public partial class MainForm : Form
    {
        const string QuotesUrl = @"http://nvp-playground.azurewebsites.net/api/quotes/random/txt";
        public MainForm()
        {
            InitializeComponent();
            TimerQuote.Enabled = true;
        }

        private void TimerQuote_Tick(object sender, EventArgs e)
        {
            //The BAD way: create a thread 
            //Thread thread = new Thread(() =>
            //{
            //    WebClient client = new WebClient();
            //    var result = client.DownloadString(QuotesUrl);
            //    Invoke((Action)(() => LabelQuote.Text = result));
            //});
            //thread.Start();

            //The BETTER way: use the threadpool.
            ThreadPool.QueueUserWorkItem(
                state =>
                {
                    WebClient client = new WebClient();
                    var result = client.DownloadString(QuotesUrl);
                    Invoke((Action)(() => LabelQuote.Text = result));
                }
                );
        }
    }
}
