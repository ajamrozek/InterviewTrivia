using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripleByte.TicTacToe
{
    public class Point
    {
        public Token Token { get; set; }
        public int XPos { get; set; }
        public int YPos { get; set; }
    }
    public class Game
    {
        private readonly int Size = 3;
        private List<Point> Board;


        public Game()
        {
            Init();
        }

        public void Init()
        {
            Board = new List<Point>();

            //initialize the game with the size of the instance
            for (int i = 1; i <= Size; i++)
            {
                for (int j = 1; j <= Size; j++)
                {
                    Board.Add(new Point() { Token = Token.Empty, XPos = i, YPos = j });
                }
            }
        }


        public void AddToken(Point pointToAdd)
        {
            var positionToChange = Board.First(position => position.XPos == pointToAdd.XPos && position.YPos == pointToAdd.YPos);
            positionToChange.Token = pointToAdd.Token;
        }

        public void Print()
        {
            var defaultTokenChar = "-";
            var delimChar = "|";


            foreach (var boardItem in Board.OrderBy(item => item.YPos).ThenBy(item => item.XPos))
            {
                var useDelims = boardItem.XPos == 2;
                if (useDelims)
                {
                    Console.Write(delimChar);
                }
                
                Console.Write(boardItem.Token == Token.Empty ? defaultTokenChar : boardItem.Token.ToString());
                
                if (useDelims)
                {
                    Console.Write(delimChar);
                }

                if(boardItem.XPos == 3)
                {
                    Console.Write(Environment.NewLine);
                }

            }

        }

    }
}
