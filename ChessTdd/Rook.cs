using System;
using System.Collections.Generic;
using System.Linq;

namespace ChessTdd
{
    public class Rook : Piece
    {
        public override IEnumerable<BoardCoordinate> GetMovesFrom(int xCoordinate, int yCoordinate)
        {
            return Enumerable.Empty<BoardCoordinate>();
        }
    }
}