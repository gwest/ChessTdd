using System.Collections.Generic;

namespace ChessTdd
{
    public abstract class Piece
    {
        public abstract IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate startingLocation, int boardSize);

        protected static IEnumerable<BoardCoordinate> GetRadialDiagonalFrom(BoardCoordinate startingPosition, int distance)
        {
            yield return new BoardCoordinate(startingPosition.X + distance, startingPosition.Y + distance);
            yield return new BoardCoordinate(startingPosition.X + distance, startingPosition.Y - distance);
            yield return new BoardCoordinate(startingPosition.X - distance, startingPosition.Y + distance);
            yield return new BoardCoordinate(startingPosition.X - distance, startingPosition.Y - distance);
        }

        protected static IEnumerable<BoardCoordinate> GetRadialAdjacentFrom(BoardCoordinate startingPosition, int distance)
        {
            yield return new BoardCoordinate(startingPosition.X + distance, startingPosition.Y);
            yield return new BoardCoordinate(startingPosition.X - distance, startingPosition.Y);
            yield return new BoardCoordinate(startingPosition.X, startingPosition.Y + distance);
            yield return new BoardCoordinate(startingPosition.X, startingPosition.Y - distance);
        }
    }
}