using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDogs = int.Parse(Console.ReadLine());
            int countPets = int.Parse(Console.ReadLine());
             
            double priceDogFood = countDogs * 2.50;
            double pricePetsFood = countPets * 4;

            double totalCostFood = priceDogFood + pricePetsFood;

         
            Console.WriteLine(totalCostFood + " lv.");

        }
    }
}