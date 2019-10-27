using System;
using System.Collections.Generic;
using System.Text;

namespace _02_King_s_Gambit
{
    class Royal_Guard
    {
        public string name;

        public Royal_Guard(string name)
        {
            this.name = name;
        }

        public void OnKingBeingAttacked(object source, EventArgs args)
        {
            Console.WriteLine($"Royal Guard {this.name} is defending!");
        }

    }
}
