using System;

namespace _06ReplaceRepeatingCharsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //go through all the symbols
            for(int i = 0; i < input.Length - 1; i++)
            {
                char current = input[i];  //get current symbol
                char next = input[i + 1];  //get next symbol

                //check if symbols are the same
                if (current == next)
                {//replace repeating chars with single corresponding letter
                    input = input.Remove(i, 1);
                    i--;
                }
            }

            Console.WriteLine(input);
        }
    }
}
