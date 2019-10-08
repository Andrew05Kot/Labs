using System;

namespace Class_Box_Data_Validation
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

        }
    }
}
