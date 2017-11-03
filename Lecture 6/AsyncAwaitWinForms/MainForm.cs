using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitWinForms
{
    public partial class MainForm : Form
    {
        const string ConnectionString =
            "Server=NIKI-LAPTOP;Integrated security=True;Database=Northwind";
        const string DummyCommand =
            "WAITFOR DELAY '00:00:05.000';";

        public MainForm()
        {
            InitializeComponent();
        }

        private async void bCallDb_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                await conn.OpenAsync();
                var cmd = new SqlCommand(DummyCommand, conn);
                progressBar.Style = ProgressBarStyle.Marquee;
                await cmd.ExecuteNonQueryAsync();
                progressBar.Style = ProgressBarStyle.Blocks;
                labelResult.Text = "Here is your data, sir.";
            }
        }
    }
}
