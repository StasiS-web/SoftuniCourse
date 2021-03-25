using System;

namespace CinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            String dayOfWeek = Console.ReadLine();
            
            double priceTicket = 0;

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                    priceTicket = 12;
                    Console.WriteLine(priceTicket);
                    break;
                case "Wednesday":
                case "Thursday":
                    priceTicket = 14;
                    Console.WriteLine(priceTicket);
                    break;
                case "Friday":
                    priceTicket = 12;
                    Console.WriteLine(priceTicket);
                    break;
                case "Saturday":
                case "Sunday":
                    priceTicket = 16;
                    Console.WriteLine(priceTicket);
                    break;
            }
        }
    }
}
