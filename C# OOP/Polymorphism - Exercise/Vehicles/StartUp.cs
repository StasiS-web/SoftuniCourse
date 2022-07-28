using System;
using Vehicles.Models;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string[] truckInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string[] busInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int n = int.Parse(Console.ReadLine());

                var car = CreateVehicle(carInfo);
                var truck = CreateVehicle(truckInfo);
                var bus = CreateVehicle(busInfo);

                for (int i = 0; i < n; i++)
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
                    else if (type == nameof(Bus))
                    {
                        Execute(bus, cmdArgs, distanceOrLiters);
                    }
                }

                Console.WriteLine(car);
                Console.WriteLine(truck);
                Console.WriteLine(bus);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static Vehicle CreateVehicle(string[] vehicheInfo)
        {
            Vehicle vehicle = null;

            if (vehicheInfo[0] == nameof(Car))
            {
                vehicle = new Car(double.Parse(vehicheInfo[1]), double.Parse(vehicheInfo[2]), double.Parse(vehicheInfo[3]));
            }
            else if (vehicheInfo[0] == nameof(Truck))
            {
                vehicle = new Truck(double.Parse(vehicheInfo[1]), double.Parse(vehicheInfo[2]), double.Parse(vehicheInfo[3]));
            }
            else if (vehicheInfo[0] == nameof(Bus))
            {
                vehicle = new Bus(double.Parse(vehicheInfo[1]), double.Parse(vehicheInfo[2]), double.Parse(vehicheInfo[3]));
            }

            return vehicle;
        }

        private static void Execute(Vehicle vehicle, string cmdArgs, double value)
        {
            if (cmdArgs == "Drive")
            {
                Console.WriteLine(vehicle.Drive(value));
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
            else if (cmdArgs == "DriveEmpty")
            {
                ((Bus)vehicle).SwitchOnAirConditionerStatus();
                Console.WriteLine(vehicle.Drive(value));
                ((Bus)vehicle).SwitchOffAirConditionerStatus();
            }
        }
    }
}
