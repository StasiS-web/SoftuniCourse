using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MaxAndMinElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> sequence = new Stack<int>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                int[] command = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                switch(command[0])
                {
                    case 1:
                     //Push the element x into the stack
                    sequence.Push(command[1]);
                      break;
                    case 2:
                      // Delete the element present at the top of the stack.
                      if (sequence.Count != 0)
                      {
                        sequence.Pop();
                      }
                        break;
                    case 3:
                        if (sequence.Count != 0)
                        {
                            //Print the maximum element in the stack.
                            Console.WriteLine(sequence.Max());
                        }
                        break;
                    case 4:
                        if (sequence.Count != 0)
                        {
                            // Print the minimum element in the stack.
                            Console.WriteLine(sequence.Min());
                        }
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", sequence));
        }
    }
}
