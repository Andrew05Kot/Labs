using System;
using System.Collections.Generic;
using System.Text;

namespace _6_Birthday_Celebrations
{
    class Person : ICitizen, IRobot, IPet
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Model { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }

        public Person(string type, string name, int age, string id, string birthdate)
        {
            this.Type = type;
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }
        public Person(string model, string Id)
        {
            this.Type = "Robot";
            this.Model = model;
            this.Id = Id;
        }
        public Person(string type, string name, string birthdate)
        {
            this.Type = type;
            this.Name = name;
            this.Birthdate = birthdate;
        }
        public void Date(string year)
        {
            if (this.Birthdate.EndsWith(year))
            {
                Console.WriteLine(this.Birthdate);
            }           
        }
    }
}
