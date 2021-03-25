using System;
using System.Linq;

namespace _05OddTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int result = array[0]; //initialize a variable with value 0
            //iterate through all number in the array.
            for (int i = 1; i < array.Length; i++)
            { //XOR result and all numbers in the array
                result = result ^ array[i];
            }

            Console.WriteLine(result);
        }
    }
}
