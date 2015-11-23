using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ChessTdd
{
    public class Rook : Piece
    {
        public override IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate startingLocation, int boardSize)
        {
            for (var index = 1; index <= boardSize; index++)
            {
                if (index != startingLocation.Y)
                {
                    yield return new BoardCoordinate(startingLocation.X, index);
                }

                if (index != startingLocation.X)
                {
                    yield return new BoardCoordinate(index, startingLocation.Y);
                }
            }
        }
    }
}