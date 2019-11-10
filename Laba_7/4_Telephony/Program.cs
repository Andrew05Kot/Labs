using System;

namespace _4_Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(new[] { ' ' });
            string[] sites = Console.ReadLine().Split(new[] { ' ' });
   
            for (int i = 0; i < numbers.Length; i++)
            {
                try
                {
                    Smartphone smartphone = new Smartphone();
                    smartphone.Number = numbers[i];
                    smartphone.Calling();
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
            for (int i = 0; i < sites.Length; i++)
            {
                try
                {
                    Smartphone smartphone = new Smartphone();
                    smartphone.Url = sites[i];
                    smartphone.Browsing();
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }
    }
}
