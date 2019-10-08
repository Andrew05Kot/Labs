using System;
using System.Collections.Generic;
using System.Text;

namespace _14_Lady_Cat
{
    class Cymric: Cat
    {
        private double furLength { get; set; }
        public Cymric(string breed, string name, double specificCharacteristics) : base(breed, name, specificCharacteristics)
        {
            furLength = specificCharacteristics;
        }
    }
}
