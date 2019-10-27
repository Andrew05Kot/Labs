using System;
using System.Collections.Generic;
using System.Text;

namespace _5_King_s_Gambit_Extended
{
    class Royal_Guard
    {
        public string name;
        public int numberLives = 3;

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
