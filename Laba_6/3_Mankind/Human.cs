using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Mankind
{
    class Human
    {
        private string firstName;
        private string lastName;

        public virtual string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (char.IsLower(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                else if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
                }
                else
                {
                    firstName = value;
                }
            }
        }
        public virtual string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (char.IsLower(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }
                else if(value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: lastName");
                }
                else
                {
                    lastName = value;
                }
            }
        }
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
