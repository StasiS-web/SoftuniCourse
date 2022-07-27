using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double additionalComsumption = 1.6;
        private const double keptFuelInTank = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
        {
        }

        protected override double AdditionalComsumption => additionalComsumption;

        public override void Refuel(double amontOfFuel)
        {
            base.FuelQuantity += (amontOfFuel * keptFuelInTank);
        }
    }
}
