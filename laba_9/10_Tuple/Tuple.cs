using System;
using System.Collections.Generic;
using System.Text;

namespace _10_Tuple
{
    class Tuple<T>
    {
        public T FirstName { get; set; }
        public T LastName { get; set; }
        public T Address { get; set; }
        public T Name { get; set; }
        public T LitersOfBeer { get; set; }
        public T Integer { get; set; }
        public T Double { get; set; }

        public Tuple (T firstName, T lastName, T address, T name, T litersOfBeer, T integer, T ddouble)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Name = name;
            this.LitersOfBeer = litersOfBeer;
            this.Integer = integer;
            this.Double = ddouble;
        }
        public void Print()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName} ->  {this.Address}");
            Console.WriteLine($"{this.Name} ->  {this.LitersOfBeer}");
            Console.WriteLine($"{this.Integer} ->  {this.Double}");
        }
    }
}
