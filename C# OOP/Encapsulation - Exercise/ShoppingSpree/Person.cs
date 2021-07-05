using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            products = new List<Product>();
        }

        public List<Product> Products { get => products; set => products = value; }

        public string Name
        {
           get => this.name;
           set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(Name)} cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get => this.money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public void BuyProduct(Product product)
        {
            if (Money >= product.Cost)
            {
                this.products.Add(product);
                this.Money -= product.Cost;
            }
            else throw new ArgumentException($"{Name} can't afford {product.ProductName}");
        }

        public override string ToString()
        {
            if (Products.Count == 0)
            {
                return $"{Name} - Nothing bought ";
            }

            return $"{Name} - {string.Join(", ", Products.Select(x => x.ToString()))}";
        }
    }
}
