using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfTrip = int.Parse(Console.ReadLine());
            int allFoodKg = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodPerDay = double.Parse(Console.ReadLine());

            //calculate the needed food for each pet (cat , dog , turtle)
            double dogEatenFood = daysOfTrip * dogFoodPerDay;
            double catEatenFood = daysOfTrip * catFoodPerDay;
            double turtleEatenFood = (daysOfTrip * turtleFoodPerDay) / 1000;
            double totalEatenFood = dogEatenFood + catEatenFood + turtleEatenFood;

            if (totalEatenFood <= allFoodKg)
            {
                double leftFood = Math.Floor(allFoodKg - totalEatenFood);
                Console.WriteLine($"{leftFood} kilos of food left.");
            }
            else if (totalEatenFood > allFoodKg)
            {
                double neededFood = Math.Ceiling(totalEatenFood - allFoodKg);
                Console.WriteLine($"{neededFood} more kilos of food are needed.");
            }
        }
    }
}
