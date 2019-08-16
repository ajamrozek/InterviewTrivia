using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("InterviewTrivia.Test")]
namespace InterviewTrivia
{
    public class Game
    {
        public Point[] Points{ get; set; }
        public int Size { get; private set; }
        public Game(int size)
        {
            Size = size;
            SetupNewGame(size);
        }

        internal void SetupNewGame(int size)
        {
            var workingPoints = new List<Point>();
            for (int x = 1; x <= size; x++)
            {
                for (int y = 1; y <= size; y++) {
                    workingPoints.Add(new Point { X = x, Y = y});
                }
            }
            this.Points = workingPoints.ToArray();
        }

        public bool? ScoreGame() {
            
            bool winner = false;
            Point sourcePoint;
            
            /// get row candidates
            var index = 1;
            while (!winner && index <= Size)
            {
                sourcePoint = Points.Single(point => point.Y == index && point.X == 1);

                if (sourcePoint.Value.HasValue)
                {
                    winner = HScore(sourcePoint);
                    if (winner)
                    {
                        return sourcePoint.Value;
                    }
                }
                index++;
            }

            /// get column candidates
            index = 1;
            while (!winner && index <= Size)
            {
                sourcePoint = Points.Single(point => point.X == index && point.Y == 1);

                if (sourcePoint.Value.HasValue)
                {
                    winner = VScore(sourcePoint);
                    if (winner)
                    {
                        return sourcePoint.Value;
                    }
                }
                index++;
            }

            /// get diaganol candidates
            index = 1;
            bool? dWinner = null;
            while (!winner && index <= Size)
            {
                sourcePoint = Points.Single(point => point.Y == index && point.X == 1);
                if (sourcePoint.Value.HasValue)
                {
                    dWinner = DScore();
                    if (dWinner.HasValue)
                    {
                        return dWinner.Value;
                    }

                    dWinner = DScore(true);
                    if (dWinner.HasValue)
                    {
                        return dWinner.Value;
                    }
                }
                index++;
            }

            return null;
        }

        internal bool HScore(Point sourcePoint)
        {
            var result = Points.Count(targetPoint => targetPoint.Value == sourcePoint.Value && //matching value
                targetPoint.X >= sourcePoint.X && // subsequent column
                targetPoint.Y == sourcePoint.Y) == Size; // same row

            return result;
        }
        

        internal bool VScore(Point sourcePoint)
        {
            var result = Points.Count(targetPoint => targetPoint.Value == sourcePoint.Value && //matching value
                targetPoint.Y >= sourcePoint.Y && // subsequent row
                targetPoint.X == sourcePoint.X) == Size; // same column

            return result;
        }

        internal bool? DScore(bool backward = false)
        {
            var colIndex = backward ? Size : 1;
            var increment = backward ? -1 : 1;
            var rowIndex = 1;
            var seedPoint = GetPoint(colIndex, rowIndex);
            bool result = seedPoint.Value.HasValue;

            while (((backward && colIndex > 0) || (!backward && colIndex <= Size)) && result)
            {
                var targetPoint = GetPoint(colIndex, rowIndex);
                result = targetPoint.Value.HasValue && targetPoint.Value.Value == seedPoint.Value.Value;
                colIndex += increment;
                rowIndex++;
            }

            return result ? seedPoint.Value : null;
        }

        public Point GetPoint(int x, int y)
        {
            return Points.Single(point => point.X == x && point.Y == y);
        }
    }

    public class Point
    {
        public int X{ get; set; }
        public int Y{ get; set; }
        public bool? Value { get; set; }
    }
}
