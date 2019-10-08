using System;
using System.Collections.Generic;
using System.Linq;

namespace _4__Opinion_Poll
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of people: ");
            int numberOfPeople = int.Parse(Console.ReadLine());

            var persons = new List<Person>();

            Console.WriteLine("Enter the name and age of people: ");
            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                persons.Add(new Person(parameters[0], Convert.ToInt32(parameters[1])));
            }

            persons
                .Where(x => x.Age > 30)
                .OrderBy(x => x.Name)
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
        


    }
}
