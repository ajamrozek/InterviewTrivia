using CS.Trivia.HackerRank.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace InterviewTrivia.Test
{
    [TestClass]
    public class MaxToysTest
    {
        [DataTestMethod]
        [DataRow(new[] { 1,2,3,4 }, 7, 3)]
        [DataRow(new[] { 1, 12, 5, 111, 200, 1000, 10 },50,4)]
        public void MaximumToys_Test(int[] srcArr, int budget, int expectedMax)
        {
            var result = MaxToys.maximumToys(srcArr, budget);

            Assert.AreEqual(expectedMax, result);
        }
    }
}