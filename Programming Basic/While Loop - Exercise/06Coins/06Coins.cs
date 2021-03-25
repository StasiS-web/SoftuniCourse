using System;

namespace Coins
{
    class Program
    { 
        static void Main(string[] args)
        {
            //read sum
            double sum = double.Parse(Console.ReadLine());
            double changeBack = Math.Round(sum * 100);
            //count return coins
            int countCoins = 0;

            //checkn how many coint are return
            while(changeBack > 0)
            {

                if (changeBack >= 200)
                {
                    changeBack -= 200;
                    countCoins++;
                }
                else if (changeBack >= 100)
                {
                    changeBack -= 100;
                    countCoins++;
                }
                else if (changeBack >= 50)
                {
                    changeBack -= 50;
                    countCoins++;
                }
                else if (changeBack >= 20)
                {
                    changeBack -= 20;
                    countCoins++;
                }
                else if (changeBack >= 10)
                {
                    changeBack -= 10;
                    countCoins++;
                }
                else if (changeBack >= 5)
                {
                    changeBack -= 5;
                    countCoins++;
                }
                else if (changeBack >= 2)
                {
                    changeBack -= 2;
                    countCoins++;
                }
                else if (changeBack >= 1)
                {
                    changeBack -= 1;
                    countCoins++;
                }

            }

            Console.WriteLine(countCoins);

        }
    }
}
