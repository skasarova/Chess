using System;
using System.Collections.Generic;
using System.Text;
using Chess.Code.Board;

namespace Chess.Code.Pieces
{
    public class Pawn : Piece
    {
        private const string type = "P";
        private const int count = 8;
        public Pawn(string color) : base(color, type)
        {
        }

        public override void Move(Square newSquare)
        {
            throw new NotImplementedException();
        }
    }
}
