using System;
using System.Collections.Generic;
using System.Linq;

namespace _14_Lady_Cat
{
    class Siamese: Cat
    {
        
        private int earSize { get; set; }
        

        public Siamese(string breed, string name, double specificCharacteristics) : base(breed, name, specificCharacteristics)
        {
            earSize = Convert.ToInt32(specificCharacteristics);
        }
        
    }
}
