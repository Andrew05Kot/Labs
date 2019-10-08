using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Oldest_Family_Member
{
    class Family : Person
    {
        public static int n;
        public Family(string name, int age): base(name, age)
        {
        }
        public Family()
        {
        }

        public void AddMember()
        {
            Name = Console.ReadLine();
            Age = Convert.ToInt32(Console.ReadLine());
        }


    }
}
