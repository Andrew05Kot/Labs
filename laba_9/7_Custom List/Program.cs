using System;
using System.Collections.Generic;

namespace _7_Custom_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<string> list = new Box<string>();

            var parametrs = Console.ReadLine().Split();

            while(parametrs[0]!="End")
            {
                if(parametrs[0] == "Add")
                {
                    list.Add(parametrs[1]);
                }
                if (parametrs[0] == "Remove")
                {
                    list.Remove(Convert.ToInt32(parametrs[1]));
                }
                if (parametrs[0] == "Contains")
                {
                    Console.WriteLine(Convert.ToBoolean(list.Contains(parametrs[1])));
                }
                if (parametrs[0] == "Swap")
                {
                    list.Swap(Convert.ToInt32(parametrs[1]), Convert.ToInt32(parametrs[2]));
                }
                if (parametrs[0] == "Greater")
                {
                    Console.WriteLine(list.Greater(parametrs[1]));
                }
                if (parametrs[0] == "Max")
                {
                    list.Max();
                }
                if (parametrs[0] == "Min")
                {
                    list.Min();
                }
                if (parametrs[0] == "Print")
                {
                    list.Print();
                }
                parametrs = Console.ReadLine().Split();
            }
            
        }
    }
}
