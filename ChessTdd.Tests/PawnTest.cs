using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessTdd.Tests
{
    [TestClass]
    public class PawnTest
    {
        [TestClass]
        public class GetMovesFrom
        {
            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_2_3_As_One_Result_When_Passed_2_2()
            {
                var pawn = new Pawn();

                var possibleMoves = pawn.GetMovesFrom(2, 2);

                Assert.IsTrue(possibleMoves.Any(bc => bc.X == 2 && bc.Y == 3));
            }
        }
    }
}