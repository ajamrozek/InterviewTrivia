using System;

namespace TripleByte.TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TicTacToe!");

            var game = new Game();
            game.Print();
            game.AddToken(new Point() { Token = Token.X, XPos = 2, YPos = 1 });
            game.AddToken(new Point() { Token = Token.O, XPos = 2, YPos = 3 });

            game.Print();
        }
    }
}
