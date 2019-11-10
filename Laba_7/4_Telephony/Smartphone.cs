using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Telephony
{
    class Smartphone : INumber, ISite
    {
        private string number;
        private string url;

        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                bool b = true;
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsDigit(value[i]))
                    {
                        b = false;
                        break;
                        
                    }
                }
                if (b == true)
                {
                    number = value;
                }
                else
                {
                    throw new ArgumentException("Invalid number!");
                }
            }
        }
        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                bool b = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i]))
                    {
                        b = true;
                        break;

                    }
                }
                if (b == false)
                {
                    url = value;
                }
                else
                {
                    throw new ArgumentException("Invalid URL!");
                }
            }
        }

        public void Calling()
        {
            Console.WriteLine($"Caling...  {this.Number}");
        }
        public void Browsing()
        {
            Console.WriteLine($"Browsing...  {this.Url}");
        }
    }
}
