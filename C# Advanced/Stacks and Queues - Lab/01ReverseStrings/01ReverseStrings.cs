using System;
using System.Collections.Generic;

namespace _01ReverseStringsSolution1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> charStr = new Stack<char>();

            foreach (var item in input)
            {
                charStr.Push(item);
            }

            while (charStr.Count > 0)
            {
                Console.Write(charStr.Pop());
            }

            Console.WriteLine();
        }
    }
}
