using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Trivia.HackerRank.Arrays
{
    public static class RotateLeft
    {
        public static int[] rotLeft(int[] a, int d)
        {
            var newArr = new int[a.Length];
            for (int i = 0;i< a.Length; i++)
            {
                var targetIndex = i < d ? 
                    a.Length - d + i : 
                    i - d;
                newArr[targetIndex] = a[i];
            }

            return newArr;

        }       
    }
}
