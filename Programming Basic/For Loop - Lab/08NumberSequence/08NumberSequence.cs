using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;
            
            for (int i = 1; i <= numberCount; i++)
            {
               int currentValue = int.Parse(Console.ReadLine());
                if (currentValue >= maxNumber)
                {
                    maxNumber = currentValue;
                }
                if (currentValue <= minNumber)
                {
                    minNumber = currentValue;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");

        }
    }
}
