﻿using System;

namespace ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            /*while (input != "Stop")
            {
                Console.WriteLine(input);
                input = Console.ReadLine();
            }*/
            while (true)
            {
                if (input == "Stop")
                {
                    break;
                }
                Console.WriteLine(input);
                input = Console.ReadLine();
                
            }
        }
    }
}
