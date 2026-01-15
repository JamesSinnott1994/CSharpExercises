using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateExercises
{
    abstract class DbConnection
    {
        public String ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(String connectionString) {

            if (connectionString == null || connectionString.Equals(""))
                throw new InvalidOperationException("Connection string must be valid");

            this.ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Closed();
    }
}
