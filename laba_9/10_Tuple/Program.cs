using System;

namespace _10_Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var parametrs = Console.ReadLine().Split();
            string FirstName = parametrs[0];
            string LastName = parametrs[1];
            string Address = parametrs[2];
            parametrs = Console.ReadLine().Split();
            string Name = parametrs[0];
            int LitersOfBeer = Convert.ToInt32(parametrs[1]);
            parametrs = Console.ReadLine().Split();
            int Integer = Convert.ToInt32(parametrs[0]);
            double Double = Convert.ToDouble(parametrs[1]);

            Tuple<object> turple = new Tuple<object>(FirstName, LastName, Address, Name, LitersOfBeer, Integer, Double);
            turple.Print();
        }

    }
}
