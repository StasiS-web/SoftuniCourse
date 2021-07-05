using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] peoplesName = Console.ReadLine()
                         .Split(";" , StringSplitOptions.RemoveEmptyEntries)
                         .ToArray();
            string[] productsName = Console.ReadLine()
                        .Split( ";" , StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

            List<Person> people = new List<Person>();
            List<Product> allProducts = new List<Product>();

            try
            {

                for (int i = 0; i < peoplesName.Length; i++)
                {
                    string[] personInfo = peoplesName[i].Split("=");
                    Person person = new Person(personInfo[0], decimal.Parse(personInfo[1]));
                    people.Add(person);
                }
               
                for (int i = 0; i < productsName.Length; i++)
                {
                   
                    string[] productInfo = productsName[i].Split("=");
                    Product product = new Product(productInfo[0], decimal.Parse(productInfo[1]));
                    allProducts.Add(product);
                }

                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] tokens = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    string personName = tokens[0];
                    string productName = tokens[1];

                    Person customer = people.FirstOrDefault(x => x.Name == personName);
                    Product productPurchase = allProducts.FirstOrDefault(x => x.ProductName == productName);

                    try
                    {
                            customer.BuyProduct(productPurchase);
                            Console.WriteLine($"{customer.Name} bought {productPurchase.ProductName}");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                people.ForEach(p => Console.WriteLine(p.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
