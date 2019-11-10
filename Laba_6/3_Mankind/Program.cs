using System;

namespace _3_Mankind
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string studentFirstName = Console.ReadLine();
                string studentLastName = Console.ReadLine();
                string studentFacultyNumber = Console.ReadLine();
                Student student  = new Student(studentFirstName, studentLastName, studentFacultyNumber);
                Console.WriteLine(student + Environment.NewLine);
                string workerFirstName = Console.ReadLine();
                string workerLastName = Console.ReadLine();
                decimal workerWeekSalary = decimal.Parse(Console.ReadLine());
                decimal workerWorkingHours = decimal.Parse(Console.ReadLine());
                Worker worker = new Worker(workerFirstName, workerLastName, workerWorkingHours, workerWeekSalary);
                Console.WriteLine(worker + Environment.NewLine);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
