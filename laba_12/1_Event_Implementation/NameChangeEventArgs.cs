using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Event_Implementation
{
    public class NameChangeEventArgs: EventArgs
    {
        private string name;
        NameChangeEventArgs()
        {
        }
        public NameChangeEventArgs(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }
        
    }
}
