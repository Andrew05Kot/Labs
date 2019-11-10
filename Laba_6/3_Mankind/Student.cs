using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Mankind
{
    class Student : Human
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get
            {
                return facultyNumber;
            }
            set
            {
                if (value.Length >= 5 && value.Length <= 10)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (char.IsDigit(value[i]))
                        {
                            facultyNumber = value;
                        }
                    }
                }
                else
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
            }
        }
        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"First Name: {this.FirstName}")
            .AppendLine($"Last Name: {this.LastName}")
            .AppendLine($"Faculty number: {this.FacultyNumber}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
