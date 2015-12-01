using System.Collections.Generic;
using System.Linq;

namespace ChessTdd
{
    public class Rook : Piece
    {
        public override IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate startingLocation, int boardSize = Board.DefaultBoardSize)
        {
            var availableCoorinates = Enumerable.Range(1, boardSize);

            var verticalMoves = availableCoorinates.Where(y => startingLocation.Y != y)
                .Select(y => new BoardCoordinate(startingLocation.X, y));

            var horizonalMoves = availableCoorinates.Where(x => startingLocation.X != x)
                .Select(x => new BoardCoordinate(x, startingLocation.Y));

            return verticalMoves.Union(horizonalMoves);
        }
    }
}