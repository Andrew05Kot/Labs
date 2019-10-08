using System;
using System.Collections.Generic;
using System.Text;

namespace _14_Lady_Cat
{
    class StreetExtraordinaire: Cat
    {
        private int decibelsOfMeows { get; set; }

        public StreetExtraordinaire(string breed, string name, double specificCharacteristics) : base(breed, name, specificCharacteristics)
        {
            decibelsOfMeows = Convert.ToInt32(specificCharacteristics); ;
        }
    }
    
}
