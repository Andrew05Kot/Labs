using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Border_Control
{
    interface IRobot
    {
        string Model { get; set; }
        string Id { get; set; }

        void FakeIds(string id);
    }
}
