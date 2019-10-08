using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _5_Date_Modifier
{
    class DateModifier
    {
        public static double GetDaysBetweenDates(string dateFirst, string dateSecond)
        {
            
            var firstDate = DateTime.ParseExact(dateFirst, "yyyy MM dd", CultureInfo.InvariantCulture);
            var secondDate = DateTime.ParseExact(dateSecond, "yyyy MM dd", CultureInfo.InvariantCulture);

            if (firstDate > secondDate)
            {
                return GetDaysBetweenDates(dateSecond, dateFirst);
            }

            return (secondDate - firstDate).Days;
        }
    }
}
