using System;

namespace _05LoginExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            for (int i = username.Length -1; i >= 0; i--)
            {
                password += username[i];
            }

            for (int i = 0; i < 4; i++)
            {
                string currentPassword = Console.ReadLine();

                if (currentPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (password != currentPassword && i >= 0 && i < 3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else if (password != currentPassword && i == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                }
            }
        }
    }
}
