using System;

namespace MIdExam01Problem6Mar21
{
    class Program
    {
        static void Main(string[] args)
        {
            int journeyCost = int.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());

            double savedMoney = 0;

            for (int i = 1; i <= months; i++)
            {
                //every odd months (except the first one) spend 16%
                if (i % 2 != 0 && i != 1)
                {
                    double expences = savedMoney * 0.16;
                    savedMoney -= expences;
                }

                //fourth months at the beginning you get a bonus
                if (i % 4 == 0)
                {
                    double bonus = 0.25 * savedMoney;
                    savedMoney += bonus;
                }

                //the end of each month saved 25% of the cost
                savedMoney += journeyCost * 0.25;
            }

            if (savedMoney >= journeyCost)
            {
                //calculate the money left for souvenir
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {(savedMoney - journeyCost):F2}lv. for souvenirs.");
            }
            else 
            {   //calculate the money needed for the journey
                Console.WriteLine($"Sorry. You need {(journeyCost - savedMoney):F2}lv. more.");
            }
        }
    }
}
