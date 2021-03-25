using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //read info 
            double tripCost = double.Parse(Console.ReadLine());
            double savedMoney = double.Parse(Console.ReadLine());

            int days = 0; //count passed days
            int spendingMoneyDays = 0; //count the spending days

            while (true)
            {
                string activity = Console.ReadLine();
                double currentMoney = double.Parse(Console.ReadLine());
                

                if (activity == "save")
                {
                    savedMoney += currentMoney;
                    spendingMoneyDays = 0;
                    days++;
                }
                else if (activity == "spend")
                {
                    double diff = savedMoney - currentMoney;
                    if (diff < 0)
                    {
                        savedMoney = 0;
                    }
                    else
                    {
                        savedMoney -= currentMoney;
                    }
                    spendingMoneyDays++;
                    days++; 
                }

                if (spendingMoneyDays == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{days}");
                    break;
                }
               if (savedMoney >= tripCost)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }
            }
        }
    }
}
