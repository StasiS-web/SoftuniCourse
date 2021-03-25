using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double depositSum = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            double yearlyInterest = double.Parse(Console.ReadLine());

            double amount = depositSum * yearlyInterest / 100; // * 0.01
            double monthInterest = amount / 12;
            double sum = depositSum + (month * monthInterest);

            Console.WriteLine(sum);
   
        }
    }
}
