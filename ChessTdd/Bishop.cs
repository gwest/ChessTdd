using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace ChessTdd
{
    public class Bishop : Piece
    {
        public override IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate startingLocation, int boardSize = Board.DefaultBoardSize)
        {
            var allDistancesFromStartingLocation = Enumerable.Range(1, boardSize + 1);

            var allPossibleBoardCoordinates = allDistancesFromStartingLocation.SelectMany(sp => GetRadialDiagonalFrom(startingLocation, sp));

            var legalBoardCoordinates = allPossibleBoardCoordinates.Where(bc => bc.IsCoordinateValidForBoardSize(boardSize));

            return legalBoardCoordinates;
        }
    }
}