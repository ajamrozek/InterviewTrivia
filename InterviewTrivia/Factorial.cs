using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTrivia
{
    public static class Factorial
    {
        public static Int64 Process(Int64 source)
        {
            Int64 result = 1;
            while (source > 0)
            {
                result = result * source;
                source--;
            }
            return result;
        }
    }
}
