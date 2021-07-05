using System;

namespace Shapes
{
    public class Circle : IDrawable
    {
        private readonly int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            double tickness = 0.4;
            double rInside = radius - tickness;
            double rOut = radius + tickness;

            for (double y = radius; y >= -radius; y--)
            {
                for (double x = -radius; x <= radius; x += 0.5)
                {
                    double value = x * x + y * y;

                    if (value >= rInside * rInside && value <= rOut * rOut)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
