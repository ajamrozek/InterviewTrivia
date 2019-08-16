using InterviewTrivia;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace InterviewTrivia.Test
{
    [TestClass]
    public class TicTacToeTest
    {
        [TestMethod]
        public void NewGameTest()
        {
            var size = 3;
            var target = new Game(size);
            Assert.IsNotNull(target);
            Assert.IsNotNull(target.Points);
            Assert.AreEqual(target.Points.Length, 9);

            for (int x = 1; x <= size; x++)
            {
                for (int y = 1; y <= size; y++)
                {
                    Assert.IsNotNull(target.Points.Single(point => point.X == x && point.Y == y));
                }
            }

        }

        [TestMethod]
        public void FullGame_NoWinner_Test()
        {
            var target = FullPoints_NoWinner();
            Assert.AreEqual(target.Points.Length, 16);

            var winner = target.ScoreGame();

            Assert.IsNull(winner);
        }

        [TestMethod]
        public void PartialGame_Test()
        {
            var target = PartialPoints_NullWinner();
            Assert.AreEqual(target.Points.Length, 16);

            var winner = target.ScoreGame();

            Assert.IsNull(winner);
        }

        [TestMethod]
        public void FullGame_TrueHWinner_Test()
        {
            var target = FullPoints_TrueHWinner();
            Assert.AreEqual(target.Points.Length, 16);

            var winner = target.ScoreGame();

            Assert.IsTrue(winner.Value);
        }

        [TestMethod]
        public void Partial_TrueHWinner_Test()
        {
            var target = Partial_TrueHWinner();
            Assert.AreEqual(target.Points.Length, 9);

            var winner = target.ScoreGame();

            Assert.IsTrue(winner.Value);
        }


        [TestMethod]
        public void PartialGame_FalseDWinner_Test()
        {
            var target = PartialPoints_FalseDWinner();
            Assert.AreEqual(target.Points.Length, 9);

            var winner = target.ScoreGame();

            Assert.IsFalse(winner.Value);
        }

        [TestMethod]
        public void PartialGame_FalseBackDWinner_Test()
        {
            var target = PartialPoints_FalseBackDWinner();
            Assert.AreEqual(target.Points.Length, 9);

            var winner = target.ScoreGame();

            Assert.IsFalse(winner.Value);
        }

        private Game FullPoints_NoWinner()
        {
            var size = 4;
            var result = new Game(size);

            var trueCandidatesCoords = new int[,] { { 1, 1 }, { 2, 1 }, { 3, 2 }, { 4, 2 }, { 1, 3 }, { 2, 3 }, { 3, 4 }, { 4, 4 } };
            var falseCandidatesCoords = new int[,] { { 3, 1 }, { 4, 1 }, { 1, 2 }, { 2, 2 }, { 3, 3 }, { 4, 3 }, { 1, 4 }, { 2, 4 } };

            for (int i = 0; i < trueCandidatesCoords.GetLength(0); i++)
            {
                result.GetPoint(trueCandidatesCoords[i, 0], trueCandidatesCoords[i, 1]).Value = true;
            }

            for (int i = 0; i < falseCandidatesCoords.GetLength(0); i++)
            {
                result.GetPoint(falseCandidatesCoords[i, 0], falseCandidatesCoords[i, 1]).Value = false;
            }

            return result;
        }
        private Game PartialPoints_NullWinner()
        {
            var size = 4;
            var result = new Game(size);

            var trueCandidatesCoords = new int[,] { { 1, 3 }, { 2, 3 }, { 3, 4 }, { 4, 4 } };
            var falseCandidatesCoords = new int[,] { { 3, 3 }, { 4, 3 }, { 1, 4 }, { 2, 4 } };

            for (int i = 0; i < trueCandidatesCoords.GetLength(0); i++)
            {
                result.GetPoint(trueCandidatesCoords[i, 0], trueCandidatesCoords[i, 1]).Value = true;
            }

            for (int i = 0; i < falseCandidatesCoords.GetLength(0); i++)
            {
                result.GetPoint(falseCandidatesCoords[i, 0], falseCandidatesCoords[i, 1]).Value = false;
            }

            return result;
        }

        private Game FullPoints_TrueHWinner()
        {
            var size = 4;
            var result = new Game(size);

            var trueCandidatesCoords = new int[,] { { 1, 1 }, { 2, 1 }, { 3, 1 }, { 4, 1 }};
            var falseCandidatesCoords = new int[,] { { 3, 2 }, { 4, 2 }, { 1, 3 }, { 2, 3 }};

            for (int i = 0; i < trueCandidatesCoords.GetLength(0); i++)
            {
                result.GetPoint(trueCandidatesCoords[i, 0], trueCandidatesCoords[i, 1]).Value = true;
            }

            for (int i = 0; i < falseCandidatesCoords.GetLength(0); i++)
            {
                result.GetPoint(falseCandidatesCoords[i, 0], falseCandidatesCoords[i, 1]).Value = false;
            }

            return result;
        }

        private Game Partial_TrueHWinner()
        {
            var size = 3;
            var result = new Game(size);

            var trueCandidatesCoords = new int[,] { { 1, 2 }, { 2, 2 }, { 3, 2 } };
            var falseCandidatesCoords = new int[,] { { 1, 1 }, { 1, 3 }, { 3, 3 } };

            for (int i = 0; i < trueCandidatesCoords.GetLength(0); i++)
            {
                result.GetPoint(trueCandidatesCoords[i, 0], trueCandidatesCoords[i, 1]).Value = true;
            }

            for (int i = 0; i < falseCandidatesCoords.GetLength(0); i++)
            {
                result.GetPoint(falseCandidatesCoords[i, 0], falseCandidatesCoords[i, 1]).Value = false;
            }

            return result;
        }

        private Game PartialPoints_FalseDWinner()
        {
            var size = 3;
            var result = new Game(size);

            var trueCandidatesCoords = new int[,] { { 3, 1 }, { 2, 1 }, { 3, 2 } };
            var falseCandidatesCoords = new int[,] { { 1, 1 }, { 2, 2 }, { 3, 3 } };

            for (int i = 0; i < trueCandidatesCoords.GetLength(0); i++)
            {
                result.GetPoint(trueCandidatesCoords[i, 0], trueCandidatesCoords[i, 1]).Value = true;
            }

            for (int i = 0; i < falseCandidatesCoords.GetLength(0); i++)
            {
                result.GetPoint(falseCandidatesCoords[i, 0], falseCandidatesCoords[i, 1]).Value = false;
            }

            return result;
        }
        private Game PartialPoints_FalseBackDWinner()
        {
            var size = 3;
            var result = new Game(size);

            var trueCandidatesCoords = new int[,] { { 1, 1 }, { 2, 1 }, { 3, 2 } };
            var falseCandidatesCoords = new int[,] { { 3, 1 }, { 2, 2 }, { 1, 3 } };

            for (int i = 0; i < trueCandidatesCoords.GetLength(0); i++)
            {
                result.GetPoint(trueCandidatesCoords[i, 0], trueCandidatesCoords[i, 1]).Value = true;
            }

            for (int i = 0; i < falseCandidatesCoords.GetLength(0); i++)
            {
                result.GetPoint(falseCandidatesCoords[i, 0], falseCandidatesCoords[i, 1]).Value = false;
            }

            return result;
        }


    }
}
