using System;
using System.Linq;

namespace _6_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Array: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int msee = 0, n = 0, maxN = 0, q=0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        n++;
                        if (maxN < n)
                        {
                            msee = arr[i];
                            maxN = n;
                        }
                    }
                    else
                    {
                        j = arr.Length;
                    }
                }
                n = 0;
            }
            for(int i = 0; i < maxN+1; i++)
            {
                Console.Write(msee + " ");
            }

        }
    }
}
