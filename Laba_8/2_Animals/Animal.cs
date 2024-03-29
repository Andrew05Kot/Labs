﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Animals
{
    class Animal
    {
        public string Name { get; set; }
        public string FavouriteFood { get; protected set; }

        protected Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
        }
    }
}
