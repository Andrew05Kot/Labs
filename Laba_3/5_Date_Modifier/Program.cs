using System;
using System.Globalization;

namespace _5_Date_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Date: ");
            string firstDate = Console.ReadLine();
            Console.WriteLine("Second Date: ");
            string secondDate = Console.ReadLine();
            Console.WriteLine("Number of days: ");
            Console.WriteLine(DateModifier.GetDaysBetweenDates(firstDate, secondDate));
        }
    }
}
