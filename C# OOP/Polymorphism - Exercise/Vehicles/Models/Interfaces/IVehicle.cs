namespace Vehicles.Models.Interfaces
{
    public interface IVehicle
    {
        public double FuelQuantity { get; }
        public double FuelConsumption { get; }
        public double TankCapacity { get; set; }
        public void Refuel(double amontOfFuel);
        public string Drive(double distance);
    }
}
