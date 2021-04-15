using System;

namespace _05DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int line = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < line; i++)
            {
                char currentSymbol = char.Parse(Console.ReadLine());

               message += (char)(currentSymbol + key);
            }

            Console.WriteLine(message);
        }
    }
}
