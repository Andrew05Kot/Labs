using System;
using System.Collections.Generic;

namespace _1_Generic_Box_of_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<Box<string>> box = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                box.Add(new Box<string>());
                box[i].Value = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(box[i]);
            }
        }
    }
}
