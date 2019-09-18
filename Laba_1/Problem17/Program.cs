using System;

namespace Problem17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, factorial=1;

            n = Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i<=n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("factorial = " + factorial);

        }
    }
}
