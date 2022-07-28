using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double additionalComsumption = 1.6;
        private const double keptFuelInTank = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        protected override double AdditionalComsumption => additionalComsumption;

        public override void Refuel(double amontOfFuel)
        {
            FuelQuantity += amontOfFuel * keptFuelInTank;
        }
    }
}
