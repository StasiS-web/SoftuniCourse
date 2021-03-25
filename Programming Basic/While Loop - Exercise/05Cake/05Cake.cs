using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int totalCake = length * width;
            

            while (totalCake > 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                else
                {
                    int takenPieces = int.Parse(input);
                    totalCake -= takenPieces;
                }
            }
            if (totalCake >= 0)
            {
                //have cake
                Console.WriteLine($"{totalCake} pieces are left.");
            }
            else
            {
                //no more cake -> pieces < 0
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalCake)} pieces more.");

            }
        }
    }
}
