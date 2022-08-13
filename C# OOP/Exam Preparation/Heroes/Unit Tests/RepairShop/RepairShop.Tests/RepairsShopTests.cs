using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace RepairShop.Tests
{
    public class Tests
    {
        public class RepairsShopTests
        {
            [Test]
            public void Constructor_ShouldWorksCorrectlly()
            {
                string name = "Ring Auto";
                int mechanic = 1;

                Garage garage = new Garage(name, mechanic);

                Assert.AreEqual(name, garage.Name);
                Assert.AreEqual(mechanic, garage.MechanicsAvailable);
            }

            [Test]
            public void GetterName_ShouldWorksCorrectlly()
            {
                string name = "Ring Auto";
                Garage garage = new Garage(name, 1);

                Assert.AreEqual(name, garage.Name);
            }

            [Test]
            public void SetterNameValidation_ShouldThrowsException()
            {
                Garage garage;

                Assert.Throws<ArgumentNullException>(() =>
                {
                    garage = new Garage(null, 1);
                }, "Invalid garage name.");
            }

            [Test]
            public void GetterMechanicsAvailable_ShouldWorksCorrectlly()
            {
                Garage garage = new Garage("Ring Auto", 2);
                int expectedMechanicsAvailable = 2;
                int actualMechanicsAvailable = garage.MechanicsAvailable;

                Assert.AreEqual(expectedMechanicsAvailable, actualMechanicsAvailable);
            }

            [Test]
            public void SetterMechanicsAvailableValidation_ShouldThrowsException()
            {
                Garage garage;

                Assert.Throws<ArgumentException>(() =>
                {
                    garage = new Garage("Ring Auto", 0);
                }, "At least one mechanic must work in the garage.");
            }

            [Test]
            public void Counter_ShouldWorksCorrectlly()
            {
                Garage garage = new Garage("Ring Auto", 3);
                int expectedCounter = 3;

                Assert.AreEqual(expectedCounter, garage.MechanicsAvailable);
            }

            [Test]
            public void AddMethod_ShouldWorksCorrectlly()
            {
                Garage garage = new Garage("Ring Auto", 2);

                Car carAudi = new Car("Audi", 3);
                Car carLexus = new Car("Lexus", 4);
                List<Car> carList = new List<Car>();

                carList.Add(carAudi);
                carList.Add(carLexus);

                Assert.AreEqual(carList.Count, garage.MechanicsAvailable);
            }

            [Test]
            public void AddMethod_ShouldThrowsException()
            {
                Garage garage = new Garage("Ring Auto", 1);

                Car carAudi = new Car("Audi", 3);
                Car carLexus = new Car("Lexus", 10);

                garage.AddCar(carAudi);
                
                Assert.Throws<InvalidOperationException>(() =>
                {
                    garage.AddCar(carLexus);

                }, "No mechanic available.");
            }

            [Test]
            public void FixMethod_ShouldWorksCorrectlly()
            {
                Car carToFix = new Car("Lexus", 3);

                string expectedModel = "Lexus";
                string actualModel = carToFix.CarModel;
                int expectedIssues = 3;
                int actualIssues = carToFix.NumberOfIssues;

                Assert.AreEqual(expectedModel, actualModel);
                Assert.AreEqual(expectedIssues, actualIssues);
            }

            [Test]
            public void FixMethod_ShouldThrowsException()
            {
                var garage = new Garage("Ring Auto", 1);
                Car carToFix = new Car(null, 0);
                
                Assert.Throws<InvalidOperationException>(() =>
                {
                    garage.FixCar(carToFix.ToString());
                }, $"The car {carToFix.CarModel} doesn't exist.");
            }

            [Test]
            public void RemoveFixedCarMethod_ShouldWorksCorrectlly()
            {
                const string carModel = "Lexus";

                Garage garage = new Garage("Ring Auto", 3);
                Car carAudi = new Car("Audi", 3);
                Car carBmw = new Car("BMW", 50);
                Car carLexus = new Car(carModel, 4);

                garage.AddCar(carAudi);
                garage.AddCar(carLexus);
                garage.AddCar(carBmw);
                garage.FixCar(carModel);
                var fixedCar = garage.RemoveFixedCar();

                Assert.That(fixedCar, Is.EqualTo(1));
                Assert.That(garage.CarsInGarage, Is.EqualTo(2));
            }

            [Test]
            public void RemoveFixedCarMethod_ShouldThrowsException()
            {
                const string carModel = "Lexus";
                Garage garage = new Garage("Ring Auto", 3);
                Car carAudi = new Car("Audi", 3);
                Car carLexus = new Car(carModel, 3);

                Assert.Throws<InvalidOperationException>(() =>
                {
                    garage.RemoveFixedCar();
                }, $"No fixed cars available.");
            }

            [Test]
            public void Report_ShouldWorksCorrectlly()
            {
                const string carModel = "Lexus";

                Garage garage = new Garage("Ring Auto", 3);
                Car carAudi = new Car("Audi", 3);
                Car carBmw = new Car("BMW", 50);
                Car carLexus = new Car(carModel, 4);
                
                garage.AddCar(carAudi);
                garage.AddCar(carLexus);
                garage.AddCar(carBmw);
                garage.FixCar(carModel);
                var report = garage.Report();
                
                Assert.That(report, Is.EqualTo($"There are 2 which are not fixed: Audi, BMW."));
            }

        }
    }
}