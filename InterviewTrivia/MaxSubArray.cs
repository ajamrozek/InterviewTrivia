using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.Trivia
{
    public class MaxSubArray
    {
        public KeyValuePair<int, int[]> Get(int[] source)
        {
            int size = source.Length;
            int max_so_far = int.MinValue;
            int max_ending_here = 0;
            var idxStack = new Stack<int>();
            bool reset = false;
            for (int i = 0; i < size; i++)
            {
                max_ending_here += source[i];

                if (max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;
                    if (reset)
                    {
                        idxStack.Clear();
                        reset = false;
                    }
                    idxStack.Push(i);
                }

                if (max_ending_here < 0)
                {
                    max_ending_here = 0;
                    reset = true;
                }
            }
            
            return new KeyValuePair<int, int[]>(max_so_far, new[] { idxStack.Last(), idxStack.First()});
            
        }               
    }
}
