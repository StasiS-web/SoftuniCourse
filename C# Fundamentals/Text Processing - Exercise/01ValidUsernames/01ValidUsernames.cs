using System;
using System.Collections.Generic;

namespace _01ValidUsernamesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                          .Split(", ");
            List<string> validUsernames = new List<string>(); //create list with valid usernames

            //go through all usernames
            for (int i = 0; i < usernames.Length; i++)
            {
                string users = usernames[i];
                //check username's length has to be between 3 and 16 characters
                if (users.Length >= 3 && users.Length <= 16)
                {
                    bool validUsername = ValidUser(users);

                    //add valid uername in the list
                    if (validUsername == true)
                    {
                        validUsernames.Add(users);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validUsernames));
        }

        //Boolean Method for validating of username
        public static bool ValidUser(string users)
        {
            //check symbols by go through them
            foreach (var symbol in users)
            {
                //contains only letters, numbers, hyphens and underscores
                if (char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_')
                {
                    continue;
                }
                else
                {  //if characters are different from letters, numbers, hyphens and underscores stop
                    return false;
                }
            }
            return true;
        }
    }
}
