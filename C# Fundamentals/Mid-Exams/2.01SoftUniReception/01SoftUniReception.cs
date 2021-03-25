using System;

namespace _01SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeOne = int.Parse(Console.ReadLine());
            int employeeTwo = int.Parse(Console.ReadLine());
            int employeeThree = int.Parse(Console.ReadLine());
            int studentsPerHour = int.Parse(Console.ReadLine());

            int employees = employeeOne + employeeTwo + employeeThree;

            int hours = 0;
          
            while(studentsPerHour > 0)
            {
                studentsPerHour -= employees;
                hours++;

                if (hours % 4 == 0)
                {
                    hours++;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
