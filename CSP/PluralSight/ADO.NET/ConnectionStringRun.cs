using System;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace CSP.PluralSight.ADO.NET
{
    public class ConnectionStringRun
    {
        public static void Run()
        {
            string cs = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DBone;Data Source=DEV8";
            //OleDbConnection conn = new OleDbConnection(cs);

            // When using the SqlConnection class, the Provider=(provider name) should not be used w/in the connection string
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            Console.WriteLine("Connection Established Successfully...");
        }
    }
}
