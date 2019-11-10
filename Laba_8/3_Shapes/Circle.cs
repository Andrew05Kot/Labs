using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Shapes
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double CalculatePerimeter() => 3.14 * 2 * Radius;
        public override double CalculateArea() => 3.14 * Radius * Radius;

        public override string Draw()
        {
            return "IS A CIRCLE!" + base.Draw();
        }
    }
}
