using System;
using System.Collections.Generic;
using System.Text;

namespace _6_Birthday_Celebrations
{
    interface ICitizen
    {
        string Type { get; set; }
        string Name { get; set; }
        int Age { get; set; }
        string Id { get; set; }
        string Birthdate { get; set; }

        void Date(string year);
    }
}
