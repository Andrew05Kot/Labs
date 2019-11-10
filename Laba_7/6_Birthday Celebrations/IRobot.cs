using System;
using System.Collections.Generic;
using System.Text;

namespace _6_Birthday_Celebrations
{
    interface IRobot
    {
        string Type { get; set; }
        string Model { get; set; }
        string Id { get; set; }
    }
}
