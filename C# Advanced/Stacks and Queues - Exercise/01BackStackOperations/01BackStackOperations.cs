using System;
using System.Collections.Generic;
using System.Linq;

namespace _01BackStackOperations
{
    class BackStackOperations
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            //stack's parameters
            int push = input[0];
            int pop = input[1];
            int item = input[2];
            //elements in the stack
            int[] items = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            Stack<int> stackNum = new Stack<int>();

            //go through all elements to push into the stack
            for (int i = 0; i < push; i++)
            {

                stackNum.Push(items[i]);
            }

            //go through all elements to pop into the stack
            for (int i = 0; i < pop; i++)
            {

                stackNum.Pop();
            }

            //if the items exists in the stack
            if (stackNum.Contains(item))
            {
                Console.WriteLine("true");
            }
            else
            {
                //if elemant count is zero
                if (stackNum.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                { //atherwize print the smallest element 
                    Console.WriteLine(stackNum.Min());
                }

            }
        }
    }
}
