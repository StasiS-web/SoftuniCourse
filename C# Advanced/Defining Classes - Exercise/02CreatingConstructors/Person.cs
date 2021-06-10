using System;

namespace DefiningClasses
{
    public class Person
    {
        //Fields
        private string name;
        private int age; 

        //Construtor
        public Person()
        {
            Name = "No name";
            Age = 1;
        }

        public Person(int age)
            :this()
        {
            this.Age = age;
        }

        public Person(string name, int age)
            : this(age)
        {
            this.Name = name;
        }

        //Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        
    }
}
