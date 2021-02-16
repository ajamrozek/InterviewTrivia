using CS.Trivia.HackerRank.Arrays;
using InterviewTrivia;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewTrivia.Test
{
    [TestClass]
    public class RotateLeftTest
    {
        [DataTestMethod]
        [DataRow(new[] { 1, 2, 3, 4, 5 }, 4, new[] { 5,1,2,3,4})]
        [DataRow(new[] { 41, 73, 89, 7, 10, 1, 59, 58, 84, 77, 77, 97, 58, 1, 86, 58, 26, 10, 86, 51 }, 10,
            new[] { 77, 97, 58, 1, 86, 58, 26, 10, 86, 51, 41, 73, 89, 7, 10, 1, 59, 58, 84, 77 })]
        public void RotateLeft_Test(int[] srcArr, int rotations, int[] expected)
        {
            var result = RotateLeft.rotLeft(srcArr, rotations);
            Assert.AreEqual(expected.Length, result.Length);

            for(var i = 0; i<result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }
    }
}