using System;
using System.Linq;

class RotateAndSum
{
    public static void Main()
    {
        Console.Write("Array: ");
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();


        Console.Write("Rotating count: ");
        int r = Convert.ToInt32(Console.ReadLine());

        int[] sum = new int[arr.Length];
        int t;

        /* for (int j = 1; j <= r; j++)
         {
             for (int i = 0; i < arr.Length; i++)
             {
                 a[i] = arr[(i + j) % arr.Length];
                 sum[i] += a[i];
             }
             for (int i = 0; i < arr.Length; i++)
             {
                 Console.Write(a[i] + " ");
             }
         }*/

        for (int j = 1; j <= r; j++)
        {
            t = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = t;
            Console.Write("Rotating[" + j + "]: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                sum[i] += arr[i];
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.Write("Sum: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(sum[i] + " ");
        }
       

        
    }
}