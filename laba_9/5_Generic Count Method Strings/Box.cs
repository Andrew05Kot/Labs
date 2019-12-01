using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _5_Generic_Count_Method_Strings
{
    class Box <T>
    {
        public T Value { get; set; }
        public static int Count = 0;
        public static void Check(string box1, string box2)
        {
            if (box1.Length > box2.Length || String.Compare(box1, box2) > 0 )
            {
                Count++;
            }
        }

        
        public override string ToString()
        {
            return $"{Value.GetType()}: {Value}";
        }
    }
}
