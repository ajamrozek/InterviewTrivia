using CS.Trivia.HackerRank._021421;
using CS.Trivia.HackerRank.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace InterviewTrivia.Test
{

    [TestClass]
    public class AssesmentTest
    {
        public struct UniquelyDivisibleTestDataObj
        {
            public int[] Items;
            public int[] Divisors;
            public int[] ExpectedResult;
        }

        private static IEnumerable<object[]> UniquelyDivisibleTestData()
        {
            yield return new object[] { new UniquelyDivisibleTestDataObj(){
                Items= new int[]{8,12, 9, 49, 25, 15 },
                Divisors= new int[]{1,2,3,4,5,7},
                ExpectedResult = new []{8,12,15}
            } };

            yield return new object[] { new UniquelyDivisibleTestDataObj(){
                Items= new int[]{8,12, 9, 49, 25, 15, 21 },
                Divisors= new int[]{1,2,3,4,5,7},
                ExpectedResult = new []{8,12,15, 21}
            } };

            yield return new object[] { new UniquelyDivisibleTestDataObj(){
                Items= new int[]{8,12, 9, 49, 25, 15, 21, 13, 18 },
                Divisors= new int[]{1,2,3,4,5,6,7},
                ExpectedResult = new []{12,18}
            } };

            yield return new object[] { new UniquelyDivisibleTestDataObj(){
                Items= new int[]{2,4,4 },
                Divisors= new int[]{1,2,3},
                ExpectedResult = new []{2,4}
            } };
        }

        [DataTestMethod]
        [DynamicData(nameof(UniquelyDivisibleTestData), DynamicDataSourceType.Method)]
        public void Assesment_Test(UniquelyDivisibleTestDataObj testObj)
        {
            var result = assesment.UniqueDivisible(testObj.Items.ToList(), 
                testObj.Divisors.ToList());

            Assert.IsTrue(result.Any());
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(testObj.ExpectedResult[i], result.ElementAt(i));
            }
        }
    }
}