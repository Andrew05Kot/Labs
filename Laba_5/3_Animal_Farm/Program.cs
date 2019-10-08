using System;

namespace _3_Animal_Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());

            Chicken kok = new Chicken(name, age);
            kok.Display();
            
        }
    }
}
