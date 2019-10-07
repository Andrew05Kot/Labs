using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace Task_1
{
    class Person : Data
    {
        private string surname { get; set; }
        private string name { get; set; }
        private string sex { get; set; }
        private string occupation { get; set; }
        private int[] Date { get; set; }

        public Person(string surname, string name, int[] data, string sex, string occupation):
            base(data)
        {
            this.surname = surname;
            this.name = name;
            this.Date = data;
            this.sex = sex;
            this.occupation = occupation;
        }

        public virtual void Display()
        {
            Console.WriteLine($"{this.surname} {this.name} {this.Date[0]} {this.Date[1]} {this.Date[2]}  {this.sex} {this.occupation} ");
        }

    }
}
