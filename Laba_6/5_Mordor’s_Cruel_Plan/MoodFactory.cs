using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Mordor_s_Cruel_Plan
{
    class MoodFactory
    {
        public static int happiness;

        public static string Happiness()
        {
            if(happiness < -5)
            {
                return "Angry";
            }
            else if(happiness >= -5 && happiness <= 0)
            {
                return "Sad";
            }
            else if (happiness >= 1 && happiness <= 15)
            {
                return "Happy";
            }
            else
            {
                return "JavaScript";
            }
        }

    }
}
