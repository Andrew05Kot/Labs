using System;
using System.Collections.Generic;
using System.Text;


namespace _14_Lady_Cat
{
    class Cat
    {
        private string breed { get; set; }
        private string name { get; set; }
        private double specificCharacteristics { get; set; }

        public Cat(string breed, string name, double specificCharacteristics)
        {
            this.breed = breed;
            this.name = name;
            this.specificCharacteristics = specificCharacteristics;
        }
        public Cat()
        {
        }
        public override string ToString()
        {
            return $"{this.breed} {this.name} {this.specificCharacteristics}";
        }
    }
}
