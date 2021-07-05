using System;

namespace AnimalFarm.Models
{
    public class Chicken
    {
        private const int MinAge = 0;
        private const int MaxAge = 15;

        private string name;
        private int age;

        internal Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                this.name = value;          
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value >= MinAge && value <= MaxAge)
                {
                    this.age = value;
                }
                else throw new Exception($"Age should be between {MinAge} and {MaxAge}.");
            }
        }

        public double ProductPerDay
        {
			get
			{				
				return this.CalculateProductPerDay();
			}
        }

        private double CalculateProductPerDay() => this.Age switch
        {
            var x when x >= 0 && x < 4 => 1.5,
            var x when x >= 4 && x < 8 => 2,
            var x when x >= 8 && x < 12 => 1,
            _ => 0.75

            /*switch (this.Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }*/
        };
    }
}
