using System;
using System.Collections.Generic;
using System.Linq;

namespace _05PrintEvenNumbers
{
    class PrintEvenNumbersSolution2
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> queueNum = new Queue<int>(numbers);
            Queue<int> evenNum = new Queue<int>();

            foreach(var num in queueNum)
            {
                if (num % 2 == 0)
                {
                   
                    evenNum.Enqueue(num);
                }
            }

            Console.WriteLine(string.Join(", ", evenNum));
        }
    }
}
