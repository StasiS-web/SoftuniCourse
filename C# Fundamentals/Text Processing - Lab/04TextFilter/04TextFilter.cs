using System;

namespace _04TextFilterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (string bannedWord in bannedWords)
            {
                //replace banned word with symbol
                text = text.Replace(bannedWord, new string('*', bannedWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}
