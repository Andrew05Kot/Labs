using System;

namespace _1_Define_a_Class_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Pesho = new Person();
            Person Gosho = new Person();
            Person Stamat = new Person();

            Pesho.Name = "Pesho";
            Pesho.Age = 20;
            Gosho.Name = "Gosho";
            Gosho.Age = 18;
            Stamat.Name = "Stamat";
            Stamat.Age = 43;


            Console.WriteLine(Pesho.Name+ " " + Pesho.Age);
            Console.WriteLine(Gosho.Name + " " + Gosho.Age);
            Console.WriteLine(Stamat.Name + " " + Stamat.Age);

        }
    }
}
