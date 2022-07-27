using System;
using Vehicles.Common;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        private double _fuelQuantity;
        private double _fuelComsumption;
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        public double FuelQuantity 
        { 
            get => this._fuelQuantity; 
            set 
            { 
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format(ErrorMessages.InvalidFuel));
                }
                
                this._fuelQuantity = value; 
            }
        }

        public virtual double FuelConsumption 
        {
            get => this._fuelComsumption;
            set { this._fuelComsumption = value; }
        }


        protected abstract double AdditionalComsumption { get; }

        public virtual void Refuel(double amontOfFuel)
        {
            this.FuelQuantity += amontOfFuel;
        }

        public virtual string Drive(double distance)
        {
            string message;
            FuelQuantity -= distance * (FuelConsumption + AdditionalComsumption);

            if (FuelQuantity < 0)
            {
                message = String.Format(ErrorMessages.RefuelingMessage, this.GetType().Name);
                FuelQuantity += distance * FuelConsumption;
            }
            else
            {
                message = String.Format(ErrorMessages.TravelledDistance, this.GetType().Name, distance);
            }

            return message;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelConsumption:F2}";
        }
    }
}
