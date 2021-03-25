using System;

namespace Task2CatWalkingMarch2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesWalk = int.Parse(Console.ReadLine());
            int countWalksPerDay = int.Parse(Console.ReadLine());
            int takenCalories = int.Parse(Console.ReadLine());

            double totalTimeWalk = minutesWalk * countWalksPerDay;
            double burnCalories = totalTimeWalk * 5;

            double takenCaloriesPerDay = 0.5 * takenCalories;

            if (burnCalories >= takenCaloriesPerDay)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnCalories}.");
            }
            else if(burnCalories < takenCaloriesPerDay)
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnCalories}.");
            }
         }
    }
}
