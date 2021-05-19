using System;
using System.Collections.Generic;
using System.Linq;

namespace _02BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //queue's parameters
            int enqueue = input[0];
            int dequeue = input[1];
            int item = input[2];

            //elements in the queue
            int[] items = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            Queue<int> numbers = new Queue<int>(items);

            //go through all elements to enquue into the queue
            for (int i = 0; i < enqueue; i++)
            {
                numbers.Enqueue(items[i]);
            }

            //go through all elements to dequeue into the queue
            for (int i = 0; i < dequeue; i++)
            {
                numbers.Dequeue();
            }

            //if the items exists in the queue
            if (numbers.Contains(item))
            {
                Console.WriteLine("true");
            }
            else
            {   //if elemant count is zero
                if (numbers.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {  //atherwize print the smallest element 
                    Console.WriteLine(numbers.Min());
                }
            }
        }
    }
}
