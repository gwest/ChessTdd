using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessTdd.Tests
{
    [TestClass]
    public class RookTest
    {
        private Rook Target { get; set; }

        private static readonly BoardCoordinate BottomCorner = new BoardCoordinate(1, 1);
        private const int BoardSize = 8;

        [TestInitialize]
        public void BeforeEachTest()
        {
            this.Target =new Rook();
        }

        [TestClass]
        public class GetMovesFrom : RookTest
        {
            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_7_Vertical_Moves_With_Board_Size_8()
            {
                var moves = this.Target.GetMovesFrom(BottomCorner, BoardSize);

                Assert.AreEqual<int>(7, moves.Count(bc => bc.X == 1));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_7_Horizonal_Moves_With_Board_Size_8()
            {
                var moves = this.Target.GetMovesFrom(BottomCorner, BoardSize);

                Assert.AreEqual<int>(7, moves.Count(bc => bc.Y == 1));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_No_Moves_That_Contains_A_Zero()
            {
                var moves = this.Target.GetMovesFrom(BottomCorner, BoardSize);

                Assert.AreEqual<int>(0, moves.Count(bc => bc.X == 0 || bc.Y == 0));
            }
        }
    }
}