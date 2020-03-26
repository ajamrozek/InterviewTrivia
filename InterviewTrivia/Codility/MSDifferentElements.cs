using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.Trivia.Codility
{
    public class MSDifferentElements
    {
        public bool solution(int[] A)
        {
            if(A.Length > 1)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if(A.Any(x => x != A[i] && Math.Abs(A[i] - x) == 1))
                    {
                        return true;
                    }
                }                
            }
            return false;
        }
    }
}
