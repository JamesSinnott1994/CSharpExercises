using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateExercises
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString, int seconds)
            : base(connectionString, seconds) { }

        public override void OpenConnection()
        {
            IsOpen = true;
            System.Console.WriteLine("SQL database connection is now open...");
            System.Console.WriteLine("Connection string: {0}", ConnectionString);
        }

        public override void CloseConnection()
        {
            IsOpen = false;
            System.Console.WriteLine("SQL database conneciton is now closed...");
        }
    }
}
