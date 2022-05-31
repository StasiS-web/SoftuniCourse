using System;
using System.Collections.Generic;
using System.Linq;

namespace _02StackSum
{
    class StackSum
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();  //array of integers of integer numbers
            Stack<int> num = new Stack<int>(input);  //adds them to a stack
            string command = Console.ReadLine().ToLower();

            //read command until isequal to "end"
            while (command != "end")
            {
                string[] token = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (token[0].ToLower() == "add")
                {   //go through the count of numbers
                    for (int i = 1; i < token.Length; i++)
                    {  //add them both in the stack
                        num.Push(int.Parse(token[i]));
                    }
                }
                else if(token[0].ToLower() == "remove" && num.Count > int.Parse(token[1]))
                {
                    //you will always receive exactly one number
                    int count = int.Parse(token[1]);
                    if (count <= num.Count())
                    {
                        //you need to remove from the stack
                        for (int i = 0; i < count; i++)
                        {
                            num.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            //sum of the remaining elements of the stack
            Console.WriteLine($"Sum: {num.Sum()}");
        }
    }
}
