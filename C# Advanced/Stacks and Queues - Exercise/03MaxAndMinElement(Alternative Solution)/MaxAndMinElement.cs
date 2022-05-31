using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MaxAndMinElement
{
    public class MaxAndMinElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for(int i = 0; i < n; i++)
            {
                int[] queries = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int cmd = queries[0];
                
                if(cmd == 1)
                {
                    int element = queries[1];
                    stack.Push(element);
                }
                else if (cmd == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (cmd == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (cmd == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(", " , stack));
        }
    }
}
 
