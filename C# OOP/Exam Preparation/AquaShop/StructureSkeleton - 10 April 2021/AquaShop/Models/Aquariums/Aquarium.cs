using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Utilities.Messages;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string _name;

        private Aquarium()
        {
            this.Fish = new List<IFish>();
            this.Decorations = new List<IDecoration>();
        }

        protected Aquarium(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
        }

        public string Name
        {
            get => this._name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidAquariumName));
                }

                this._name = value;
            }
        }

        public int Capacity { get; }

        public int Comfort => this.Decorations.Sum(d => d.Comfort);

        public ICollection<IDecoration> Decorations { get; }

        public ICollection<IFish> Fish { get; }

        public void AddDecoration(IDecoration decoration)
        {
            this.Decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            int fishToAdd = this.Fish.Count + 1;

            if (fishToAdd > this.Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
            }

            this.Fish.Add(fish);
        }

        public bool RemoveFish(IFish fish) => this.Fish.Remove(fish);

        public void Feed()
        {
            foreach (IFish fish in this.Fish)
            {
                fish.Eat();
            }
        }

        public string GetInfo()
        {
            var sb = new StringBuilder();

            string fishResult = this.Fish.Count > 0 ? 
                String.Join(", ", this.Fish.Select(f => f.Name)) : "none";

            sb.AppendLine($"{this.Name} ({Name.GetType()}):")
                .AppendLine($"Fish: {fishResult}")
                .AppendLine($"Decorations: {this.Decorations.Count()}")
                .AppendLine($"Comfort: {this.Comfort}");

            return sb.ToString();
        }
    }
}
