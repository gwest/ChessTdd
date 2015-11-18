namespace ChessTdd
{
    public struct BoardCoordinate
    {
        public int X { get; }

        public int Y { get; }

        public BoardCoordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public bool IsCoordinateValidForBoardSize(int boardSize)
        {
            return this.IsDimensionValidForBoardSize(this.X, boardSize) 
                && this.IsDimensionValidForBoardSize(this.Y, boardSize);
        }

        private bool IsDimensionValidForBoardSize(int dimensionValue, int boardSize)
        {
            return dimensionValue > 0 && dimensionValue <= boardSize;
        }

    }
}