using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Telephony
{
    interface INumber
    {
        string Number { get; set; }

        void Calling();
    }
}
