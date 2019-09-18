using System;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool b;

            Console.Write("Input n: ");
            n = Convert.ToInt32(Console.ReadLine());

            b = ((n >= 20) && n % 2 != 0) ? true : false;
            Console.WriteLine(b);

        }
    }
}
