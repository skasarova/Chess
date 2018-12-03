using System;
using System.Collections.Generic;
using System.Text;
using Chess.Code.Board;

namespace Chess.Code.Pieces
{
    public class Bishop : Piece
    {
        private const string type = "B";

        public Bishop(string color) : base(color, type)
        {
        }

        public override void Move(Square newSquare)
        {
            throw new NotImplementedException();
        }
    }
}
