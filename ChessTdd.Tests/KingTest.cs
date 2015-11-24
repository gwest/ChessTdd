using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessTdd.Tests
{
    [TestClass]
    public class KingTest
    {
        private King Target { get; set; }

        private const int DefaultBoardSize = 8;
        private IEnumerable<BoardCoordinate> MovesFrom_3_3;
            
        [TestInitialize]
        public void BeforeEachTest()
        {
            Target = new King();
            MovesFrom_3_3 = Target.GetMovesFrom(new BoardCoordinate(3, 3), DefaultBoardSize);
        }

        [TestClass]
        public class GetMovesFrom : KingTest
        {
            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_1_2_For_1_1()
            {
                var moves = Target.GetMovesFrom(new BoardCoordinate(1, 1), DefaultBoardSize);

                Assert.IsTrue(moves.Any(bc => bc.X == 1 && bc.Y == 2));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_2_2_For_1_1()
            {
                var moves = Target.GetMovesFrom(new BoardCoordinate(1, 1), DefaultBoardSize);

                Assert.IsTrue(moves.Any(bc => bc.X == 2 && bc.Y == 2));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_3_4_For_3_3()
            {
                Assert.IsTrue(MovesFrom_3_3.Any(bc => bc.X == 3 && bc.Y == 4));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_3_2_For_3_3()
            {
                Assert.IsTrue(MovesFrom_3_3.Any(bc => bc.X == 3 && bc.Y == 2));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_2_3_For_3_3()
            {
                Assert.IsTrue(MovesFrom_3_3.Any(bc => bc.X == 2 && bc.Y == 3));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Does_Not_Return_0_0_From_1_1()
            {
                var moves = Target.GetMovesFrom(new BoardCoordinate(1, 1), DefaultBoardSize);

                Assert.IsFalse(moves.Any(bc => bc.X == 0 || bc.Y == 0));
            }
        }
    }
}