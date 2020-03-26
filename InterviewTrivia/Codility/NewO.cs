using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Trivia.Codility
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    public class MSSolution
    {
        public void solution(int N)
        {
            int enable_print = N % 10;
            while (N > 0)
            {
                if (enable_print == 0 && N % 10 != 0)
                {
                    enable_print = 1;
                }

                if (enable_print == 1)
                {
                    Debug.Write(N % 10);
                }
                N = N / 10;
            }
        }

        public string Process(int source)
        {
            var result = string.Join("", source.ToString()
                .Reverse());
            return result;
        }
    }
}
