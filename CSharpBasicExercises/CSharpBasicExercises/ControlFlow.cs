using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    class ControlFlow
    {
        /*
         1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
        */
        public static int GetNumsDivisibleByThree() {
            var count = 0;
            for (var i = 1; i <= 100; i++) {
                if (i % 3 == 0)
                    count++;
            }
            return count;
        }

        /*
        2 - Write a program and continuously ask the user to enter a number or "ok" to exit. 
        Calculate the sum of all the previously entered numbers and display it on the console.
        */
        public static int GetSumFromUserInput() {
            var sum = 0;
            bool userToContinue = true;

            while (userToContinue)
            {
                Console.WriteLine("Please enter a number or type 'ok' to exit");
                string input = Console.ReadLine();

                if ( input.ToLower().Equals("ok") ) {
                    userToContinue = false;
                } else
                {
                    // Assume validation is ok, unless otherwise stated
                    sum += int.Parse(input);
                }
            }

            return sum;
        }

        /*
        3- Write a program and ask the user to enter a number. 
        Compute the factorial of the number and print it on the console. 
        For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        */
        public static String GetFactorialFromUserInput() {
            Console.WriteLine("Please enter user input");
            string numberAsStr = Console.ReadLine();
            int number = int.Parse(numberAsStr);
            int factorial = number;

            while (number > 1)
            {
                number--;
                factorial *= number;
            }

            String output = numberAsStr + "! " + "= " + factorial;
            return output;
        }
    }
}
