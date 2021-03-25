using System;
using System.Text;

namespace _02RepeatStringsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //get arrays
            string[] input = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //initilize string builder
            StringBuilder result = new StringBuilder();

            //go through each element in the array
            foreach (string word in input)
            {
                //find the length of the current word
                for (int i = 0; i < word.Length; i++)
                {
                    result.Append(word);
                }
            }

            Console.WriteLine(result);
        }
    }
}
