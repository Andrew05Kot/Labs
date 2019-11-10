using System;
using System.Collections.Generic;

namespace _7_Food_Shortage
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPerson = Convert.ToInt32(Console.ReadLine());
            List <Citizen> citizens = new List<Citizen>();
            List<Rebel> rebels = new List<Rebel>();
            var parametrs = Console.ReadLine().Split();
            int i = 0, j = 0;
            int food = 0;
            
                for (int w = 0; w < numberPerson+1; w++)
                {
                    if (parametrs.Length == 4)
                    {
                        citizens.Add(new Citizen(parametrs[0], Convert.ToInt32(parametrs[1]), parametrs[2], parametrs[3]));
                        parametrs = Console.ReadLine().Split();
                        i++;
                    }
                    if (parametrs.Length == 3)
                    {
                        rebels.Add(new Rebel(parametrs[0], Convert.ToInt32(parametrs[1]), parametrs[2]));
                        parametrs = Console.ReadLine().Split();
                        j++;
                    }
                }

                string name = Console.ReadLine();

                while (name != "End")
                {
                    for (int q = 0; q < i; q++)
                    {
                        if (citizens[q].Name == name)
                        {
                            food += citizens[q].BuyFood();
                        }
                    }
                    for (int q = 0; q < j; q++)
                    {
                        if (rebels[q].Name == name)
                        {
                            food += rebels[q].BuyFood();
                        }
                    }
                    name = Console.ReadLine();
                }
              

            Console.WriteLine(food);
        }
    }
}
