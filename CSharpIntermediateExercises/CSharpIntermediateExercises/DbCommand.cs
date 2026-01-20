using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateExercises
{
    class DbCommand
    {
        public DbConnection Connection { get; set; }
        public String Instruction { get; protected set; }
        public DbCommand(DbConnection connection) {
            if (connection == null)
                throw new InvalidOperationException("Connection string must be valid");

            Connection = connection;
        }
    }
}
