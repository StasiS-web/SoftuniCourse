using System;

namespace ShoppingSpree
{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(string productName, decimal productCost)
        {
            this.ProductName = productName;
            this.Cost = productCost;
        }

        public string ProductName
        {
            get => this.name;
            private set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"{nameof(ProductName)} cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Cost
        {
            get => this.cost;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.cost = value;
            }
        }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
