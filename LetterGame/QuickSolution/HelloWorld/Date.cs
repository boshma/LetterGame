using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Date
{
    public class Date
    {
        public static bool IsLeap(int year)
        {
            if ((year % 4 == 0 || year % 400 == 0) && year > 1)
            {
                return true;
            }
            else if (year == int.MaxValue)
            {
                return false;
            }
            return false;
        }
    }
}
