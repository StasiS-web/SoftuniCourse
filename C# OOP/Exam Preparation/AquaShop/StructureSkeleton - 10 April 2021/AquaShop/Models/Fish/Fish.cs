using System;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Utilities.Messages;

namespace AquaShop.Models.Fish
{
    public abstract class Fish : IFish
    {
        private const decimal PriceMinValue = 0;
        private string _name;
        private string _species;
        private decimal _price;

        protected Fish(string name, string species, decimal price)
        {
            this.Name = name;
            this.Species = species;
            this.Price = price;
        }

        public string Name
        {
            get => this._name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidFishName));
                }

                this._name = value;
            }
        }

        public string Species
        {
            get => this._species;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidFishSpecies));
                }

                this._species = value;
            }
        }

        public int Size { get; protected set; }

        public decimal Price
        {
            get => this._price;
            private set
            {
                if (value <= PriceMinValue)
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.InvalidFishPrice));
                }

                this._price = value;
            }
        }

        public abstract void Eat();
    }
}
