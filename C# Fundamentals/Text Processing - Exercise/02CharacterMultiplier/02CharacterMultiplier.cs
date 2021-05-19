using System;
using System.Collections.Generic;
using System.Linq;

namespace _02CharacterMultiplierExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = Console.ReadLine()
                  .Split(" ")
                  .ToList();

            int sum = SumCharacters(inputs[0], inputs[1]);
            Console.WriteLine(sum);

        }

        //Method which get stings as arguments and return the sum of its's symbols
        static int SumCharacters(string wordOne, string wordTwo)
        {
            int sum = 0;

            //if string one is longer than second one
            if (wordOne.Length > wordTwo.Length)
            {
                //go through all the characters in each string
                for (int i = 0; i < wordTwo.Length; i++)
                {
                    //calculate the character's sum = string1[symbol] * string1[symbol]
                    sum += wordOne[i] * wordTwo[i];
                }

                for (int i = wordTwo.Length; i < wordOne.Length; i++)
                {
                    //calculate the character's sum without multiplying
                    sum += wordOne[i];
                }
            }
            else if (wordOne.Length < wordTwo.Length)
            {  //if string two is longer then the first string
                //go through all the characters in each string
                for (int i = 0; i < wordOne.Length; i++)
                {
                    //calculate the character's sum
                    sum += wordOne[i] * wordTwo[i];
                }

                for (int i = wordOne.Length; i < wordTwo.Length; i++)
                {
                    //calculate the character's sum without multiplying
                    sum += wordTwo[i];
                }
            }
            else
            {
                for (int i = 0; i < wordOne.Length; i++)
                {
                    //calculate the character's sum
                    sum += wordOne[i] * wordTwo[i];
                }
            }

            return sum;
        }
    }
}
