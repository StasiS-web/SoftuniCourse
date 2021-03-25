using System;

namespace Mid_Exam27Feb21Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            //run through all orders to calculate theprice of each order
            for (int i = 0; i < orders; i++)
            { 
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                //calculate the price
                double priceOrder = days * capsuleCount * pricePerCapsule;
                 totalPrice += priceOrder; // calculate total price

                Console.WriteLine($"The price for the coffee is: ${priceOrder:F2}");
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
