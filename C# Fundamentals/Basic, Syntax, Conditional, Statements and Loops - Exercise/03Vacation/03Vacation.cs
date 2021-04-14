using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double pricePerDay = 0;
            double discount = 0;

            switch (type)
            {
                case "Students":
                    if (people >= 30)
                    {
                        discount = 0.15;
                    }

                    if (day == "Friday")
                    {
                        pricePerDay = 8.45;
                    }
                    else if (day == "Saturday")
                    {
                        pricePerDay = 9.80;
                    }
                    else
                    {
                        pricePerDay = 10.46;
                    }
                    break;

                case "Business":
                    if (people >= 100)
                    {
                        people -= 10;
                    }

                    if (day == "Friday")
                    {
                        pricePerDay = 10.90;
                    }
                    else if (day == "Saturday")
                    {
                        pricePerDay = 15.60;
                    }
                    else
                    {
                        pricePerDay = 16;
                    }
                    break;

                case "Regular":
                    if (people >= 10 && people <= 20)
                    {
                        discount = 0.05;
                    }

                    if (day == "Friday")
                    {
                        pricePerDay = 15;
                    }
                    else if (day == "Saturday")
                    {
                        pricePerDay = 20;
                    }
                    else
                    {
                        pricePerDay = 22.50;
                    }
                    break;
            }

            double totalPrice = people * pricePerDay;

            if (discount != 0)
            {
                totalPrice -= totalPrice * discount;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
