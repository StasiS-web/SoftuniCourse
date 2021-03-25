using System;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;

            for (int i = 1; i <= countNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    count1++;
                }
                if(number % 3 == 0)
                {
                    count2++;
                }
                if (number % 4 == 0)
                {
                    count3++;
                }
            }
            double percentP1 = count1 * 1.0 / countNumbers * 100;
            double percentP2 = count2 * 1.0 / countNumbers * 100;
            double percentP3 = count3 * 1.0 / countNumbers * 100;

            Console.WriteLine($"{percentP1:f2}%");
            Console.WriteLine($"{percentP2:f2}%");
            Console.WriteLine($"{percentP3:f2}%");
        }
    }
}
