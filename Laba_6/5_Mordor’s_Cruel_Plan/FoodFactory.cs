using System;
using System.Collections.Generic;
using System.Text;

namespace _5_Mordor_s_Cruel_Plan
{
    class FoodFactory
    {
        private string foodName;

        public string FoodName
        {
            get
            {
                return foodName;
            }
            set
            {
                foodName = value;
            }
        }
        public FoodFactory(string foodName)
        {
            this.FoodName = foodName;
            if(foodName == "cram")
            {
                MoodFactory.happiness += 2;
            }
            else if(foodName == "lembas")
            {
                MoodFactory.happiness += 3;
            }
            else if (foodName == "apple")
            {
                MoodFactory.happiness += 1;
            }
            else if (foodName == "melon")
            {
                MoodFactory.happiness += 1;
            }
            else if (foodName == "honeycake")
            {
                MoodFactory.happiness += 5;
            }
            else if (foodName == "cushrooms")
            {
                MoodFactory.happiness -= 10;
            }
            else
            {
                MoodFactory.happiness -= 1;
            }
        }
    }
}
