using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            bool ongoing = true;
            while (ongoing) {
                Console.WriteLine("Please type 'start' to start the Stopwatch and 'stop' to end it or 'quit' to end the program \n");
                string input = Console.ReadLine();

                if (input.Equals("start"))
                {
                    if (sw.Started == true)
                    {
                        throw new InvalidOperationException("The stopwatch has already been started.");
                    }
                    sw.Start();
                } else if (input.Equals("stop")) {
                    sw.Stop();
                } else if (input.Equals("quit"))
                {
                    ongoing = false;
                }
            }

            
        }
    }
}
