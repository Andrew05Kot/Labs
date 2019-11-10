using System;
using System.Collections.Generic;
using System.Text;

namespace _10_Explicit_Interfaces
{
    interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }

        void GetName();
    }
}
