using InterviewTrivia;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace InterviewTrivia.Test
{
    [TestClass]
    public class SwapperTest
    {
        [TestMethod]
        public void SwapTest()
        {
            const int ogA = 3;
            const int ogB = 9;
            var a = ogA;
            var b = ogB;

            Assert.AreEqual(ogA, a);
            Assert.AreEqual(ogB, b);

            Assert.AreNotEqual(ogA, b);
            Assert.AreNotEqual(ogB, a);


            Swapper.Swap(ref a, ref b);

            Assert.AreEqual(ogA, b);
            Assert.AreEqual(ogB, a);

        }
    }
}