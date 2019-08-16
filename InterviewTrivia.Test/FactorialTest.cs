using InterviewTrivia;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace InterviewTrivia.Test
{
    [TestClass]
    public class FactorialTest
    {
        [TestMethod]
        public void GenTest()
        {
            var source = 5;
            var result = Factorial.Process(source);

            Assert.IsNotNull(result);
            Assert.AreEqual(120, result);

        }
    }
}