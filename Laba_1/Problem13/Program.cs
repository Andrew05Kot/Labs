using System;

namespace Problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool b;

            Console.Write("Input n: ");
            n = Convert.ToInt32(Console.ReadLine());

            b = ((n % 9 == 0) || (n % 11 == 0) || (n % 13 == 0)) ? true : false;
            Console.WriteLine(b);
        }
    }
}
