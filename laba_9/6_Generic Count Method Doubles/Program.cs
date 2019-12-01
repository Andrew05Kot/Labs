using System;
using System.Collections.Generic;

namespace _6_Generic_Count_Method_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<Box<double>> box = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                box.Add(new Box<double>());
                box[i].Value = Convert.ToDouble(Console.ReadLine());
            }

            double d = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Box<double>.Check(d, box[i].Value);
            }
            Console.WriteLine(Box<double>.Count);
        }
    
    }
}
