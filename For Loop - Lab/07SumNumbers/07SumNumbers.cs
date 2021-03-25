using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 0; i < numberCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);

        }
    }
}
