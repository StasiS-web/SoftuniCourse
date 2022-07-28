using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Common;
using Vehicles.Models.Enumeration;

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double _additionalFuelConsumption = 1.4;
        private AirConditionerStatus _airConditionerStatus;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this._airConditionerStatus = AirConditionerStatus.On;
        }

        protected override double AdditionalComsumption => 
            _airConditionerStatus == AirConditionerStatus.On
            ? _additionalFuelConsumption
            : (double)AirConditionerStatus.Off;

        public void SwitchOnAirConditionerStatus() => this._airConditionerStatus = AirConditionerStatus.On;

        public void SwitchOffAirConditionerStatus() => this._airConditionerStatus = AirConditionerStatus.Off;
    }
}
