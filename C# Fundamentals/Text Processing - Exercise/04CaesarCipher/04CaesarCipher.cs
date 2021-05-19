using System;

namespace _04CaesarCipherExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string encrypted = string.Empty;

            //go through each all the text
            for (int i = 0; i < text.Length; i++)
            {  //shift each character with 3 position forward
                    char symbol = text[i];
                    encrypted += (char)(symbol + 3);
            }

            Console.WriteLine(encrypted);
        }
    }
}
