namespace CarManufacturer
{
    public class Engine
    {
        //Fields
        private int horsePower;
        private double cubicCapacity;

        //Constructors
        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }

        //Properties
        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }

    }
}
