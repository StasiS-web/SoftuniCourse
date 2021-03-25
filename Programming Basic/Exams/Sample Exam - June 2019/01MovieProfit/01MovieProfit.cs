using System;

namespace _01MovieProfitJune2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int ticketsCount = int.Parse(Console.ReadLine());
            double priceTicket = double.Parse(Console.ReadLine());
            int percentForCinema = int.Parse(Console.ReadLine());

            double ticketCostForDay = ticketsCount * priceTicket;
            double incomePeriod = days * ticketCostForDay;
            double percentFromIncome = incomePeriod * percentForCinema / 100;
            double incomeFromMovie = incomePeriod - percentFromIncome;

            Console.WriteLine($"The profit from the movie {movie} is {incomeFromMovie:F2} lv.");
        }
    }
}
