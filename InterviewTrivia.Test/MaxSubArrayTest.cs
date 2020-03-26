using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Trivia.Test
{
    [TestClass]
    public class MaxSubArrayTest
    {

        [TestMethod]
        public void GetTest()
        {
            var source = new[] { -2, -3, 4, -1, -2, 1, 5, -3 };

            var target = new MaxSubArray();

            var results = target.Get(source);

            Assert.AreEqual(7, results.Key);
            Assert.AreEqual(2, results.Value[0]);
            Assert.AreEqual(6, results.Value[1]);


            source = new[] { -1, -2, -3, 4, 5, -10, -1 };
            results = target.Get(source);
            
            Assert.AreEqual(9, results.Key);
            Assert.AreEqual(3, results.Value[0]);
            Assert.AreEqual(4, results.Value[1]);



        }


    }
}
