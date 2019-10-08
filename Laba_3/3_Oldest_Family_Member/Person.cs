using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Oldest_Family_Member
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
        public Person(string n, int a)
        {
            name = n;
            age = a;
        }
        public Person()
        {

        }
    }
}
