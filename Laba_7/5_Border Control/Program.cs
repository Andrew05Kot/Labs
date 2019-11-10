using System;
using System.Collections.Generic;

namespace _5_Border_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Person> persons = new List<Person>();
            var parametrs = Console.ReadLine().Split();
            int i = 0;
            while(parametrs[0] != "End")
            {
                if(parametrs.Length == 2)
                {
                    persons.Add(new Person(parametrs[0], parametrs[1]));
                }
                if (parametrs.Length == 3)
                {
                    persons.Add(new Person(parametrs[0], Convert.ToInt32(parametrs[1]), parametrs[2]));
                }
                parametrs = Console.ReadLine().Split();
                i++;
            }

            string fakeId = Console.ReadLine();

            for (int j=0; j<i; j++)
            {
                persons[j].FakeIds(fakeId);
            }
            
        }
    }
}
