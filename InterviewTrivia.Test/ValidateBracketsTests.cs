using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Trivia.Test
{
    [TestClass]
    public class ValidateBracketsTests
    {
        [DataTestMethod]
        [DataRow("(abc)", true)]
        [DataRow("([a]){bc}", true)]
        [DataRow("(a(bc)",false)]
        [DataRow("(a[b)c]", false)]
        public void ValidateBracketsTest(string source, bool expected)
        {
            var target = new ValidateBrackets();

            var result = target.IsBalanced(source);

            Assert.AreEqual(expected, result);

        }

    }
}
