using System;
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
            public void Returns_2_3_When_Passed_2_2()
            {
                var pawn = new Pawn();

                Tuple<int, int> possibleMoves = pawn.GetMovesFrom(2, 2);

                Assert.AreEqual<int>(2, possibleMoves.Item1);
                Assert.AreEqual<int>(3, possibleMoves.Item2);
            }
        }
    }
}