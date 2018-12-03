using System;
using System.Collections.Generic;
using System.Text;
using Chess.Code.Board;

namespace Chess.Code.Pieces
{
    public abstract class Piece : IPiece
    {
        public Square currentSquare; // the square on which the current piece is

        public Square CurrentSquare {
            get
            {
                return this.currentSquare;
             }
            set
            {
                this.currentSquare = value;
            }
        }

        // the symbol which will represent the current piece on the console:
        public string ConsoleSymbol { get; set; }
       
        //contructor:
        public Piece(string color, string type)
        {
            this.ConsoleSymbol = color + "_" + type;
        }

        //functionality:
        public abstract void Move(Square newSquare);

        //made a ToString just for testing purposes:
        public override string ToString()
        {
            return $"Piece: {ConsoleSymbol} Placement: [{CurrentSquare.CoordX},{CurrentSquare.CoordY}]";
        }
    }
}
