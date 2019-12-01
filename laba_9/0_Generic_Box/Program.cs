using System;

namespace _0_Generic_Box
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            Box<string> box1 = new Box<string>();
            box.Value = Convert.ToInt32(Console.ReadLine());
            box1.Value = Console.ReadLine();
            Console.WriteLine(box);
            Console.WriteLine(box1);
        }
    }
}
