using System.Collections.Generic;
using System.Linq;

namespace ChessTdd
{
    public class King : Piece
    {
        public override IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate startingLocation, int boardSize)
        {
            var oneSquareAwayMoves = GetRadialAdjacentFrom(startingLocation, 1)
                .Union(GetRadialDiagonalFrom(startingLocation, 1));

            return oneSquareAwayMoves.Where(bc => bc.IsCoordinateValidForBoardSize(boardSize));
        }
    }
}