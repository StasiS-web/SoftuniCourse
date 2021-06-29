using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random;

        public RandomList()
        {
            random = new Random();
        }

        public void Add(string element)
        {
            base.Add(element);
            Console.WriteLine($"Added the string {element} and we have custom functionalities");
        }

        public string RandomString()
        {
            if (Count == 0)
            {
                return "";
            }

            return this[random.Next(0, this.Count)];
        }
    }
}
