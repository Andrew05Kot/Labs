using System;
using System.Collections.Generic;
using System.Text;

namespace _02_King_s_Gambit
{
    class Footman
    {
        public string name;

        public Footman(string name)
        {
            this.name = name;
        }

        public void OnKingBeingAttacked(object source, EventArgs args)
        {
            Console.WriteLine($"Footman {this.name} is panicking!");
        }
    }
}
