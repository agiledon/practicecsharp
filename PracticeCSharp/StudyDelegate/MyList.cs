using System;
using System.Collections;
using System.Collections.Generic;

namespace PracticeCSharp.StudyDelegate
{
    public class MyList : IEnumerable<int>
    {
        private List<int> numbers = new List<int>();

        public void Add(int i)
        {
            numbers.Add(i);
        }

        public List<int> Transform(Func<int, int> f)
        {

            List<int> result = new List<int>();

            foreach (var x in numbers)
            {
                result.Add(f(x));
            }
            return result;
        }

        public List<int> Filter(Predicate<int> filter)
        {
            List<int> result = new List<int>();

            foreach (var x in numbers)
            {
                if (filter(x))
                {
                    result.Add(x);
                }
            }

            return result;
        }

        public IEnumerable<int> Foreach()
        {
            foreach (var i in numbers)
            {
                yield return i;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return numbers.GetEnumerator();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return numbers.GetEnumerator();
        }
    }
}
