using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Box_Data_Validation
{
    class Class_Box
    {
        private double length;
        private double width;
        private double height;
        public double Length
        {
            get
            {
                return length;
            }
            private set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("Length cannot be zero or negative");
                }
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            private set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Width cannot be zero or negative");
                }
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            private set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Height cannot be zero or negative");
                }
            }
        }

        public Class_Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

    }
}
