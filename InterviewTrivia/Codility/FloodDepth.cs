using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.Trivia.Codility
{ 
    //https://app.codility.com/programmers/lessons/90-tasks_from_indeed_prime_2015_challenge/flood_depth/
    public class FloodDepth
    {
        public int solution(int[] A)
        {
            var maxValue = 0;
            var minValue = 0;
            var maxDepth = 0;
            var depth = 0;

            foreach (var itemA in A)
            {
                if(itemA > maxValue) // new peak
                {
                    depth = maxValue - minValue;
                    maxValue = minValue = itemA; // reset min to max
                }
                else if(itemA < minValue) // new valley
                {
                    minValue = itemA;
                }
                else // depth calc: current - lowest
                {
                    depth = itemA - minValue;
                }

                maxDepth = depth > maxDepth ? depth : maxDepth;

            }
            return maxDepth;
        }
        public int solutionF(int[] A)
        {
            var lastValue = 0;
            var maxDepth = 0;
            var workingDepth = 0;
            var floodIndex = -1;
            var wallValues = new int[2];
            var depths = new List<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (i > 0)
                {
                    if (A[i] <= lastValue) // start flood
                    {
                        floodIndex = floodIndex == -1 || A[i] > A[floodIndex] ? 
                            i - 1 : floodIndex;
                        wallValues[0] = A[floodIndex];
                        wallValues[1] = 0;
                    }
                    else if (floodIndex >= 0 && A[i] > A[floodIndex]) // end flood
                    {                     
                        floodIndex = i;
                        wallValues[1] = A[floodIndex];
                        depths.Add(maxDepth);
                    }

                    // in flood, measure depth
                    if (floodIndex >=0 && i >= floodIndex)
                    {
                        workingDepth = A[floodIndex] - A[i];
                        maxDepth = workingDepth > maxDepth ? workingDepth : maxDepth;
                    }

                }
                lastValue = A[i];
            }

            return depths.Count > 0 ? depths.Max() : 0;
        }
    }
}
