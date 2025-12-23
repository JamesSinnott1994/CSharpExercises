using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpBasicExercises
{
	class WorkingWithFiles
	{
		/*
		 * 1- Write a program that reads a text file and displays the number of words.
		 */
		public static void DisplayNumberOfWordsFromFile() {
			//string path = "C:Users\JamesSinnott\source\repos\CSharpExercises\CSharpBasicExercises\CSharpBasicExercises\TextFile.txt";
			string text = File.ReadAllText("C:/Users/JamesSinnott/source/repos/CSharpExercises/CSharpBasicExercises/CSharpBasicExercises/TextFile.txt");
            Console.WriteLine(text.Split().Length);
		}

		/*
		 * 2- Write a program that reads a text file and displays the longest word in the file.
		 */
		public static void DisplayLongestWordFromFile()
		{

		}
	}
}
