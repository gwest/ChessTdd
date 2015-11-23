using System.Collections.Generic;

namespace ChessTdd
{
    public abstract class Piece
    {
        public abstract IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate startingLocation, int boardSize);
    }
}