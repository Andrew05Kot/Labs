using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Animal_Farm
{
    class Chicken
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (value != null && value !=" " && value !="")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty");
                }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                if (value > 0 && value < 15)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age should be between 0 and 15");
                }
            }
        }

        public Chicken (string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Display()
        {
            if (Name != null && Name != " " && Name != "" && age > 0 && age < 15)
            {
                Console.WriteLine($"Chicke {name} (age {age}) can producte 1 aggs per day");
            }
        }

    }
}
