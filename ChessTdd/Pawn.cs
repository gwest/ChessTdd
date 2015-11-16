using System;

namespace ChessTdd
{
    public class Pawn
    {
        public Tuple<int, int> GetMovesFrom(int xCoordinate, int yCoordinate)
        {
            return new Tuple<int, int>(xCoordinate, yCoordinate + 1);
        }
    }
}