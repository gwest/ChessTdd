using System;

namespace ChessTdd
{
    public class Board
    {
        private const int BoardSize = 8;
        private readonly Pawn[,] pieces = new Pawn[8, 8];

        public void AddPiece(Pawn piece, BoardCoordinate moveTarget)
        {
            if (!moveTarget.IsCoordinateValidForBoardSize(BoardSize))
            {
                throw new ArgumentException("moveTarget");
            }

            this.pieces[moveTarget.X, moveTarget.Y] = piece;
        }

        public Pawn GetPiece(BoardCoordinate squareIn)
        {
            return this.pieces[squareIn.X, squareIn.Y];
        }

        
    }
}
