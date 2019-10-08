using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Creating_Constructors
{
    class Person
    {
        private string name;
        private int age;

        public string Name
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
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
        public Person()
        {
        }
        public Person(string n)
        {
            name = n;
        }
        public Person(string n, int a)
        {
            name = n;
            age = a;
        }
    }
}
