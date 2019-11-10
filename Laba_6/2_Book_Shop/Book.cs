using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Book_Shop
{
    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public virtual string Author
        {
            get
            {
                return author;
            }
            set
            {
                if(value.Contains('1')
                    || value.Contains('2')
                    || value.Contains('3')
                    || value.Contains('4')
                    || value.Contains('5')
                    || value.Contains('6')
                    || value.Contains('7')
                    || value.Contains('8')
                    || value.Contains('9')
                    || value.Contains('0')
                    )
                {
                    throw new ArgumentException("Author not valid!");
                }
                else
                {
                    author = value;
                }
            }
        }
        public virtual string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                else
                {
                    title = value;
                }
            }
        }
        public virtual decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                else
                {
                    price = value;
                }
            }
        }
        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
