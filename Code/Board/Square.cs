using Chess.Code.Pieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Code.Board
{
    public class Square
    {
        public int CoordX { get; set; }
        public int CoordY { get; set; }
        public bool Empty { get; set; }
        public IPiece currentPiece;
        public IPiece CurrentPiece
        {
            get
            {
                return this.currentPiece;
            }
            set
            {
                this.currentPiece = value;
            }
        }

        //contructor:
        public Square(int x, int y)
        {
            this.Empty = true;
            this.CoordX = x;
            this.CoordY = y;
        }

        //functionality:
        public void FillSquare(IPiece piece)
        {
            this.CurrentPiece = piece;
            piece.CurrentSquare = this;
            this.Empty = false;
        }

        public void FreeSquare()
        {
            this.CurrentPiece = null;
            this.Empty = true;
        }
    }
}
