using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Raw_Data
{
    class Engine
    {
        public int engineSpeed { get; set; }
        public int enginePower { get; set; }



        public Engine(int engineSpeed, int enginePower)
        {
            this.engineSpeed = engineSpeed;
            this.enginePower = enginePower;
        }
    }
}
