namespace CarManufacturer
{
    public class Tire
    {
        //Fields
        private int year;
        private double pressure;

        //Constructors
        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }

        //Properties
        public int Year { get; set; }
        public double Pressure { get; set; }

    }
}
