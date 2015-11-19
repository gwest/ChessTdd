using System.Collections.Generic;

namespace ChessTdd
{
    public class Pawn : Piece
    {
        public bool HasMoved { get; set; }

        public override IEnumerable<BoardCoordinate> GetMovesFrom(int xCoordinate, int yCoordinate)
        {
            yield return new BoardCoordinate(xCoordinate, yCoordinate + 1);

            if (!this.HasMoved)
            {
                yield return new BoardCoordinate(xCoordinate, yCoordinate + 2);
            }
        }
    }
}