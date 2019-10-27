using System;
using System.Collections.Generic;
using System.Text;

namespace _5_King_s_Gambit_Extended
{
    class King
    {
        public King(string name)
        {
            this.Name = name;
        }

        public event EventHandler BeingAttacked;

        public string Name { get; set; }

        public void TakeAttack()
        {
            this.OnBeingAttacked();
        }

        protected virtual void OnBeingAttacked()
        {
            Console.WriteLine($"King {this.Name} is under attack!");
            BeingAttacked?.Invoke(this, EventArgs.Empty);
        }
    }
}
