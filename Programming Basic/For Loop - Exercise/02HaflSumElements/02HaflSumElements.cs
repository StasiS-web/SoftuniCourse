using System;

namespace HaflSumElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int sum = 0;

            for (int i = 0; i < numberCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                sum += currentNumber;
                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
            }
            int sumWithoutMaxNumber = sum - maxNumber;
            if (sumWithoutMaxNumber == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumWithoutMaxNumber}");
            }
            else
            {
                int difference = Math.Abs(maxNumber - sumWithoutMaxNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {difference}");
            }
        }
    }
}
