using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessTdd.Tests
{
    [TestClass]
    public class RookTest
    {
        private Rook Target { get; set; }

        private IEnumerable<BoardCoordinate> MovesFrom11;

        [TestInitialize]
        public void BeforeEachTest()
        {
            this.Target =new Rook();
            this.MovesFrom11 = Target.GetMovesFrom(new BoardCoordinate(1, 1));
        }

        [TestClass]
        public class GetMovesFrom : RookTest
        {
            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_7_Vertical_Moves_With_Board_Size_8()
            {
                Assert.AreEqual<int>(7, this.MovesFrom11.Count(bc => bc.X == 1));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_7_Horizonal_Moves_With_Board_Size_8()
            {
                Assert.AreEqual<int>(7, this.MovesFrom11.Count(bc => bc.Y == 1));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_No_Moves_That_Contains_A_Zero()
            {
                Assert.AreEqual<int>(0, this.MovesFrom11.Count(bc => bc.X == 0 || bc.Y == 0));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_7_4_From_7_1()
            {
                var moves = Target.GetMovesFrom(new BoardCoordinate(7, 1));

                Assert.IsTrue(moves.Any(bc => bc.X == 7 && bc.Y == 4));
            }
        }
    }
}