using CS.Trivia.HackerRank.Arrays;
using InterviewTrivia;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewTrivia.Test
{
    [TestClass]
    public class HourGlassSumTest
    {
        public struct HourGlassTestData
        {
            public int[][] Items;
            public int ExpectedResult;
        }
        private static IEnumerable<object[]> TestData()
        {
            yield return new object[] { new HourGlassTestData(){ Items= new int[][]{ 
                new[]{ 1, 1, 1, 0, 0, 0 },
                new[]{ 0, 1, 0, 0, 0, 0 },
                new[]{ 1, 1, 1, 0, 0, 0 },
                new[]{ 0, 0, 2, 4, 4, 0 },
                new[]{ 0, 0, 0, 2, 0, 0 },
                new[]{ 0, 0, 1, 2, 4, 0 }},
                ExpectedResult = 19
            } };
        }
        
        

        [DataTestMethod]
        [DynamicData(nameof(TestData), DynamicDataSourceType.Method)]
        public void HourGlassSum_Test(HourGlassTestData testData)
        {
            var result = HourGlassSum.hourglassSum(testData.Items);

            Assert.AreEqual(testData.ExpectedResult, result);
        }
    }
}