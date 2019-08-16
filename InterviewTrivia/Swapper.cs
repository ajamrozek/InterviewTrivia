using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewTrivia
{
    public static class Swapper
    {
        public static void Swap(ref int a, ref int b)
        {
            b = a + b;
            a = b - a;
            b -= a;
        }
    }
}
