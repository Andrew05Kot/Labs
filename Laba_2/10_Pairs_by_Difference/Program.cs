using System;
using System.Linq;

namespace _10_Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = Convert.ToInt32(Console.ReadLine());
            int r = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] - arr[j] == n)
                    {
                        r++;
                    }
                }
            }
            Console.WriteLine("Pairs by Difference: " + r);
        }
    }
}
