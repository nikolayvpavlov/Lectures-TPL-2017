using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace GrayscaleDemo
{
    public partial class MainForm : Form
    {
        CancellationTokenSource ctSource;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ThreadGrayscale(object tag)
        {
            var parameters = (GrayscaleParams)tag;
            Bitmap source = new Bitmap(parameters.FileName);
            Action<int> reportProgress = percent =>
            {
                progressBar.Value = percent;
            };

            Bitmap grayImage = ImageLib.ToGrayscale(
                source,
                parameters.Token,
                p => Invoke (reportProgress, p)
                );

            Action displayAction = () =>
            {
                pictureBox.Image = grayImage;
            };
            this.Invoke(displayAction);
        }

        private void ButtonOpenImage_Click(object sender, EventArgs e)
        {
            if (dlgOpenImage.ShowDialog() != DialogResult.OK) return;
            ctSource = new CancellationTokenSource();
            Thread thread = new Thread(ThreadGrayscale);
            thread.Start(new GrayscaleParams()
                {
                    FileName = dlgOpenImage.FileName,
                    Token = ctSource.Token
                });
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            ctSource.Cancel();
        }
    }
}
