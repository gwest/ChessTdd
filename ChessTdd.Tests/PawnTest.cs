using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessTdd.Tests
{
    [TestClass]
    public class PawnTest
    {
        private Pawn target { get; set; }

        [TestInitialize]
        public void BefereEachTest()
        {
            this.target = new Pawn();
        }

        [TestClass]
        public class GetMovesFrom : PawnTest
        {
            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_2_3_As_One_Result_When_Passed_2_2()
            {
                var possibleMoves = this.target.GetMovesFrom(new BoardCoordinate(2, 2), 8);

                Assert.IsTrue(possibleMoves.Any(bc => bc.X == 2 && bc.Y == 3));
            }
        }

        [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
        public void Returns_2_4_As_One_Result_When_Passed_2_2_When_Piece_Has_Not_Moved()
        {
            var possibleMoves = this.target.GetMovesFrom(new BoardCoordinate(2, 2), 8);

            Assert.IsTrue(possibleMoves.Any(bc => bc.X == 2 && bc.Y == 4));
        }

        [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
        public void Does_Not_Returns_2_4_As_One_Result_When_Passed_2_2_If_Piece_Has_Already_Moved()
        {
            this.target.HasMoved = true;

            var possibleMoves = this.target.GetMovesFrom(new BoardCoordinate(2, 2), 8);

            Assert.IsFalse(possibleMoves.Any(bc => bc.X == 2 && bc.Y == 4));
        }
    }
}