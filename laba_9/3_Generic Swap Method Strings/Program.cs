using System;
using System.Collections.Generic;

namespace _3_Generic_Swap_Method_Strings
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

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Box<string>.Swap(box[a], box[b]);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(box[i]);
            }
        }
    }
}
