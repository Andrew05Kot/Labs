using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Ferrari
{
    class Ferrari : IFerrari
    {
        public string Model { get; set; }
        public string Brankes { get; set; }
        public string GasPedal { get; set; }
        public string DriversName { get; set; }

        public Ferrari (string model, string brankes, string gasPedal, string driversName)
        {
            this.Model = model;
            this.Brankes = brankes;
            this.GasPedal = gasPedal;
            this.DriversName = driversName;
        }
        public string Display() => $"{this.Model}/{this.Brankes}!/{this.GasPedal}!/{this.DriversName}"; 
    }
}
