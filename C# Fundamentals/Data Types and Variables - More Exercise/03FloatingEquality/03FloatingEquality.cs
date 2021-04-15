using System;

namespace _03FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double fixPrecision = 0.000001;  //initiliaze and get precision eps as 
            //compare the difference two floating-point numbers and compare
            bool isValid = (Math.Abs(a - b)) < fixPrecision;

            //get the result from the boolean and check it
            if (isValid)
            {
               Console.WriteLine("True");
            }
            else
            {
               Console.WriteLine("False");
            }
        }
    }
}
