using System;

namespace _01BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            int maxAttendance = 0;

            for (int i = 0; i < studentCount; i++)
            {
                int attendanceCount = int.Parse(Console.ReadLine());

                double fullAttendance = 1.0 * attendanceCount / lecturesCount;
                double extraBonus = 5 + initialBonus;
                //calculate total bonus
                double totalBonus = Math.Ceiling(fullAttendance * extraBonus);

                //find the student with highest bonus
                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxAttendance = attendanceCount;
                }
            }

            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
}
