using System;
using System.Collections.Generic;
namespace _3_Oldest_Family_Member
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of people: ");
            Family.n = int.Parse(Console.ReadLine());

            Family[] p = new Family[Family.n];

            for (int i = 0; i < Family.n; i++)
            {
                p[i] = new Family();
                p[i].AddMember();
            }


            int max = p[0].Age;
            int a = 0;
            for(int i =0; i < Family.n; i++)
            {
                if (p[i].Age > max)
                {
                    max = p[i].Age;
                    a = i;
                }
            }

            Console.WriteLine("The oldest member of the family: " + p[a].Name + " " + p[a].Age);
        }
    }
}
