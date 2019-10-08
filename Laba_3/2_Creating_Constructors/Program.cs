using System;

namespace _2_Creating_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            Person first = new Person();
            Person second = new Person("No name");
            Person Peson3 = new Person("Peson3", 100);

            first.Name = "No name";
            first.Age = 1;

            second.Age = 18;


            Console.WriteLine(first.Name + " " + first.Age);
            Console.WriteLine(second.Name + " " + second.Age);
            Console.WriteLine(Peson3.Name + " " + Peson3.Age);
        }
    }
}
