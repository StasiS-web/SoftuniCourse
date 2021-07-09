namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public double Heigth
        {
            get => height;
            private set
            {
                height = value;
            }
        }

        public double Width
        {
            get => width;
            private set
            {
                width = value;
            }
        }

        public override double CalculateArea() => Heigth * Width;

        public override double CalculatePerimeter() => 2 * (Heigth + Width);

        public override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
