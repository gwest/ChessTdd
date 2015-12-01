using System.Collections.Generic;

namespace ChessTdd
{
    public class Pawn : Piece
    {
        public bool HasMoved { get; set; }

        public override IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate startingLocation, int boardSize = Board.DefaultBoardSize)
        {
            yield return new BoardCoordinate(startingLocation.X, startingLocation.Y + 1);

            if (!this.HasMoved)
            {
                yield return new BoardCoordinate(startingLocation.X, startingLocation.Y + 2);
            }
        }
    }
}