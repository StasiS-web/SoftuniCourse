using System;
using P01_StudentSystem.Data;

namespace P01_StudentSystem
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StudentSystemContext context = new StudentSystemContext();

            context.Database.EnsureCreated();

            Console.WriteLine("Databse is created successfully!");
            Console.WriteLine("Do you want to delete database(Y/N)?");
            string result = Console.ReadLine();

            if (result == "Y")
            {
                context.Database.EnsureDeleted();
            }
        }
    }
}
