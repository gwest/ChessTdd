namespace ChessTdd
{
    public class Board
    {
        private readonly Pawn[,] pieces = new Pawn[8, 8];

        public void AddPiece(Pawn piece, int xCoordinate, int yCoordinate)
        {
            this.pieces[xCoordinate, yCoordinate] = piece;
        }

        public Pawn GetPiece(int xCoordinate, int yCoordinate)
        {
            return this.pieces[xCoordinate, yCoordinate];
        }
    }
}
