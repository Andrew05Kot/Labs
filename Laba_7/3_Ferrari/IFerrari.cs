using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Ferrari
{
    interface IFerrari
    {
        string Model { get; set; }
        string Brankes { get; set; }
        string GasPedal { get; set; }
        string DriversName { get; set; }

        string Display();
    }
}
