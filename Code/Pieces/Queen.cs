using System;
using System.Collections.Generic;
using System.Text;
using Chess.Code.Board;

namespace Chess.Code.Pieces
{
    public class Queen : Piece
    {
        private const string type = "Q";

        public Queen(string color) : base(color, type)
        {
        }

        public override void Move(Square newSquare)
        {
            throw new NotImplementedException();
        }
    }
}
