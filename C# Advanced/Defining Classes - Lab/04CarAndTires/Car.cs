using System;

namespace CarManufacturer
{
    public class Car
    {
        //Fields
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engines;
        private Tire[] tires;

        //Constructor
        public Car(
            string make,
            string model,
            int year,
            double fuelQuantity,
            double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(
            string make,
            string model,
            int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(
            string make,
            string model,
            int year,
            double fuelQuantity,
            double fuelConsumption,
            Engine engine,
            Tire[] tire)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tire;
        }


        //Properties
        public string Make { get; private set; } 

        public string Model { get; private set; }

        public int Year { get; private set; } 

        public double FuelQuantity { get; private set; } 

        public double FuelConsumption { get; private set; }

        public Engine Engine { get; set; }

        public Tire[] Tires { get; set; }

        //Methods
        public void Drive(int distance)
        {
            if ((this.FuelQuantity - (distance * this.FuelConsumption)) >= 0)
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L";
        }
    }
}
