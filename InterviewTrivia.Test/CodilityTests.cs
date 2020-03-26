using CS.Trivia.Codility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Trivia.Test
{
    [TestClass]
    public class CodilityTests
    {
        [DataTestMethod]
        [DataRow(new[] { 1, 3, 6, 4, 1, 2 }, 5)]//should return 5
        [DataRow(new[] { 1, 2, 3 }, 4)]//should return 4
        [DataRow(new[] { -1, -3 }, 1)]//should return 1
        public void MinMissing_Test(int[] data, int expectedResult)
        {
            var target = new MinMissingNum();

            var result = target.solution(data);

            Assert.AreEqual(expectedResult, result);
        }

        [DataTestMethod]
        [DataRow(1041, 5)]
        [DataRow(32, 0)]
        public void LargestBinaryGap(int source, int expectedResult)
        {
            var target = new LargestBinaryGap();

            var result = target.solution(source);

            Assert.AreEqual(expectedResult, result);

        }

        [DataTestMethod]
        [DataRow(new[] { 3, 8, 9, 7, 6 }, 3, new[] {9, 7, 6, 3, 8})]
        [DataRow(new[] { 0,0,0 }, 1, new[] { 0,0,0 })]
        [DataRow(new[] { 1, 2, 3, 4 }, 4, new[] { 1, 2, 3, 4 })]
        public void RotateArray(int[] source, int rotations, int[] expectedResult)
        {
            var target = new RotateArray();
            var result = target.solution(source, rotations);

            Assert.AreEqual(expectedResult.Length, result.Length);

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
            }

        }

        [DataTestMethod]
        [DataRow("{[()()]}",1)]
        [DataRow("([)()]",0)]
        [DataRow(")}{}}", 0)]
        [DataRow("", 1)]
        public void Nesting(string source, int expectedResult)
        {
            var target = new Nesting();
            var result = target.solution(source);

            Assert.AreEqual(expectedResult, result);

        }

        [DataTestMethod]
        [DataRow(new[] { 1,3,2,1,2,1,5,3,3,4,2}, 2)]
        public void FloodDepth(int[] source, int expectedResult)
        {
            var target = new FloodDepth();
            var result = target.solution(source);

            Assert.AreEqual(expectedResult, result);

        }
    }
}
