using System;
using System.Linq;

namespace _8_Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Array: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int mfn=0, n =0, maxN=0;

            for(int i =0; i < arr.Length; i++)
            {
                for(int j = i; j < arr.Length;  j++)
                {
                    if (arr[i] == arr[j])
                    {
                        n++;
                        if (maxN < n)
                        {
                            mfn = arr[i];
                            maxN = n;
                        }
                    }
                }
                n = 0;
            }
            Console.WriteLine("Most Frequent Number: " + mfn);

        }
    }
}
