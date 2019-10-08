using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Class_Box
{
    class Class_Box
    {
        private double length { get; set; }
        private double width { get; set; }
        private double height { get; set; }

        public Class_Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double SurfaceArea()
        {
            return 2 * length * width + 2 * length * height + 2 * width * height;
        }
        public double LateralSurfaceArea()
        {
            return 2 * length * height + 2 * width * height;
        }
        public double Volume()
        {
            return length*width*height;
        }


    }
}
