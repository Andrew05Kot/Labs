using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Shapes
{
    abstract class Shape
    {
        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();
        public virtual string Draw()
        {
            return $"{Environment.NewLine}Perimeter: {CalculatePerimeter()} Area: {CalculateArea()} ";
        }
    }
}
