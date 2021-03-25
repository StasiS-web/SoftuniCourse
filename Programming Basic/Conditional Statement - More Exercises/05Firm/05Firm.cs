using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {

            int hoursForProject = int.Parse(Console.ReadLine()); //time necessary for a project
            int daysForProject = int.Parse(Console.ReadLine()); // days that the firm has 
            int countEmployees = int.Parse(Console.ReadLine()); // amount employees working extra time

            double trainningTime = daysForProject * 0.1;
            double workingTime = (daysForProject - trainningTime) * 8;
            double extraWorkingTime = countEmployees * (daysForProject * 2);
            double totalWorkingTime = Math.Floor(workingTime + extraWorkingTime);

            if (totalWorkingTime >= hoursForProject)
            {
                double leftTime = totalWorkingTime - hoursForProject;
                Console.WriteLine($"Yes!{leftTime} hours left.");
            }
            else if (totalWorkingTime < hoursForProject)
            {
                double neededTime = hoursForProject - totalWorkingTime;
                Console.WriteLine($"Not enough time!{neededTime} hours needed.");
            }
        }
    }
}
