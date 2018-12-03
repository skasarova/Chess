using Chess.Code.Pieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Code.Board
{
    public class Board
    {
	public int PawnInitialCount = 8;
	public int KingInitialCount = 2;
	public Square[,] board = new Square[8,8];
        public List<Piece> whitePieces = new List<Piece>();
        public List<Piece> blackPieces = new List<Piece>();

        public void FillCollection(List<Piece> pieces)
        {
           //todo: think of a smart way to fill the collection - should every piece class have a collection of the current pieces?
	   // a loop will add 8 pawns to each side and pieces etc, when generating a piece in startup a method will add it to its respective collection
	}
    }
}
