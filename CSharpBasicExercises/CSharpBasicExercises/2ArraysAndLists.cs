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
    }
}
