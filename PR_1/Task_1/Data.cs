using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Linq;

namespace Task_1
{
    class Data
    {
        private int day;
        private int month;
        private int year;
        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }
        public int Monse
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }
        public int Yest
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public Data (int[] data)
        {
            if (data[0] <= 31 && data[0] >= 1)
            {
                this.day = data[0];
            }
            else
            {
                Console.WriteLine("Error!!!");
            }
            if (data[1] <= 12 && data[1] >= 1)
            {
                this.month = data[1];
            }
            else
            {
                Console.WriteLine("Error!!!");
            }
            if(data[2] >= 1)
            {
                this.year = data[2];
            }
            else
            {
                Console.WriteLine("Error!!!");
            }
            //Console.WriteLine($"{this.day} {this.month} {this.year}");
        }

    }
}
