﻿using System;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public Box()
        {
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public string SurfaceArea()
        {
            double surfaceArea = (2 * this.Length * this.Width) + (2 * this.Length * this.Height) + (2 * this.Width * this.Height);

            return $"Surface Area - {surfaceArea:F2}";
        }

        public string LateralSurfaceArea()
        {
            double lateralSurfaceArea = (2 * this.Length * this.Height) + (2 * this.Width * this.Height);

            return $"Lateral Surface Area - {lateralSurfaceArea:F2}";
        }

        public string Volume()
        {
            double volume = this.Length * this.Width * this.Height;

            return $"Volume - {volume:F2}";
        }

    }
}
