using System;
using System.Collections.Generic;
using System.Linq;

namespace _03MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sequence = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = string.Empty;

            int moves = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "end")
                {
                    break;
                }

                moves++;

                string[] index = input.Split();
                int index1 = int.Parse(index[0]);
                int index2 = int.Parse(index[1]);

                if (index1 >= 0 && index2 >= 0
                    && index1 < sequence.Count
                    && index2 < sequence.Count
                    && index1 != index2)
                {   //Every time the player hit two matching elements you should 
                    if (sequence[index1] == sequence[index2])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {sequence[index1]}!");

                        if (index1 > index2)
                        { // remove them from the sequence
                            sequence.RemoveAt(index1);
                            sequence.RemoveAt(index2);
                        }
                        else
                        {
                            sequence.RemoveAt(index2);
                            sequence.RemoveAt(index1);
                        }

                        if (sequence.Count == 0)
                        {  //If the player hit all matching elements before he receives "end"
                            Console.WriteLine($"You have won in {moves} turns!");
                            return;
                        }
                    }
                    else if (sequence[index1] != sequence[index2])
                    {  //If the player hit two different elements
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    sequence.Insert(sequence.Count / 2, $"-{moves}a");
                    sequence.Insert(sequence.Count / 2, $"-{moves}a");

                    Console.WriteLine("Invalid input! Adding additional elements to the board");             
                }
            }

            Console.WriteLine($"Sorry you lose :(");
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
