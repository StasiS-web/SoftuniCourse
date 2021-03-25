using System;

namespace _04CinemaJune2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            double profit = 0;
            string command = Console.ReadLine();
            bool full = false;

            while (command != "Movie time!")
            {
                int countPeople = int.Parse(command);
                capacity -= countPeople;

                if (capacity < 0)
                {
                    Console.WriteLine($"The cinema is full.");
                    full = true;
                    break;
                }

                if (countPeople % 3 == 0)
                {
                    profit += (countPeople * 5 - 5);
                }
                else
                {
                    profit += countPeople * 5;
                }

                command = Console.ReadLine();
            }

            if (!full)
            {
                Console.WriteLine($"There are {capacity} seats left in the cinema.");
            }
            Console.WriteLine($"Cinema income - {profit} lv.");
        }
    }
}
