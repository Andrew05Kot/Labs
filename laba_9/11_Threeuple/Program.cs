using System;

namespace _11_Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var parametrs = Console.ReadLine().Split();
            string FirstName = parametrs[0];
            string LastName = parametrs[1];
            string Address = parametrs[2];
            string Town = parametrs[2];
            parametrs = Console.ReadLine().Split();
            string Name = parametrs[0];
            int LitersOfBeer = Convert.ToInt32(parametrs[1]);
            bool DrunkOrNot;
            if (parametrs[2] == "drunk")
            {
                DrunkOrNot = true;
            }
            else
            {
                DrunkOrNot = false;
            }
            parametrs = Console.ReadLine().Split();
            string NewName = parametrs[0];
            decimal AccountBalance = Convert.ToDecimal(parametrs[1]);
            string BankName = parametrs[2];

            Threeuple<object> threeuple = new Threeuple<object>(FirstName, LastName, Address, Town, Name, LitersOfBeer, DrunkOrNot, NewName, AccountBalance, BankName);
            threeuple.Print();
        }
    }
}
