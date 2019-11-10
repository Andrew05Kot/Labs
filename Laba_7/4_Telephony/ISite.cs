using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Telephony
{
    interface ISite
    {
        string Url { get; set; }

        void Browsing();
    }
}
