using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int countFlower = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            int roses = 5;
            double dahlias = 3.80;
            double tulips = 2.80;
            int narcissus = 3;
            double gladiolus = 2.50;

            double totalPrice = 0;

            switch(flowerType)
            {
                case "Roses":
                    totalPrice = countFlower * roses;
                    if(countFlower > 80)
                    {
                        totalPrice = totalPrice - 0.10 * totalPrice;
                    }
                    break;
                case "Dahlias":
                    totalPrice = countFlower * dahlias;
                    if (countFlower > 90)
                    {
                        totalPrice = totalPrice - 0.15 * totalPrice;
                    }
                    break;
                case "Tulips":
                    totalPrice = countFlower * tulips;
                    if (countFlower > 80)
                    {
                        totalPrice = totalPrice - 0.15 * totalPrice;
                    }
                    break;
                case "Narcissus":
                    totalPrice = countFlower * narcissus;
                    if (countFlower < 120)
                    {
                        totalPrice = totalPrice + 0.15 * totalPrice;
                    }
                    break;
                case "Gladiolus":
                    totalPrice = countFlower * gladiolus;
                    if (countFlower < 80)
                    {
                        totalPrice = totalPrice + 0.20 * totalPrice;
                    }
                    break;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {countFlower} {flowerType} and {(budget - totalPrice):F2} leva left.");
                
            }
            else if(budget < totalPrice)
            {
                Console.WriteLine($"Not enough money, you need {(totalPrice - budget):F2} leva more.");
            }
        }
    }
}
