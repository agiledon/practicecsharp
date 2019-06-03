using System;
using System.Collections.Generic;

namespace PracticeCSharp
{
    public static class NumberList
    {
        // Create an array of integers.
        public static int[] ints = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 };

        // Define a property that returns only the even numbers.
        public static IEnumerable<int> GetEven()
        {
            // Use yield to return the even numbers in the list.
            foreach (int i in ints)
                if (i % 2 == 0)
                    yield return i;
        }

        // Define a property that returns only the even numbers.
        public static IEnumerable<int> GetOdd()
        {
            // Use yield to return only the odd numbers.
            foreach (int i in ints)
                if (i % 2 == 1)
                    yield return i;
        }
    }
}
