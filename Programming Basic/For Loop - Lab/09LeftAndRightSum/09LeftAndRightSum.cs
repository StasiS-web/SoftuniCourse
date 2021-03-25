using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sumRight = 0;
            for (int i = 1; i <= number; i++)
            {
                int n2 = int.Parse(Console.ReadLine());
                sumRight += n2;
            }
            int sumLeft = 0;
            for (int i = 1; i <= number; i++)
            {

                int n2 = int.Parse(Console.ReadLine());
                sumLeft += n2;
            }
            if (sumRight == sumLeft)
            {
                Console.WriteLine($"Yes, sum = {sumRight}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumRight - sumLeft)}");
            }
        }
    }
}
