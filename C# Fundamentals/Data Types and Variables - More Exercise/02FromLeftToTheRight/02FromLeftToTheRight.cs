using System;

namespace _02FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine()); //how many line of numbers

            //go throught all the line 
            for (int i = 0; i < line; i++)
            {
                string numbers = Console.ReadLine();
                string[] input = numbers.Split(' ');

                //separate left from right number
                long leftNumber = long.Parse(input[0]);
                long rightNumber = long.Parse(input[1]);

                //check or find which is the bigger one
                long bigger = leftNumber;
                if (rightNumber > leftNumber)
                {
                    bigger = rightNumber;
                }

                // calculate all its digits
                long sum = 0;
                while (bigger != 0)
                {
                    sum += bigger % 10;
                    bigger /= 10;
                }

                Console.WriteLine($"{Math.Abs(sum)}");
            }
        }
    }
}
