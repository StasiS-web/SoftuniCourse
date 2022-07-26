using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals.Felines
{
    public class Tiger : Feline
    {
        private const double modifier = 1.00;

        public Tiger(string name, double weight, string livingRegion, string breed) 
           : base(name, weight, modifier, livingRegion, breed)
        {
        }

        public override string ProduceSound() => "ROAR!!!";

        public override void EatFood(Food food)
        {
            if(food is Meat)
            {
                Weight += food.Quantity * modifier;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{nameof(Tiger)} does not eat {food.GetType().Name}!");
            }
        }
    }
}
