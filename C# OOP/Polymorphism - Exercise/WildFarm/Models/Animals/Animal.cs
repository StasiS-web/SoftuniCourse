using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Interfaces;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        private string _name;
        private double _weight;
        private int _foodEaten;

        public Animal(string name, double weight, double weightModifier)
        {
            this.Name = name;
            this.Weight = weight;
            this.WeightModifier = weightModifier;
        }

        protected double WeightModifier { get; set; }

        public string Name 
        { 
            get => this._name; 
            private set { this._name = value; }
        }

        public double Weight
        { 
            get => this._weight; 
            protected set { this._weight = value; }
        }

        public int FoodEaten
        {
            get => this._foodEaten;
            protected set { this._foodEaten = value; }
        }

        public abstract string ProduceSound();
        public abstract void EatFood(Food food);
    }
}
