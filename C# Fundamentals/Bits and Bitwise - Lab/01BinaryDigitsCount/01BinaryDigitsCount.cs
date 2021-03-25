using System;

namespace _01BinaryDigitsCountLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int binaryDigit = int.Parse(Console.ReadLine());

            int count = 0;//variable that contain amount set on 0

            //stop if number == 0
            while (number > 0)
            { //convert number into binary representation
                int leftover = number % 2;
                //check if there is remainning
                if (leftover == binaryDigit)
                {  //count digits
                    count++;
                }

                number /= 2;
            }

            Console.WriteLine(count);
        }
    }
}
