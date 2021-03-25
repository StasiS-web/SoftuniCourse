using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double rentForHall = double.Parse(Console.ReadLine());
            
            double cakePrice = rentForHall * 0.20;
            double drinks = cakePrice - (cakePrice * 0.45);         
            double animator = rentForHall / 3;
            double totalSum = rentForHall + cakePrice + drinks + animator;


            Console.WriteLine(totalSum);
        }
    }
}
