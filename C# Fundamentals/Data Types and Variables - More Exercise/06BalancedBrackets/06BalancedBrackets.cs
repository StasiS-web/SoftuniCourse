using System;
using System.Collections.Generic;

namespace _06BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<string> brackets = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(" || input == ")")
                {
                    brackets.Add(input);
                }
            }

            bool balanced = true;

                if (brackets.Count % 2 != 0)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }

            for (int i = 0; i < brackets.Count - 1; i += 2)
            {
                if ((brackets[i] == "(" && brackets[i + 1] != ")") || (brackets[i] == ")"))
                {
                    balanced = false;
                    break;
                }
            }

            if (balanced == true)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
