using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Generic_Swap_Method_Strings
{
    class Box<T>
    {
        public T Value { get; set; }
        public static void Swap(Box<T> box , Box<T> box1)
        {
            T str = box.Value;
            box.Value = box1.Value;
            box1.Value = str;
        }
        public override string ToString()
        {
            return $"{Value.GetType()}: {Value}";
        }
    }
}