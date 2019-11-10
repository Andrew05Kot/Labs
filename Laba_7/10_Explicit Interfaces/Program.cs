using System;
using System.Collections.Generic;

namespace _10_Explicit_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            var parametrs = Console.ReadLine().Split();
            int i = 0;
            while (parametrs[0] != "End")
            {
                persons.Add(new Person());
                persons[i].Name = parametrs[0];
                persons[i].Country = parametrs[1];
                persons[i].Age = Convert.ToInt32(parametrs[2]);
                parametrs = Console.ReadLine().Split();
                i++;
            }

            for(int j = 0; j < i; j++)
            {
                persons[j].GetName();
            }
        }
    }
}
