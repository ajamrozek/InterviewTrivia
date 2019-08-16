using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTrivia
{
    public class Fibonacci
    {
        public int[] GenRange(int length)
        {
            int[] result = new int[length];
            int n = 0;

            for (int i = 0; i< length; i++)
            {
                result[i] = n;
                n = n + (i > 0 ? result[i - 1] : 1);
            }

            return result;
        }
    }
}
