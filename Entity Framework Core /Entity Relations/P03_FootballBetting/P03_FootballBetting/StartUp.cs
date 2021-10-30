using System;
using P03_FootballBetting.Data;

namespace P03_FootballBetting
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            FootballBettingContext dbContext = new FootballBettingContext();

            dbContext.Database.EnsureCreated();

            Console.WriteLine("Database was created successfully");
            Console.WriteLine("Do you want to delete the database (Y/N)?");

            string result = Console.ReadLine();

            if (result == "Y")
            {
                dbContext.Database.EnsureDeleted();
            }
        }
    }
}
