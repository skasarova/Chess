using Chess.Code.Board;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Code.Pieces
{
    public interface IPiece
    {
         Square CurrentSquare { get; set; }
         string ConsoleSymbol { get; set; }
         void Move(Square newSquare);
    }
}
