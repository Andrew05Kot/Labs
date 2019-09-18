using System;

namespace Problem14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];

            for(int i = 0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = arr[0];

            foreach (int i in arr)
            {
                max = (i>max) ? i : max;
            }
            Console.WriteLine("max = " + max);
        }
    }
}
