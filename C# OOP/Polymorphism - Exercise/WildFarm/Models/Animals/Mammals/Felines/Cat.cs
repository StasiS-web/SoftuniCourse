using System;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals.Felines
{
    public class Cat : Feline
    {
        private const double modifier = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, modifier, livingRegion, breed)
        {
        }

        public override string ProduceSound() => "Meow";

        public override void EatFood(Food food)
        {
            if (food is Vegetable || food is Meat)
            {
                Weight += food.Quantity * modifier;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{nameof(Cat)} does not eat {food.GetType().Name}!");
            }
        }

    }
}
