using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.Trivia.Codility
{
    public class MinMissingNum
    {
        public int solution(int[] A)
        {
            var result = 1;

            var champions = A.Where(item => item > 0)
                .Distinct()
                .ToDictionary(item => item);

            while (champions.ContainsKey(result))
            {
                result++;
            }
            
            return result;
        }
    }
}
