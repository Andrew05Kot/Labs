using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Food_Shortage
{
    class Rebel: IRebel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public int Food { get; set; }

        public Rebel (string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }
        public int BuyFood()
        {
            this.Food += 5;
            return this.Food;
        }
    }
}
