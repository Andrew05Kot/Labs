using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Event_Implementation
{

    class Hendler
    {
        public void OnDispatcherNameChange(object sender, NameChangeEventArgs args)
        {
            Console.WriteLine($"Dispatcher's name changed to {args.Name}.");
        }
    }
}
