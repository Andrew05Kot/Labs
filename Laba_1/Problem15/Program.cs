using System;

namespace Problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string product;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            product = (a * b * c >= 0) ? "positive" : "negative";

            Console.WriteLine(product);

        }
    }
}
