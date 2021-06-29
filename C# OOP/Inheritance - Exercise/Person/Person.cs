using System;
using System.Text;

namespace Person
{
    public class Person
    {
        //Fiields
        private int age;

        //Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //Properties
        public string Name { get; set; }

        public virtual int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }

                age = value;
            }

        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Name: {this.Name}, Age: {this.Age}");
            return stringBuilder.ToString();
        }
    }
}
