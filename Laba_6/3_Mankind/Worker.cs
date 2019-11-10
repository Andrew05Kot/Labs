using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Mankind
{
    class Worker : Human
    {
        private decimal workingHours;
        private decimal weekSalary;

        
        public decimal WorkingHours
        {
            get
            {
                return workingHours;
            }
            set
            {
                if (value < 1 && value >12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                else
                {
                    workingHours = value;
                }
            }
        }
        public decimal WeekSalary
        {
            get
            {
                return weekSalary;
            }
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                else
                {
                    weekSalary = value;
                }
            }
        }

        public decimal HourSalary()
        {
            return WeekSalary / 5 / WorkingHours;
        }

        public Worker(string firstName, string lastName, decimal workingHours, decimal weekSalary)
            : base(firstName, lastName)
        {
            this.WorkingHours = workingHours;
            this.WeekSalary = weekSalary;
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Title: {this.FirstName}")
            .AppendLine($"Author: {this.LastName}")
            .AppendLine($"Week Salary: {this.WeekSalary}")
            .AppendLine($"Hours per day: {this.WorkingHours}")
            .AppendLine($"Salary per hour: {this.HourSalary()}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
