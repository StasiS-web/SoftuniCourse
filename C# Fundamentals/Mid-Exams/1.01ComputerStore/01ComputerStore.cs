using System;

namespace _01ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            

            double priceWithoutTax = 0;
            double totalPrice = 0;
            double taxes = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "regular")
                {
                    priceWithoutTax = totalPrice;
                    double priceWithTax = 1.2 * totalPrice;
                    taxes = priceWithTax - totalPrice;
                    totalPrice = 1.2 * totalPrice;

                    if (totalPrice == 0)
                    {
                        Console.WriteLine("Invalid order!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Congratulations you've just bought a new computer!");
                        Console.WriteLine($"Price without taxes: {priceWithoutTax:F2}$");
                        Console.WriteLine($"Taxes: {taxes:F2}$");
                        Console.WriteLine("-----------");
                        Console.WriteLine($"Total price: {totalPrice:F2}$");
                        return;
                    }
                }

                if (input == "special")
                {
                    priceWithoutTax = totalPrice;
                    double priceWithTax = 1.2 * totalPrice;
                    taxes = priceWithTax - totalPrice;
                    totalPrice = 0.9 * priceWithTax;

                    if (priceWithoutTax == 0)
                    {
                        Console.WriteLine("Invalid order!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Congratulations you've just bought a new computer!");
                        Console.WriteLine($"Price without taxes: {priceWithoutTax:F2}$");
                        Console.WriteLine($"Taxes: {taxes:F2}$");
                        Console.WriteLine("-----------");
                        Console.WriteLine($"Total price: {totalPrice:F2}$");
                        return;
                    }
                }
                else
                {
                    if (double.Parse(input) <= 0)
                    {
                        Console.WriteLine("Invalid price!");
                        continue;
                    }
                }

                totalPrice += double.Parse(input);
            }
        }
    }
}
