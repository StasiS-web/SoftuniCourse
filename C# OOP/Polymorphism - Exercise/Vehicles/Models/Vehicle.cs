using System;
using Vehicles.Common;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        private double _tankCapacity;
        private double _fuelQuantity = 0;
        private double _fuelComsumption;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get => this._fuelQuantity;
            protected set
            {
                if (this.FuelQuantity + value > this.TankCapacity && value <= 0)
                {
                    throw new ArgumentException(String.Format(ErrorMessages.InvalidFuel));
                }

                this._fuelQuantity = value;
            }
        }

        public virtual double FuelConsumption
        {
            get => this._fuelComsumption;
            protected set { this._fuelComsumption = value + AdditionalComsumption; }
        }

        public double TankCapacity
        {
            get => this._tankCapacity;
            set { this._tankCapacity = value; }
        }

        protected abstract double AdditionalComsumption { get; }

        public virtual void Refuel(double amontOfFuel)
        {
            if (amontOfFuel <= 0)
            {
                throw new ArgumentException(String.Format(ErrorMessages.InvalidFuel));
            }

            double extraFuel = amontOfFuel;

            if (this._fuelQuantity + extraFuel > this.TankCapacity)
            {
                throw new ArgumentException(String.Format(ErrorMessages.AvailableSpaceForFuel, amontOfFuel));
            }

            this.FuelQuantity += amontOfFuel;
        }

        public virtual string Drive(double distance)
        {
            string message;
            double fuelNeeded = distance * FuelConsumption;

            if (fuelNeeded > FuelQuantity)
            {
                message = string.Format(ErrorMessages.RefuelingMessage, GetType().Name);
            }
            else
            {
                FuelQuantity -= fuelNeeded;
                message = string.Format(ErrorMessages.TravelledDistance, GetType().Name, distance);
            }

            return message;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
