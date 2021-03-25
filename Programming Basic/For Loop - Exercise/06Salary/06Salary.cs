using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            //read data for open tabs in the browser and salary
            int countOpenTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            //read the name of the site
            for (int i = 0; i < countOpenTabs; i++)
            {
                string site = Console.ReadLine();

                //check which site is open in the tab
                if (site == "Facebook")
                {
                    salary -= 150;
                }
                else if (site == "Instagram")
                {
                    salary -= 100;
                }
                else if (site == "Reddit")
                {
                    salary -= 50;
                }

                //check the if the salary is zero or not
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary > 0)
            {
               Console.WriteLine(salary);
            }
        }
    }
}
