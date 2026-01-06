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
            // StopWatchProgram();
            // PostProgram();
            StackProgram();
        }

        public static void StopWatchProgram() {
            Stopwatch sw = new Stopwatch();

            bool ongoing = true;
            while (ongoing)
            {
                Console.WriteLine("Please type 'start' to start the Stopwatch and 'stop' to end it or 'quit' to end the program \n");
                string input = Console.ReadLine();

                if (input.Equals("start"))
                {
                    if (sw.Started == true)
                    {
                        throw new InvalidOperationException("The stopwatch has already been started.");
                    }
                    sw.Start();
                }
                else if (input.Equals("stop"))
                {
                    sw.Stop();
                }
                else if (input.Equals("quit"))
                {
                    ongoing = false;
                }
            }
        }

        public static void PostProgram() {
            string title = "How to create a post in C#";
            string description = "An exericse in the C# Intermediate course...";
            Post post = new Post(title, description);

            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.UpVote();

            Console.WriteLine("Current post vote value is: " + post.Vote);
            post.Info();
        }

        public static void StackProgram() {

            Stack stack = new Stack();

            stack.Push(1);
            stack.Push("James");
            stack.Push("Martin");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }
    }
}
