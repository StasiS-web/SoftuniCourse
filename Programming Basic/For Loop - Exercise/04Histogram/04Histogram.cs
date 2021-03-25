using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double categoryP1 = 0;
            double categoryP2 = 0;
            double categoryP3 = 0;
            double categoryP4 = 0;
            double categoryP5 = 0;

            for (int i = 0; i < number; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if(currentNumber < 200)
                {
                    categoryP1++;
                }
                else if(currentNumber >= 200 && currentNumber <= 399)
                {
                    categoryP2++;
                }
                else if (currentNumber >= 400 && currentNumber <= 599)
                {
                    categoryP3++;
                }
                else if (currentNumber >= 600 && currentNumber <= 799)
                {
                    categoryP4++;
                }
                else if (currentNumber >= 800)
                {
                    categoryP5++;
                }
            }
            Console.WriteLine($"{categoryP1 / number * 100:f2}%");
            Console.WriteLine($"{categoryP2 / number * 100:f2}%");
            Console.WriteLine($"{categoryP3 / number * 100:f2}%");
            Console.WriteLine($"{categoryP4 / number * 100:f2}%");
            Console.WriteLine($"{categoryP5 / number * 100:f2}%");
        }
    }
}
