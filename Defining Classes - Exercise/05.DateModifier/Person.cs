using System;
using System.Collections.Generic;
using System.Text;

namespace _05.DateModifier
{
    public static class DateModifier
    {
        public static int GetDiff(string dateOneStr, string dateTwoStr)
        {
            DateTime dateOne = DateTime.Parse(dateOneStr);
            DateTime dateTwo = DateTime.Parse(dateTwoStr);
            TimeSpan diff = dateTwo - dateOne;
            if (diff.Days < 0)
            {
                return -(diff.Days);
            }
            else
            {
                return diff.Days;
            }
        }
    }
}