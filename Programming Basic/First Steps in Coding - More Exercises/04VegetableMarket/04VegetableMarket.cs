
using System;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetalePricePerKg = double.Parse(Console.ReadLine());
            double fruitPricePerKg = double.Parse(Console.ReadLine());
            int vegetaleKg = int.Parse(Console.ReadLine());
            int fruitKg = int.Parse(Console.ReadLine());

            double vegetablePrice = vegetalePricePerKg * vegetaleKg;
            double fruitPrice = fruitPricePerKg * fruitKg;
            double totalPriceLv = vegetablePrice + fruitPrice;
            double totalPriceEuro = totalPriceLv / 1.94;

            Console.WriteLine($"{totalPriceEuro:F2}");
        }
    }
}