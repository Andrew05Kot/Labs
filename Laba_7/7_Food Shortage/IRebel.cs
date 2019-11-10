using System;
using System.Collections.Generic;
using System.Text;

namespace _7_Food_Shortage
{
    interface IRebel
    {
        int Food { get; set; }
        int BuyFood();
    }
}
