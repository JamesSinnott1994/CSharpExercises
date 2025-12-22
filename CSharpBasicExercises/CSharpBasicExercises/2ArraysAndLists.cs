using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
    class ArraysAndLists
    {
        /*
         * Write a program and continuously ask the user to enter different names, 
         * until the user presses Enter (without supplying a name). 
         * Depending on the number of names provided, display a message based on the above pattern.
        */
        public static void DisplayFriendLikes() 
        {
            bool closed = false;
            List<string> friends = new List<string>();
            while (!closed)
            {
                string name = Console.ReadLine();
                if (name.Equals(""))
                    closed = true;
                else 
                {
                    friends.Add(name);
                }
                Console.WriteLine(DisplayMessage(friends));
            }
        }

        public static string DisplayMessage(List<string> friends) 
        {
            string message = "";
            if (friends.Count == 1) {
                message = friends[0] + " likes your post.";
            }
            else if (friends.Count == 2)
            {
                message = friends[0] + ", " + friends[1] + " likes your post.";
            }
            else if (friends.Count > 2)
            {
                message = friends[0] + ", " + friends[1] + " and " + (friends.Count - 2) + " others like your post";
            }
            return message;
        }

        /*
         * 2- Write a program and ask the user to enter their name. 
         * Use an array to reverse the name and then store the result in a new string. 
         * Display the reversed name on the console.
        */
        public static void ReverseName() {
            string name = Console.ReadLine();
            string reversedName = "";

            for (int i = name.Length - 1; i >= 0; i--)
            {
                // James, L = 5
                reversedName += name[i];
            }

            Console.WriteLine(reversedName);
        }

        /*
         * 3- Write a program and ask the user to enter 5 numbers. 
         * If a number has been previously entered, display an error message and ask the user to re-try. 
         * Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
         */
        public static void EnterUniqueNumbers() {
            Console.WriteLine("Please enter five numbers");

            int count = 0;
            List<int> numbers = new List<int>();

            while (count < 5)
            {
                Console.WriteLine("Please enter a number");
                int number = int.Parse(Console.ReadLine());

                if (numbers.Contains(number)) {
                    Console.WriteLine("Error: Please enter a number not already entered");
                    continue;
                }
                numbers.Add(number);

                count++;
            }

            numbers.Sort();
            
            foreach (int number in numbers) {
                Console.WriteLine(number);
            }
        }

        /*
         * 4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
         * The list of numbers may include duplicates. Display the unique numbers that the user has entered.
         */
        public static void DisplayUniqueNumbers() {
            var numbers = new List<int>();
            bool quit = false;

            while (!quit) {
                var input = Console.ReadLine();

                if (input.Equals("Quit"))
                {
                    quit = true;
                    break;
                }

                int number = int.Parse(input);
                numbers.Add(number);

                var distinctNumbers = numbers.Distinct();

                foreach (var num in distinctNumbers) {
                    Console.WriteLine(num);
                }
				Console.WriteLine("--------------------");
            }


        }



    }
}
