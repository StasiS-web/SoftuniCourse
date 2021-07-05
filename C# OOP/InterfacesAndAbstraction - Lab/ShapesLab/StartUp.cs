using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var radius = int.Parse(Console.ReadLine());
            IDrawable cicle = new Circle(radius);

            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            IDrawable rectangular = new Rectangle(width, height);

            cicle.Draw();
            rectangular.Draw();
        }
    }
}
