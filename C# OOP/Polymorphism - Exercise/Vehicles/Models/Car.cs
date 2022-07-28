using System;
using Vehicles.Common;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double additionalComsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumprion, double tankCapacity)
            : base(fuelQuantity, fuelConsumprion, tankCapacity)
        {
        }

        protected override double AdditionalComsumption => additionalComsumption;
    }
}
