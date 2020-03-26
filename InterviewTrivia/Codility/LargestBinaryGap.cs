using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Trivia.Codility
{
    public class LargestBinaryGap
    {
        public int solution(int N)
        {
            var result = 0;
            var binaryN = Convert.ToString(N, 2);
            var bitFlag = binaryN[0] == '1';
            var workingResult = 0;

            for (int i = 0; i < binaryN.Length; i++)
            {
                var binChar = binaryN[i];

                if (bitFlag)
                {
                    if (i > 0)
                    {
                        if (binChar == '1') //close the gap
                        {
                            result = workingResult > result ? workingResult : result;
                            workingResult = 0;
                        }
                        else
                        {
                            workingResult++;
                        }
                    }
                    
                }
                else
                {
                    bitFlag = binChar == '1';
                }
            }

            return result;
        }
    }
}
