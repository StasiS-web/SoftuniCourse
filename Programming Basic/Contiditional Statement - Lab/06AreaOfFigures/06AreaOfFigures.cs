using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();

            double area = 0;

            if (shape == "square")
            {
                double x = double.Parse(Console.ReadLine());

                area = x * x;
         
            }
            else if (shape == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                area = a * b;
               
            }
            else if (shape =="circle")
            {
                double r = double.Parse(Console.ReadLine());

                area = 3.14159 * (r * r);
                
            }
            else if (shape == "triangle")
            {
                double w = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());

                area = w * h * 1/2;
               
            }
            
            Console.WriteLine($"{area:F3}");
        }
    }
}
