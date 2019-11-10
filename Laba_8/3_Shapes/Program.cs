using System;

namespace _3_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(3, 4);
            Console.WriteLine(rectangle.Draw());
            Shape circle = new Circle(3);
            Console.WriteLine(circle.Draw());
        }
    }
}
