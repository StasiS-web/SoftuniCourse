using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedThreshold = int.Parse(Console.ReadLine());

            int  failedTask = 0;
            int solvedTask = 0;
            double sumScore = 0;
            string lastTask = "";


            while (failedTask < failedThreshold)
            {
                string taskName = Console.ReadLine();
                if (taskName == "Enough")
                {
                    double averageGrade = sumScore / solvedTask;
                    Console.WriteLine($"Average score: {averageGrade:f2}");
                    Console.WriteLine($"Number of problems: {solvedTask}");
                    Console.WriteLine($"Last problem: {lastTask}");
                    break;
                }

                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedTask++;
                }
                sumScore += grade;
                solvedTask++;
                lastTask = taskName;
            }

            if (failedTask == failedThreshold)
            {
                Console.WriteLine($"You need a break, {failedThreshold} poor grades.");
            }
        }
    }
}
