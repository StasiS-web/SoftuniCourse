using System;
using System.Collections.Generic;
using System.Linq;

namespace _05FashionBoutique
{
    class FashionBoutique
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();
            Stack<int> clothes = new Stack<int>(sequence);
            int capacity = int.Parse(Console.ReadLine());

            int racks = 1;
            int currentCapacity = 0;

            while (clothes.Count != 0)
            {
                int currentCloths = clothes.Pop();
                //calculate the value of the cloths
                int sum = currentCapacity + currentCloths;

                if (sum <= capacity)
                { //keep summing the values
                    currentCapacity += currentCloths;
                }
                else if (sum == capacity)
                {  // don't add the piece of clothing to current rack and take a new one
                    racks++;
                    currentCapacity = 0;
                }
                else 
                {  // don't add the piece of clothing to current rack and take a new one
                    racks++;
                    currentCapacity = currentCloths;
                }
            }

            Console.WriteLine(racks);
        }
    }
}
