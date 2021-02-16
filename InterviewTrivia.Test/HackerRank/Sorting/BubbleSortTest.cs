using CS.Trivia.HackerRank.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace InterviewTrivia.Test
{
    [TestClass]
    public class BubbleSortTest
    {
        [DataTestMethod]
        [DataRow(new[] { 3,2,1 }, 3, 1, 3)]
        [DataRow(new[] { 1, 2, 3 }, 0, 1, 3)]
        public void CountSwaps_Test(int[] srcArr, int expectedSwaps, int expectedFirst, int expectedLast)
        {
            BubbleSort.countSwaps(srcArr);

            Assert.AreEqual(BubbleSort.SwapCount, expectedSwaps);
            Assert.AreEqual(BubbleSort.SortedArr.First(), expectedFirst);
            Assert.AreEqual(BubbleSort.SortedArr.Last(), expectedLast);
        }
    }
}