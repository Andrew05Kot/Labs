using System;
using System.Linq;

namespace _7_Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Array: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = 0, maxN = 0, lastN = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    n++;
                    if (i + 1 == arr.Length - 1 && maxN < n)
                    {
                        maxN = n;
                        lastN = i + 1;
                    }
                }
                else
                {
                    if (maxN < n)
                    {
                        maxN = n;
                        lastN = i;
                    }
                    n = 0;
                }
            }
            maxN++;
            lastN++;
            Console.WriteLine(maxN);
            Console.WriteLine(lastN);

            for (int i = lastN-maxN; i < maxN + 1; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}
