using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Trivia.HackerRank._021421
{
    public static class assesment
    {
        /*
     * Complete the 'UniqueDivisible' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */
        public static List<int> UniqueDivisible(List<int> a, List<int> b)
        {
            var result = new List<int>();
            
            // set up the threshold to add to the result
            var threshold = b.Count * .5;
            
            // iterate over all target items
            foreach (var item in a)
            {
                // set up a working list for each division operation
                var workingList = new List<int>();

                // iterate over every divisor
                foreach (var divisor in b)
                {
                    // divide operation with modulus to observe a 0 remainder
                    if(item % divisor == 0)
                    {
                        // no remainder, add it to working list
                        workingList.Add(item);
                    }
                }

                // if the workinglist has a greater than threshold count
                if(workingList.Count >= threshold &&
                    !result.Contains(item))
                {
                    // add it to the result
                    result.Add(item);
                }
            }

            return result;
        }

    }
}
