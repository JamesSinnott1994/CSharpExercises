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
	}
}
