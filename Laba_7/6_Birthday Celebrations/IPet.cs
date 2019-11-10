using System;
using System.Collections.Generic;
using System.Text;

namespace _6_Birthday_Celebrations
{
    interface IPet
    {
        string Type { get; set; }
        string Name { get; set; }
        string Birthdate { get; set; }

        void Date(string year);
    }
}
