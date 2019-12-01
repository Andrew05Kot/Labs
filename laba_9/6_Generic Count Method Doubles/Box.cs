using System;
using System.Collections.Generic;
using System.Text;

namespace _6_Generic_Count_Method_Doubles
{
    class Box<T>
    {
        public T Value { get; set; }
        public static int Count = 0;
        public static void Check(double d1, double d2)
        {
            if (d1 < d2)
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
