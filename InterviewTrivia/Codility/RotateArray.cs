using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Trivia.Codility
{
    public class RotateArray
    {
        public int[] solution(int[] A, int K)
        {
            while (K>0)
            {
                for (int i = A.Length-1; i > 0 ; i--)
                {
                    SwapArrayItems(A, i, i - 1);
                }
                K--;
            }

            return A;
        }

        private void SwapArrayItems(int[] source, int indexA, int indexB)
        {
            source[indexA] = source[indexA] + source[indexB];
            source[indexB] = source[indexA] - source[indexB];
            source[indexA] = source[indexA] - source[indexB];
        }
    }
}
