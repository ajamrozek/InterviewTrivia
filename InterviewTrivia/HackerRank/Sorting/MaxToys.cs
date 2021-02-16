using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.Trivia.HackerRank.Sorting
{
    public static class MaxToys
    {
        public static int maximumToys(int[] prices, int k)
        {
            var result = 0;
            var runningCost = 0;
            foreach (var item in prices.OrderBy(price=>price))
            {
                runningCost += item;

                if (runningCost <= k)
                {
                    result++;
                }
                else
                {
                    break;
                }
            }
            return result;

        }

    }
}
