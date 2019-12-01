using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Generic_Box_of_String
{
    class Box<T>
    {
        public T Value { get; set; }

        public override string ToString()
        {
            return $"{Value.GetType()}: {Value}";
        }

    }
}
