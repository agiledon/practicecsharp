using System;
using System.Collections.Generic;

namespace PracticeCSharp.StudyCollection
{
    public class MyEnumerator
    {
        private int seed;

        public MyEnumerator(int seed)
        {
            this.seed = seed;
        }

        public IEnumerable<int> NextNumber()
        {
            for (int i = 0; i <= seed; i++)
            {
                if (i % 2 == 0)
                {
                    yield return i;
                }
            }
            for (int i = 0; i <= seed; i++)
            {
                if (i % 2 != 0)
                {
                    yield return i;
                }
            }

        }
    }
}
