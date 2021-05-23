using System;
using System.Collections.Generic;
using System.Linq;

namespace _05PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            //Queue<int> queueNum = new Queue<int>(numbers);
            Queue<int> evenNum = new Queue<int>();

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                   
                    evenNum.Enqueue(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(", ", evenNum));
        }
    }
}
