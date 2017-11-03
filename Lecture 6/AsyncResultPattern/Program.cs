using System;
using System.Data.SqlClient;
using System.Threading;

namespace AsyncResultPattern
{
    class Program
    {
        const string ConnectionString = 
            "Server=NIKI-LAPTOP;Integrated security=True;Database=Northwind";
        const string DummyCommand =
            "WAITFOR DELAY '00:00:01.000';";

        static void ExecQueryCallback(IAsyncResult result)
        {
            Console.WriteLine("Asynchronous execution completed.");
            Console.WriteLine("Thread id: " + Thread.CurrentThread.ManagedThreadId + ".");

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main thread id: " + Thread.CurrentThread.ManagedThreadId + ".");
            var conn = new SqlConnection(ConnectionString);
            conn.Open();
            using (conn)
            {
                #region sync
                var cmd = new SqlCommand(DummyCommand, conn);
                Console.WriteLine("Execute db cmd synchronously.");
                cmd.ExecuteNonQuery();
                Console.WriteLine("Synchronous execution completed.");

                Console.WriteLine();
                #endregion

                Console.WriteLine("Execute db cmd asynchronously.");
                cmd.BeginExecuteNonQuery(ExecQueryCallback, null);
                Console.WriteLine("I am free to continue!");


                Console.WriteLine("Press ENTER to quit.");
                Console.ReadLine();
            }
        }
    }
}
