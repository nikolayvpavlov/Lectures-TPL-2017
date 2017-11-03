using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AsyncPatterWinForms
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

        private void bBlock_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SqlCommand(DummyCommand, conn);
                cmd.ExecuteNonQuery();
                lResult.Text = "Here is your data, sir.";
            }
        }

        private SqlCommand asyncCmd;
        private SqlConnection asyncConn;

        private void AsyncCallCompleted(IAsyncResult ar)
        {
            asyncCmd.EndExecuteNonQuery(ar);
            asyncConn.Close();
            Invoke ((Action) ( () => lResult.Text = "Here is your data, sir."));
        }

        private void bAsync_Click(object sender, EventArgs e)
        {
            asyncConn = new SqlConnection(ConnectionString);
            asyncConn.Open();
            asyncCmd = new SqlCommand(DummyCommand, asyncConn);
            asyncCmd.BeginExecuteNonQuery(AsyncCallCompleted, null);
        }
    }
}
