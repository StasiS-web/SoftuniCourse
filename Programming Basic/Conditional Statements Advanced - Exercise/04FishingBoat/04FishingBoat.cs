using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countFishman = int.Parse(Console.ReadLine());

            double rent = 0;

            switch(season)
            {
                case "Spring":
                    rent = 3000;
                    if (countFishman <= 6)
                    {
                        rent -= 0.10 * rent;
                    }
                    else if (countFishman >= 7 && countFishman <= 11)
                    {
                        rent -= 0.15 * rent;
                    }
                    else if (countFishman >= 12)
                    {
                        rent -= 0.25 * rent;
                    }
                    break;
                case "Summer":
                case "Autumn":
                    rent = 4200;
                    if (countFishman <= 6)
                    {
                        rent -= 0.10 * rent;
                    }
                    else if (countFishman >= 7 && countFishman <= 11)
                    {
                        rent -= 0.15 * rent;
                    }
                    else if (countFishman >= 12)
                    {
                        rent -= 0.25 * rent;
                    }
                    break;
                case "Winter":
                    rent = 2600;
                    if (countFishman <= 6)
                    {
                        rent -= 0.10 * rent;
                    }
                    else if (countFishman >= 7 && countFishman <= 11)
                    {
                        rent -= 0.15 * rent;
                    }
                    else if (countFishman >= 12)
                    {
                        rent -= 0.25 * rent;
                    }
                    break;
            }

            
            if (countFishman % 2 == 0 && season != "Autumn")
            {
                rent -= 0.05 * rent;
            }
            if (budget >= rent)
            {
                Console.WriteLine($"Yes! You have {(budget - rent):f2} leva left.");
            }
            else if (budget < rent)
            {
                Console.WriteLine($"Not enough money! You need {(rent - budget):f2} leva.");

            }
        }
    }
}
