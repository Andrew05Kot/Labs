using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Raw_Data
{
    class Cargo
    {
        public int cargoWeight;
        public string cargoType;

        public Cargo( int cargoWeight, string cargoType)
        {
            this.cargoWeight = cargoWeight;
            this.cargoType = cargoType;
        }
    }
}
