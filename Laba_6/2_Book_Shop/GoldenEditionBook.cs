﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Book_Shop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price)
            : base(author, title, price)
        {
        }
        public override decimal Price
        {
            get
            {
                return base.Price * (decimal)1.3;
            }
        }
    }
}
