using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessTdd.Tests
{
    [TestClass]
    public class PawnTest
    {
        private Pawn Target { get; set; }

        private IEnumerable<BoardCoordinate> MovesFrom22;
            
        [TestInitialize]
        public void BefereEachTest()
        {
            this.Target = new Pawn();
            this.MovesFrom22 = this.Target.GetMovesFrom(new BoardCoordinate(2, 2));
        }

        [TestClass]
        public class GetMovesFrom : PawnTest
        {
            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_2_3_As_One_Result_When_Passed_2_2()
            {
                Assert.IsTrue(this.MovesFrom22.Any(bc => bc.X == 2 && bc.Y == 3));
            }
        }

        [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
        public void Returns_2_4_As_One_Result_When_Passed_2_2_When_Piece_Has_Not_Moved()
        {
            Assert.IsTrue(this.MovesFrom22.Any(bc => bc.X == 2 && bc.Y == 4));
        }

        [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
        public void Does_Not_Returns_2_4_As_One_Result_When_Passed_2_2_If_Piece_Has_Already_Moved()
        {
            this.Target.HasMoved = true;

            Assert.IsFalse(this.MovesFrom22.Any(bc => bc.X == 2 && bc.Y == 4));
        }
    }
}