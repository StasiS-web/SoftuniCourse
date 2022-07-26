using System;
using Vehicles.Models;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] truckInfo = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(Console.ReadLine());

            var car = CreateVehicle(carInfo);
            var truck = CreateVehicle(truckInfo);

            for (int i = 0; i < n; i++)
            {
               string[] command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

               string cmdArgs = command[0];
               string type = command[1];
               double distanceOrLiters = double.Parse(command[2]);

                /* switch(cmdArgs)
                 {
                     case nameof(Car):
                         Execute(car, cmdArgs, distanceOrLiters);
                         break;

                     case nameof(Truck):
                         Execute(truck, cmdArgs, distanceOrLiters);
                         break;
                 }*/

                if (type == nameof(Car))
                 {
                     Execute(car, cmdArgs, distanceOrLiters);
                 }
                 else if (type == nameof(Truck))
                 {
                     Execute(truck, cmdArgs, distanceOrLiters);
                 } 
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
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
