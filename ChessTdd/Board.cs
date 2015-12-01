using System;

namespace ChessTdd
{
    public class Board
    {
        public const int DefaultBoardSize = 8;

        private const int BoardSize = 8;
        private readonly Piece[,] pieces = new Piece[8, 8];

        public void AddPiece(Piece piece, BoardCoordinate moveTarget)
        {
            if (!moveTarget.IsCoordinateValidForBoardSize(BoardSize))
            {
                throw new ArgumentException("moveTarget");
            }

            this.pieces[moveTarget.X, moveTarget.Y] = piece;
        }

        public Piece GetPiece(BoardCoordinate squareIn)
        {
            return this.pieces[squareIn.X, squareIn.Y];
        }

        
    }
}
