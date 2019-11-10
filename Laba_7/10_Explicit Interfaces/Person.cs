using System;
using System.Collections.Generic;
using System.Text;

namespace _10_Explicit_Interfaces
{
    class Person : IPerson, IResident
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public void GetName()
        {
            //if (this.GetType().Name == "IPerson")
                Console.WriteLine(this.Name);
            //if (this.GetType().Name == "IResident")
                Console.WriteLine($"Mr/Ms/Mrs {this.Name}");
        }
    }
}
