using System;
using System.Linq;

namespace _11_Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Array: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum1 = 0, sum2 = 0;
            int index=0;
            bool b = false;

           

            for (int i = 0; i < arr.Length; i++)
            {
                for(int j1 = 0; j1 < i; j1++)
                {
                    sum1 += arr[j1];
                }
                for (int j1 = i; j1 < arr.Length; j1++)
                {
                    sum2 += arr[j1];
                }
                if (sum1 == sum2)
                {
                    index = i;
                    b = true;
                    break;  
                }
                else
                {
                    b = false;
                }
            }
            if (b == true)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
