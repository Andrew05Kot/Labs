using System;
using System.Collections.Generic;
using System.Text;

namespace _11_Threeuple
{
    class Threeuple <T>
    {
        public T FirstName { get; set; }
        public T LastName { get; set; }
        public T Address { get; set; }
        public T Town { get; set; }
        public T Name { get; set; }
        public T LitersOfBeer { get; set; }
        public T DrunkOrNot { get; set; }
        public T NewName { get; set; }
        public T AccountBalance { get; set; }
        public T BankName { get; set; }

        public Threeuple(T firstName, T lastName, T address, T town, T name, T litersOfBeer, T drunkOrNot, T newName, T accountBalance, T bankName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Town = town;
            this.Name = name;
            this.LitersOfBeer = litersOfBeer;
            this.DrunkOrNot = drunkOrNot;
            this.NewName = newName;
            this.AccountBalance = accountBalance;
            this.BankName = bankName;
        }
        public void Print()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName} -> {this.Address} -> {this.Town}");
            Console.WriteLine($"{this.Name} ->  {this.LitersOfBeer} -> {this.DrunkOrNot}");
            Console.WriteLine($"{this.NewName} -> {this.AccountBalance} -> {this.BankName}");
        }
    }
}
