using CS.Trivia.Codility;
using CS.Trivia.Codility.SpaceX;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Trivia.Test
{
    [TestClass]
    public class SpaceX_082920_Tests
    {
        [DataTestMethod]
        [DataRow(new[] { 9, 4, 2, 10, 7, 8, 8, 1, 9 }, 5)]
        [DataRow(new[] { 4, 8, 12, 16 }, 2)]
        [DataRow(new[] { 100 }, 1)]
        public void Turbulence_Test(int[] items, int expected)
        {
            var target = new Turbulence();

            var result = target.solution(items);

            Assert.AreEqual(expected, result);
            
        }

        [DataTestMethod]
        [DataRow(new[] { 0,9,0,2,6,8,0,8,3,0}, 4)]
        [DataRow(new[] { 0, 0, 0, 1,6,1,0,0 }, 3)]//have no idea why this is 3. exam gave an example of a tree that was not present in test data
        public void CityRoutes_Test(int[] items, int expected)
        {
            var target = new CityRoutes();

            var result = target.solution(items);

            Assert.AreEqual(expected, result);
        }


        [DataTestMethod]
        [DataRow(new[] { 1, 1, 0, 1, 0, 0 }, 4)]
        [DataRow(new[] { 1, 1, 0, 1, 0, 1 }, 3)]
        [DataRow(new[] { 1, 1, 0, 1, 0, 1, 0, 1, 0, 1 }, 3)]
        [DataRow(new[] { 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0}, 5)]
        [DataRow(new[] { 1, 1, 1, 0, 0, 0, 1, 0 }, 6)]
        [DataRow(new[] { 1, 0, 1 }, 2)]
        [DataRow(new[] { 1, 0 }, 1)]
        [DataRow(new[] { 1 }, 0)]
        [DataRow(new[] { 1, 0, 0 }, 2)]
        [DataRow(new[] { 1, 0, 0, 1 }, 2)]
        [DataRow(new[] { 1, 0, 0, 0, 1 }, 3)]
        [DataRow(new[] { 1, 1, 0, 0, 0, 1 }, 4)]
        [DataRow(new[] { 1, 1, 0, 0, 0, 1, 0 }, 5)]
        [DataRow(new[] { 0, 1, 0, 0, 0, 1, 0 }, 4)]
        [DataRow(new[] { 0, 1, 0, 0, 0, 0, 0 }, 6)]
        [DataRow(new[] { 0, 0, 0, 0, 0, 0, 1 }, 6)]
        [DataRow(new[] { 1, 0, 0, 0, 0, 0, 0 }, 6)]
        [DataRow(new[] { 0, 0, 0, 1, 0, 0, 0 }, 6)]
        [DataRow(new[] { 0, 0, 0, 0, 0, 1, 1 }, 5)]
        [DataRow(new[] { 0, 0, 0, 0, 0, 1, 1, 0 }, 6)]
        [DataRow(new[] { 0, 0, 0, 1, 1, 0, 0 }, 4)]
        [DataRow(new[] { 0, 1, 0, 1, 1, 0, 0 }, 4)]
        [DataRow(new[] { 0, 0, 1, 0, 1, 0, 0 }, 4)]
        [DataRow(new[] { 0, 1, 1, 1, 1, 1, 0 }, 5)]
        [DataRow(new[] { 0, 1, 1, 0, 1, 1, 0 }, 4)]
        [DataRow(new[] { 0, 1, 1, 1, 1, 1 }, 5)]
        [DataRow(new[] { 1, 1, 1, 1, 1, 1 }, 5)]
        public void CoinAdjacency_Test(int[] items, int expected)
        {
            var target = new CoinAdjacency();

            var result = target.solution(items);

            Assert.AreEqual(expected, result);

        }
    }
}
