using System;

namespace _03MovieDestinationJune2019
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int daysCount = int.Parse(Console.ReadLine());

            double price = 0;
            switch (destination)
            {
                case "Dubai":
                    switch (season)
                    {
                        case "Summer":
                            price = 40000;
                            break;
                        case "Winter":
                            price = 45000;
                            break;
                    }
                    break;

                case "Sofia":
                    switch (season)
                    {
                        case "Summer":
                            price = 12500;
                            break;
                        case "Winter":
                            price = 17000;
                            break;
                    }
                    break;

                case "London":
                    switch (season)
                    {
                        case "Summer":
                            price = 20250;
                            break;
                        case "Winter":
                            price = 24000;
                            break;
                    }
                    break;   
            }

            double totalPrice = daysCount * price;
            if (destination == "Dubai")
            {
                totalPrice = totalPrice * 0.70;
            }
            else if (destination == "Sofia")
            {
                totalPrice = totalPrice * 1.25;
            }

            if(budget >= totalPrice)
            {
                double leftMoney = budget - totalPrice;
                Console.WriteLine($"The budget for the movie is enough! We have {leftMoney:F2} leva left!");
            }
            else
            {
                double neededMoney = totalPrice - budget;
                Console.WriteLine($"The director needs {neededMoney:F2} leva more!");

            }
        }
    }
}
