using System;
using System.Collections.Generic;
using System.Text;

namespace _5_King_s_Gambit_Extended
{
    class Footman
    {
        public string name;
        public int numberLives = 2;

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
