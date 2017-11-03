using System;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    class Program
    {
        const string ConnectionString =
            "Server=NIKI-LAPTOP;Integrated security=True;Database=Northwind";
        const string DummyCommand =
            "WAITFOR DELAY '00:00:01.000';";

        static async Task CallDatabase()
        {
            var conn = new SqlConnection(ConnectionString);
            conn.Open();
            var cmd = new SqlCommand(DummyCommand, conn);

            Console.WriteLine($"Thread id: {Thread.CurrentThread.ManagedThreadId}.");

            Console.WriteLine("Begin async execution...");

            await cmd.ExecuteNonQueryAsync();

            Console.WriteLine("Async execution completed.");
            Console.WriteLine($"Thread id: {Thread.CurrentThread.ManagedThreadId}.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Main thread id: {Thread.CurrentThread.ManagedThreadId}.");

            Task t = CallDatabase();
            t.Wait();

            Console.WriteLine("Press ENTER to quit.");
            Console.ReadLine();
        }
    }
}
