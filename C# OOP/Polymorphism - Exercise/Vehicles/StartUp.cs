using System;
using Vehicles.Models;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string carInput = Console.ReadLine();
            string truckInput = Console.ReadLine();

            string[] carInfo = carInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] truckInfo = truckInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            var car = CreateVehicle(carInfo);
            var truck = CreateVehicle(truckInfo);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    string[] command = Console.ReadLine()
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    string cmdArgs = command[0];
                    string type = command[1];
                    double distanceOrLiters = double.Parse(command[2]);
                    
                    if (type == nameof(Car))
                    {
                        Execute(car, cmdArgs, distanceOrLiters);
                    }
                    else if (type == nameof(Truck))
                    {
                        Execute(truck, cmdArgs, distanceOrLiters);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
        }

        public static Vehicle CreateVehicle(string[] vehicheInfo)
        {
            Vehicle vehicle = null;

            if (vehicheInfo[0] == nameof(Car))
            {
                vehicle = new Car(double.Parse(vehicheInfo[1]), double.Parse(vehicheInfo[2]));
            }
            else if (vehicheInfo[0] == nameof(Truck))
            {
                vehicle = new Truck(double.Parse(vehicheInfo[1]), double.Parse(vehicheInfo[2]));
            }

            return vehicle;
        }

        private static void Execute(Vehicle vehicle, string cmdArgs, double value)
        {
            if (cmdArgs == "Drive")
            {
                vehicle.Drive(value);
            }
            else if (cmdArgs == "Refuel")
            {
                try
                {
                    vehicle.Refuel(value);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }
    }
}
