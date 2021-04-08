using System;

namespace _04ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reverse = string.Empty;

            for (int i = input.Length -1; i > -1; i--)
            {
                reverse += input[i];
            }
            Console.WriteLine(reverse);
        }
    }
}
