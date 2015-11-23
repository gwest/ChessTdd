using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace ChessTdd
{
    public class Bishop : Piece
    {
        public override IEnumerable<BoardCoordinate> GetMovesFrom(BoardCoordinate startingLocation, int boardSize)
        {
            var moves = new List<BoardCoordinate>();
            for (int index = 1; index <= boardSize; index++)
            {
                var upOneOverOne = new BoardCoordinate(startingLocation.X + index, startingLocation.Y + index);

                if (upOneOverOne.IsCoordinateValidForBoardSize(boardSize))
                {
                    moves.Add(upOneOverOne);
                }

                var downOneOverOne = new BoardCoordinate(startingLocation.X + index, startingLocation.Y - index);

                if (downOneOverOne.IsCoordinateValidForBoardSize(boardSize))
                {
                    moves.Add(downOneOverOne);
                }

                var upOneBackOne = new BoardCoordinate(startingLocation.X - index, startingLocation.Y + index);

                if (upOneBackOne.IsCoordinateValidForBoardSize(boardSize))
                {
                    moves.Add(upOneBackOne);
                }

                var downOneBackOne = new BoardCoordinate(startingLocation.X - index, startingLocation.Y - index);

                if (downOneBackOne.IsCoordinateValidForBoardSize(boardSize))
                {
                    moves.Add(downOneBackOne);
                }
            }

            return moves;
        }
    }
}