using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateExercises
{
    class SqlConnection : DbConnection
    {
        public SqlConnection()
            : base("SqlConnection") {
            
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
