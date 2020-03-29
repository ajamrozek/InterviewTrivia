using InterviewTrivia;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewTrivia.Test
{
    [TestClass]
    public class BinaryTreeTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void BuildAndFindTest()
        {
            var seedArray = new int[]
            {
                7, 11,17,3,42,13,11
            };
            var target = new AVLTree(seedArray);


            Assert.IsNotNull(target);
            Assert.AreEqual(11, target.Root.Value);
            Assert.AreEqual(7, target.Root.Left.Value);
            Assert.AreEqual(17, target.Root.Right.Value);


            var findTarget = target.Find(11);
            Assert.IsNotNull(findTarget);

            findTarget = target.Find(3);
            Assert.IsNotNull(findTarget);

            findTarget = target.Find(1000);
            Assert.IsNull(findTarget);

            var results = new List<string>();
            target.ReadTree(target.Root, results);
            Assert.AreEqual(7, seedArray.Length);
            Assert.AreEqual(6, results.Count);
            foreach (var result in results)
            {
                TestContext.WriteLine(result);
            }
        }

        [TestMethod]
        public void IsBST_Test()
        {
            var seedArray = new int[]
            {
                7, 11,17,3,42,13,11
            };
            var target = new AVLTree(seedArray);


            Assert.IsTrue(target.IsBST());

            seedArray = new int[] { 3, 1, 2, 4, 5, 6, 7 };
            target.Root = null;
            target.Add(seedArray);

            Assert.IsTrue(target.IsBST());
        }
        [TestMethod]
        public void SortedSetTest()
        {
            var seedArray = new int[] { 17, 3, 11, 42, 33, 2, 9, 25 };
            var sortedSet = new SortedSet<int>(seedArray);

            Assert.IsNotNull(sortedSet);



        }
    }
}