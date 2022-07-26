using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Birds
{
    public class Hen : Bird
    {
        private const double modifier = 0.35;

        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, modifier, wingSize)
        {
        }

        public override string ProduceSound() => "Cluck";

        public override void EatFood(Food food)
        {
            Weight += food.Quantity * modifier;
            FoodEaten += food.Quantity;
        }
    }
}
