using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double price = 0.0;

            switch (typeProjection)
            {
                case "Premiere":
                    price = rows * columns * 12;                 
                    break;
                case "Normal":
                    price = rows * columns * 7.50;
                    break;
                case "Discount":
                    price = rows * columns * 5;
                    break;
            }
            Console.WriteLine($"{price:f2} leva");
        }
    }
}
