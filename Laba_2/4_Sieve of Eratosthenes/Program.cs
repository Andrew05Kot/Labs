using System;
using System.Linq;

namespace _4_Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            n--;
            int[] arr = Enumerable.Range(2, n).ToArray();
            int i, j;

            for (j = 2; j < n; j++)
            {
                for (i = 0; i < n; i++)
                {
                    if (arr[i] != j && arr[i] % j == 0)
                    { 
                       arr[i] = 0;
                    }
                }
            }
           
           for (i = 0; i < n; i++)
            {
                if (arr[i] != 0)
                {
                    /*for (j = i; j < n - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                        n--;
                        i--;
                    }*/
                    Console.Write(arr[i] + " ");
                }
            }

           /* for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }*/

        }
    }
}
