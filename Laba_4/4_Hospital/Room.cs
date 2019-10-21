using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Hospital
{
    class Room
    {
        public Room()
        {
            this.Patients = new List<string>();
        }

        public List<string> Patients { get; set; }
    }
}
