using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Shapes
{
    class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle (double heigth, double width)
        {
            this.Height = heigth;
            this.Width = width;
        }

        public override double CalculatePerimeter() => (this.Width + this.Height) * 2;
        public override double CalculateArea() => this.Height * this.Width;

        public override string Draw()
        {
            return "IS A RECTANGLE! " + base.Draw();

        }
    }
}
