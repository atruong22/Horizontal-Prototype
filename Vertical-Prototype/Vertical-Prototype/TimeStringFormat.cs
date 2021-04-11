using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vertical_Prototype
{
    class TimeStringFormat
    {
        //A function to take in the minutes a recipe takes to make and change it into a formatted string
        public static string GenerateString(int min)
        {

            string str;

            switch (min)
            {
                case int n when (n <= 10):
                    str = "10 minutes or less.";
                    break;
                case int n when (n <= 20):
                    str = "20 minutes or less.";
                    break;
                case int n when (n <= 30):
                    str = "30 minutes or less.";
                    break;
                case int n when (n <= 45):
                    str = "45 minutes or less.";
                    break;
                case int n when (n <= 60):
                    str = "1 hour or less.";
                    break;
                case int n when (n <= 120):
                    str = "2 hours or less.";
                    break;
                default:
                    str = "Over 2 hours.";
                    break;
            }

            return str;
        }
    }
}
