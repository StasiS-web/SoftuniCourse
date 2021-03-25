using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architect = Console.ReadLine();
            double countProjects = double.Parse(Console.ReadLine());

            double hours = countProjects * 3;

            Console.WriteLine($"The architect {architect} will need {hours} hours to complete {countProjects} project/s.");
        }
    }
}