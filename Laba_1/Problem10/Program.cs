using System;

namespace Problem10
{
    class Last_Digit
    {
        static void Main(string[] args)
        {
            int n, lastDigit;
            n = Convert.ToInt32(Console.ReadLine());
            double nd = Convert.ToDouble(n);
            n /= 10;
            nd /= 10.0d;
            n *= 10;
            nd *= 10;
            lastDigit = Convert.ToInt32(nd - n);

            Console.WriteLine(lastDigit);

            Console.ReadLine();
        }
    }
}
