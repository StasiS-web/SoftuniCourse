using System;

namespace SumNumberes
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < targetNumber)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;

                if (sum >= targetNumber)
                {
                    Console.WriteLine(sum);
                    break;
                }
            }
        }
    }
}
