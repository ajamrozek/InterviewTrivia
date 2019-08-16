using InterviewTrivia;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace InterviewTrivia.Test
{
    [TestClass]
    public class FibonacciGenTest
    {
        [TestMethod]
        public void GenTest()
        {
            var target = new Fibonacci();
            var result = target.GenRange(7);

            Assert.IsNotNull(result);
            Assert.AreEqual(7, result.Length);

        }
    }
}