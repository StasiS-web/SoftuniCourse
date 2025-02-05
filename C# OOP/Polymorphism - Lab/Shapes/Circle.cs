﻿using System;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get => radius;
            set
            {
                radius = value;
            }
        }

        public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);

        public override double CalculatePerimeter() => 2 * Math.PI * Radius;

        public override string Draw()
        {
            return base.Draw() + "Circle";
        }
    }
}
