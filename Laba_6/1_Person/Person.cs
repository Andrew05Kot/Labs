using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Person
{
    class Person
    {
        private string name;
        private int age;

        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public virtual int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                else
                {
                    age = value;
                }
            }
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));
            return stringBuilder.ToString();
        }


    }
}
