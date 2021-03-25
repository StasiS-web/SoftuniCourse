using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string tryPass = Console.ReadLine();

            while(tryPass != password)
            {
                tryPass = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
