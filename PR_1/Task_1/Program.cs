using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number people: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string surname;
            string name;
            int[] Date;
            string sex;
            string occupation;
            int QueueCount;

            //Data data = new Data(Date);


            Queue[] Persons = new Queue[n];

            for(int i = 0; i < n; i++)
            {
                surname = Console.ReadLine();
                name = Console.ReadLine();
                Date = Console.ReadLine().Split().Select(int.Parse).ToArray();
                sex = Console.ReadLine();
                occupation = Console.ReadLine();
                QueueCount = int.Parse(Console.ReadLine());
                Persons[i] = new Queue(surname, name, Date, sex, occupation, QueueCount);
            }

            for (int i = 0; i < n; i++)
            {
                if(Convert.ToInt32(Persons[i].queueCount) == 1)
                {
                    Persons[i].Display();
                }
            }

            /*Приклад введення даних:
              Enter number people:
              2
              Kot
              Andrey
              05 02 2001
              men
              developer
              1*/


        }
    }
}

