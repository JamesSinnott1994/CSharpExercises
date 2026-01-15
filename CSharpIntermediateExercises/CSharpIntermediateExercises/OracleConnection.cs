using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateExercises
{
    class OracleConnection : DbConnection
    {
        public OracleConnection()
            : base("OracleConnection")
        {

        }

        public override void Open()
        {
            Console.WriteLine("Open connection");
        }

        public override void Closed()
        {
            Console.WriteLine("Close connection");
        }
    }
}
