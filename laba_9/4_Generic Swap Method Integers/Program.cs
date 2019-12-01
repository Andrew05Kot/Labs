using System;
using System.Collections.Generic;

namespace _4_Generic_Swap_Method_Integers
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

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Box<int>.Swap(box[a], box[b]);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(box[i]);
            }
        }
    }
}
