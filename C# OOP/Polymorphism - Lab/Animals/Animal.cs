﻿namespace Animals
{
    public class Animal
    {
        public Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }

        public string Name { get; private set; }

        public string FavouriteFood { get; private set; }

        public virtual string ExplainSelf() => $"I am {Name} and my fovourite food is {FavouriteFood}";

    }
}
