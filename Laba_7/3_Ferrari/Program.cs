using System;

namespace _3_Ferrari
{
    class Program
    {
        static void Main(string[] args)
        {
            string driversName = Console.ReadLine();
            Ferrari ferrari = new Ferrari("488-Spider", "Brakes", "Zadu6avam sA", driversName);
            Console.WriteLine(ferrari.Display());
        }
    }
}
