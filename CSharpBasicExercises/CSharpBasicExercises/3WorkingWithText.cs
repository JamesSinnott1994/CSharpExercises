using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicExercises
{
	class WorkingWithText
	{
		/*
		 * 1- Write a program and ask the user to enter a few numbers separated by a hyphen. 
		 * Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
		 * display a message: "Consecutive"; otherwise, display "Not Consecutive".
		 */
		public static void DetermineConsectivity() {
			Console.WriteLine("Please enter numbers separated by a hyphen");
			var input = Console.ReadLine().Split('-');

			var numbers = new List<int>();
			foreach (string number in input) {
				numbers.Add(int.Parse(number));
			}

			bool consecutive = true;
			int lastNumber = 0;
			for (int i = 1; i < numbers.Count; i++) {
				if (Math.Abs(numbers[i] - numbers[i - 1]) == 1)
				{
					continue;
				}
				else
				{
					consecutive = false;
					break;
				}
			}

			if (consecutive)
				Console.WriteLine("Consecutive");
			else
				Console.WriteLine("Not Consecutive");
		}

		/*
		 * 2- Write a program and ask the user to enter a few numbers separated by a hyphen. 
		 * If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. 
		 * If so, display "Duplicate" on the console.
		 */
		public static void CheckForDuplicates() 
		{
			bool exit = false;
			Console.WriteLine("Please enter numbers separated by a hyphen");
			var input = Console.ReadLine();

			while (!exit)
            {
				Console.WriteLine("Continue");
				if (string.IsNullOrEmpty(input)) // Check for Enter
				{
					Console.WriteLine("Exit");
					exit = true;
				} else
                {
					var numbersSplit = input.Split('-'); // [1,2,4,4]
					for (int i = 1; i < numbersSplit.Length; i++)
                    {
						if (numbersSplit[i].Equals(numbersSplit[i-1]))
                        {
                            Console.WriteLine("Duplicate");
							exit = true;

                        }
                    }
					Console.WriteLine("No Duplicates");
					exit = true;
                }


			}
		}


		/*
		 * 3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
		 * 
		 * A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
		 * If the user doesn't provide any values, consider it as invalid time.
		 */
		public static void CheckTimeValidity()
		{
		}

		/*
		 * 4- Write a program and ask the user to enter a few words separated by a space. 
		 * Use the words to create a variable name with PascalCase. 
		 * For example, if the user types: "number of students", display "NumberOfStudents". 
		 * Make sure that the program is not dependent on the input. 
		 * So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
		 */
		public static void MakeInputPascalCase()
		{
			Console.WriteLine("Please enter a fews words separated by a space");
			var input = Console.ReadLine().Trim().Split(' ');

			StringBuilder combinedWord = new StringBuilder("");
			for (int i = 0; i < input.Length; i++)
            {
				string firstLetter = input[i].Substring(0, 1);
				string restOfWord = input[i].Substring(1);

				firstLetter = firstLetter.ToUpper();
				restOfWord = restOfWord.ToLower();

				combinedWord.Append(firstLetter).Append(restOfWord);
			}

            Console.WriteLine(combinedWord);
		}

		/*
		 * 5- Write a program and ask the user to enter an English word. 
		 * Count the number of vowels (a, e, o, u, i) in the word. 
		 * So, if the user enters "inadequate", the program should display 6 on the console.
		 */
		public static void CountVowels()
		{
            Console.WriteLine("Please enter a word in English");
			string word = Console.ReadLine();

			int noOfVowels = 0;
			foreach (char c in word)
            {
				if (c.Equals('a') || c.Equals('e') || c.Equals('o') || c.Equals('u') || c.Equals('i')) {
					noOfVowels++;
				}
            }
            Console.WriteLine(noOfVowels);
		}
	}
}
