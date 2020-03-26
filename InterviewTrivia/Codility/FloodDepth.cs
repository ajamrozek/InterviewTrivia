using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Trivia.Codility
{
    public class FloodDepth
    {
        public int solution(int[] A)
        {
            var floodFlag = false;
            var lastValue = 0;
            var maxDepth = 0;
            var workingDepth = 0;
            var floodIndex = -1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i]<=lastValue)
                {
                    floodIndex = floodIndex == -1 ? i-1 : floodIndex;
                }
                else if(A[i] > floodIndex)
                {
                    floodIndex = i;
                }


                if (i > floodIndex)
                {
                    workingDepth = A[floodIndex] - A[i];
                    maxDepth = workingDepth > maxDepth ? workingDepth : maxDepth;
                }

                lastValue = A[i];
            }

            return maxDepth;
        }
    }
}
