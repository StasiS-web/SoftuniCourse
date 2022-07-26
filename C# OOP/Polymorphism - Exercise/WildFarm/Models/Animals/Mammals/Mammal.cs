using System;
using System.Collections.Generic;
using WildFarm.Interfaces;

namespace WildFarm.Models.Animals.Mammals
{
    public abstract class Mammal : Animal, IMammal
    {
        public Mammal(string name, double weight, double weightModifier, string livingRegion) 
            : base(name, weight, weightModifier)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion {get; set;}
    }
}
