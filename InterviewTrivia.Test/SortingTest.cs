using InterviewTrivia;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace InterviewTrivia.Test
{
    [TestClass]
    public class SortingTest
    {
        [TestMethod]
        public void MergeSortTest()
        {
            var arr1 = new int[] { 1, 3, 5 };
            var arr2 = new int[] { 2, 4, 6 };

            var mergedArrs = Sorting.Merge(arr1, arr2);

            Assert.IsNotNull(mergedArrs);
            Assert.AreEqual(arr1.Length + arr2.Length, mergedArrs.Length);
            foreach (var mergedItem in mergedArrs)
            {
                Assert.IsTrue(arr1.Any(x => x == mergedItem) || arr2.Any(x=> x == mergedItem));
            }

            Assert.IsTrue(mergedArrs[1] > mergedArrs[3]);

            var sortedArr = mergedArrs.OrderBy(item => item).ToArray();

            Assert.IsTrue(sortedArr[3] > sortedArr[1]);

        }
    }
}