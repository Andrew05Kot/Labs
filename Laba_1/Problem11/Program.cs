using System;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            double number, n, nD, k;
            int nDigit;

            Console.WriteLine("Input number: ");
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input n: ");
            n = Convert.ToDouble(Console.ReadLine());

            k = Math.Pow(10, n - 1);

            nD = number / k;
            nDigit = Convert.ToInt32(nD % 10);

            if (nDigit > 0)
            {
                Console.WriteLine("Result: " + nDigit);
            }
            else
            {
                Console.WriteLine("Result:  -  " );
            }

            

        }
    }
}
