using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateExercises
{
    abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan TimeOut { get; private set; }
        public bool IsOpen { get; protected set; }

        public DbConnection(String connectionString, int seconds) {

            if (connectionString == null || connectionString.Equals(""))
                throw new InvalidOperationException("Connection string must be valid");

            ConnectionString = connectionString;
            TimeOut = TimeSpan.FromSeconds(seconds);
            IsOpen = false;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
