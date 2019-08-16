using InterviewTrivia;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace InterviewTrivia.Test
{
    [TestClass]
    public class ParenthesisTest
    {
        [TestMethod]
        public void BasicTest()
        {
            var target = new Parenthesis();
            Assert.IsNotNull(target.AllResults);
            Assert.AreEqual(5,target.AllResults.Count());

        }

        [TestMethod]
        public void VariationTest()
        {
            var target = new Parenthesis("{}",6);
            Assert.IsNotNull(target.AllResults);
            Assert.AreEqual(132, target.AllResults.Count());

        }
    }
}