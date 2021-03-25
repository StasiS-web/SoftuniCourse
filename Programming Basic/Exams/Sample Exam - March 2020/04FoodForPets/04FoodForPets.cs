using System;

namespace Task4FoodForPets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double allFood = double.Parse(Console.ReadLine());

            double biscuits = 0;
            double totalPetFood = 0;
            double eatenDog = 0;
            double eatenCat = 0;

            for (int i = 1; i <= days; i++)
            {
                double dogFood = double.Parse(Console.ReadLine());
                double catFood = double.Parse(Console.ReadLine());

                eatenDog += dogFood;
                eatenCat += catFood;
                totalPetFood = eatenDog + eatenCat;

                if (i % 3 == 0)
                {
                    double currentBiscuits = (dogFood + catFood) * 0.1;
                    biscuits += currentBiscuits;
                }
            }

            double percentFood = (totalPetFood / allFood) * 100;
            double percentDog = (eatenDog / totalPetFood) * 100;
            double percentCat = (eatenCat / totalPetFood) * 100;
            biscuits = Math.Round(biscuits);

            Console.WriteLine($"Total eaten biscuits: {biscuits}gr.");
            Console.WriteLine($"{percentFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentDog:f2}% eaten from the dog.");
            Console.WriteLine($"{percentCat:f2}% eaten from the cat.");
        }
    }
}
