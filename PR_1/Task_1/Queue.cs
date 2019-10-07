using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Queue: Person
    {
        private string surname;
        public string Surname
        {
            get
            {
                return Surname;
            }
            set
            {
                Surname = value;
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        private string sex;
        public string Sex
        {
            get
            {
                return Sex;
            }
            set
            {
                Sex = value;
            }
        }
        private string occupation;
        public string Occupation
        {
            get
            {
                return Occupation;
            }
            set
            {
                Occupation = value;
            }
        }
        public int queueCount;

        public int[] Date { get; set; }
        public Queue(string surname, string name, int[] data, string sex, string occupation, int queueCount)
            :base(surname, name, data, sex, occupation)
        {
            this.name = name;
            this.surname = surname;
            this.Date = data;
            this.sex = sex;
            this.occupation = occupation;
            this.queueCount = queueCount;
        }
        
        public override void Display()
        {
            Console.WriteLine($"{this.queueCount} {this.surname} {this.name} {this.Date[0]} {this.Date[1]} {this.Date[2]} {this.sex} {this.occupation} ");
        }


    }
}
