using System;
using System.Collections.Generic;
using System.Text;
using Chess.Code.Board;

namespace Chess.Code.Pieces
{
    public class Rook : Piece
    {
        private const string type = "R";
        private const int count = 2;

        public Rook(string color) : base(color, type)
        {
        }

        public override void Move(Square newSquare)
        {
            throw new NotImplementedException();
        }
    }
}
