using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateExercises
{
    class DbCommand
    {
        public DbConnection Connection { get; private set; }
        public String Instruction { get; private set; }
        public DbCommand(DbConnection connection, String instruction) {
            if (connection == null)
                throw new InvalidOperationException("Connection string must be valid");

            if (instruction == null || instruction.Equals(""))
                throw new InvalidOperationException("Instruction must be valid");

            Connection = connection;
            Instruction = instruction;
        }

        public void Execute() {

            // Open the connection
            Connection.OpenConnection();

            // Run the instruction
            Console.WriteLine(Instruction);

            // Close the connection
            Connection.CloseConnection();

        }
    }
}
