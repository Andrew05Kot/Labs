using System;
using System.Collections.Generic;

namespace _6_Birthday_Celebrations
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
                if (parametrs[0] == "Robot")
                {
                    persons.Add(new Person(parametrs[1], parametrs[2]));
                }
                if (parametrs[0] == "Citizen")
                {
                    persons.Add(new Person(parametrs[0], parametrs[1], Convert.ToInt32(parametrs[2]), parametrs[3], parametrs[4]));
                }
                if (parametrs[0] == "Pet")
                {
                    persons.Add(new Person(parametrs[0], parametrs[1], parametrs[2]));
                }
                parametrs = Console.ReadLine().Split();
                i++;
            }

            string year = Console.ReadLine();
            for (j = 0; j < i; j++)
            {
                if (persons[j].Type == "Citizen" || persons[j].Type == "Pet")
                {
                    persons[j].Date(year);
                    r++;
                }
            }
        }
    }
}
