using System;
using System.Collections.Generic;

namespace PracticeCSharp.StudyExtMethod
{
    public static class DateTimeExtension
    {
        public static bool SameMonthOfSameYear(this DateTime dateTime, DateTime targetDateTime)
        {
            return dateTime.Year == targetDateTime.Year && dateTime.Month == targetDateTime.Month;
        }
    }

    public static class ListExtension
    {
        public static List<T> Filter<T>(this List<T> list, Predicate<T> predicate)
        {
            List<T> result = new List<T>();

            foreach (var item in list)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
