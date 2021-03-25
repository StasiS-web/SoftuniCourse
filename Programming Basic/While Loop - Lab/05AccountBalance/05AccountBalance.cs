using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            //read from the console
            string command = Console.ReadLine();

            double balance = 0;
            //command "NoMoreMoney"
            while (command != "NoMoreMoney")
            {
                //read from the conosle 
                double currentAmount = double.Parse(command);

                //if balance < 0 print "Invalid operation!" and break;
                if (currentAmount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                //calculate the blance
                balance += currentAmount;
                if (balance < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                //"Increase: 
                Console.WriteLine($"Increase: {currentAmount:f2}");
                command = Console.ReadLine();
            }
            //print "Total: "
            Console.WriteLine($"Total: {balance:f2}");

        }
    }
}
