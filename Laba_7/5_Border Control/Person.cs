using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Border_Control
{
    class Person : ICitizen, IRobot
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Model { get; set; }
        public string Id { get; set; }

        public Person(string name, int age, string Id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = Id;
        }
        public Person(string model, string Id)
        {
            this.Model = model;
            this.Id = Id;
        }

        public void FakeIds(string id)
        {
            if (this.Id.EndsWith(id))
            {
                Console.WriteLine(this.Id);
            }
        }
    }
}
