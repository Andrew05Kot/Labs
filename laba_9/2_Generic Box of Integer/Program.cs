using System;
using System.Collections.Generic;

namespace _2_Generic_Box_of_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<Box<int>> box = new List<Box<int>>();

            for (int i = 0; i < n; i++)
            {
                box.Add(new Box<int>());
                box[i].Value = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(box[i]);
            }
        }
    }
}
