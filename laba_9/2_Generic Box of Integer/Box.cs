using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Generic_Box_of_Integer
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
