using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string exitUnit = Console.ReadLine();
            double result = 0.0;
           /* if(inputUnit.Equals("mm") && exitUnit.Equals("cm"))
            {
                result = number / 10;
                
            }
            else if(inputUnit.Equals("mm") && exitUnit.Equals("m"))
            { 
                result = number / 1000;
                
            }
            else if (inputUnit.Equals("cm") && exitUnit.Equals("mm"))
            {
                result = number * 10;
                
            }
            else if (inputUnit.Equals("cm") && exitUnit.Equals("m"))
            {
               result = number / 100;
              
            }
            else if (inputUnit.Equals("m") && exitUnit.Equals("mm"))
            { 
                result = number * 1000;
               
            }
            else if (inputUnit.Equals("m") && exitUnit.Equals("cm"))
            { 
                result = number * 100;

            }
            Console.WriteLine($"{result:F3}");*/

            if(inputUnit == "mm" && exitUnit == "m")
            {
                result = number / 1000;
            }
            else if (inputUnit == "mm" && exitUnit == "cm")
            {
                result = number / 10;
            }
            else if (inputUnit == "cm" && exitUnit == "m")
            {
                result = number / 100;
            }
            else if (inputUnit == "cm" && exitUnit == "mm")
            {
                result = number * 10;
            }
            else if (inputUnit == "m" && exitUnit == "cm")
            {
                result = number * 100;
            }
            else if (inputUnit == "m" && exitUnit == "mm")
            {
                result = number * 1000;
            }

            Console.WriteLine($"{result:F3}");
        }
    }
}
           