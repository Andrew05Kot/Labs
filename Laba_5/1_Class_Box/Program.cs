using System;

namespace _1_Class_Box
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height ");
            double height = Convert.ToDouble(Console.ReadLine());

            Class_Box box1 = new Class_Box(length, width, height);

            Console.WriteLine("Surface Area: " + box1.SurfaceArea());
            Console.WriteLine("Lateral Surface Area: " + box1.LateralSurfaceArea());
            Console.WriteLine("Volume: " + box1.Volume());
        }
    }
}
