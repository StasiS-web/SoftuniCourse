using System;

namespace Task5CareOfPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            double gQuantityFood = quantityFood * 1000; ;
            int eatenAmount = 0;

            while (input != "Adopted")
            {
               int eatenFood = int.Parse(input);
                eatenAmount += eatenFood;
                input = Console.ReadLine();
            }

            if (eatenAmount <= gQuantityFood)
            {
                double leftFood = gQuantityFood - eatenAmount;
                Console.WriteLine($"Food is enough! Leftovers: {leftFood} grams.");
            }
            else 
            {
                double neededFood = eatenAmount - gQuantityFood;
                Console.WriteLine($"Food is not enough. You need {neededFood} grams more.");
            }
        }
    }
}
