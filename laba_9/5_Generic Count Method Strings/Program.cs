using System;
using System.Collections.Generic;

namespace _5_Generic_Count_Method_Strings
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

            string str = Console.ReadLine();
            for(int i = 0; i<n;i++)
            {
                Box<string>.Check(box[i].Value, str);  
            }
            Console.WriteLine(Box<string>.Count);
        }
    }
}
