using System;
using System.Collections.Generic;
using System.Text;

namespace _10_Explicit_Interfaces
{
    interface IResident
    {
        string Name { get; set; }
        string Country { get; set; }

        void GetName();
    }
}
