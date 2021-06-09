using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            /* Car car = new Car();

             car.Make = "VW";
             car.Model = "MK3";
             car.Year = 1992;
             car.FuelQuantity = 200;
             car.FuelConsumption = 200;
             car.Drive(2000);

             Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
             Console.WriteLine(car.WhoAmI());*/

            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);
            firstCar.Drive(2000);

            Console.WriteLine(firstCar.WhoAmI());
            Console.WriteLine(secondCar.WhoAmI());
            Console.WriteLine(thirdCar.WhoAmI());
        }
    }
}
