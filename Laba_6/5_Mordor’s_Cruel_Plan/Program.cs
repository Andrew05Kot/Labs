using System;

namespace _5_Mordor_s_Cruel_Plan
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] parameters = Console.ReadLine().Split(new[] { ' ' });
            for(int i=0;i< parameters.Length; i++)
            {
                FoodFactory food = new FoodFactory(parameters[i].ToLower());
            }
            Console.WriteLine(MoodFactory.happiness);
            Console.WriteLine(MoodFactory.Happiness());
        }
    }
}
