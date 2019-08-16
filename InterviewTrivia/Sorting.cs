using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewTrivia
{
    public static class Sorting
    {
        public static T[] Merge<T>(T[] firstSet, T[] secondSet)
        {
            return firstSet.Concat(secondSet).ToArray();
        }
    }
}
