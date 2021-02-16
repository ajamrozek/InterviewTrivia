using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS.Trivia.HackerRank.Sorting
{
    public static class BubbleSort
    {
        public static int SwapCount { get; set; }
        public static int[] SortedArr { get; set; }
        public static void countSwaps(int[] a)
        {
            var swapCount = 0;
            var n = a.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        swapCount++;
                        swap(a, j, j + 1);
                    }
                }

            }
            SwapCount = swapCount;
            SortedArr = a;
            Console.WriteLine($"Array is sorted in {swapCount} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a.Last()}");
        }

        private static void swap(int[] a, int indexA, int indexB)
        {
            a[indexA] += a[indexB];
            a[indexB] = a[indexA] - a[indexB];
            a[indexA] -= a[indexB];
            
        }
    }
}
