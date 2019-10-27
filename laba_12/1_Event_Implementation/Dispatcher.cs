using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Event_Implementation
{

    public delegate void NameChangeEventHandle(object sender, NameChangeEventArgs args);
    public class Dispatcher
    {
        private string name;

        public event NameChangeEventHandle NameChange;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
                OnNameChange(new NameChangeEventArgs(value));
            }
        }

        public virtual void OnNameChange(NameChangeEventArgs args)
        {
                NameChange?.Invoke(this, args);
        }
    }
}
