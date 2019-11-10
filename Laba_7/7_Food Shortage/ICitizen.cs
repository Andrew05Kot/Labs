using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Food_Shortage
{
    interface ICitizen
    {
        string Name { get; set; }
        int Age { get; set; }
        string Id { get; set; }
        string Birthdate { get; set; }

        int BuyFood();
    }
}
