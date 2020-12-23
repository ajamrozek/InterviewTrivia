using CS.Trivia;
using InterviewTrivia;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace InterviewTrivia.Test
{
    [TestClass]
    public class TimesTableTest
    {
        [DataRow(12,144)]
        [DataRow(3, 9)]
        [DataTestMethod]
        public void TimesTable_Ctor_Test(int size, int val)
        {
            var target = new TimesTable(size);

            Assert.IsNotNull(target);
            Assert.IsNotNull(target.Result);
            Assert.IsTrue(target.Result.Length > 0);
            Assert.AreEqual(val, target.Result[size - 1, size - 1]);
        }
    }
}