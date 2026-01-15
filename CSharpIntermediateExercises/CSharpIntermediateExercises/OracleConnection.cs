using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateExercises
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString, int seconds)
            : base(connectionString, seconds) { }

        public override void OpenConnection()
        {
            IsOpen = true;
            System.Console.WriteLine("Oracle database connection is now open...");
            System.Console.WriteLine("Connection string: {0}", ConnectionString);
        }

        public override void CloseConnection()
        {
            IsOpen = false;
            System.Console.WriteLine("Oracle database conneciton is now closed...");
        }
    }
}
