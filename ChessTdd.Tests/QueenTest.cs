using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessTdd.Tests
{
    [TestClass]
    public class QueenTest
    {
        private Queen Target { get; set; }

        private IEnumerable<BoardCoordinate> MovesFrom_1_1;
        private const int DefaultBoardSize = 8;

        [TestInitialize]
        public void BeforeEachTest()
        {
            Target = new Queen();
            MovesFrom_1_1 = Target.GetMovesFrom(new BoardCoordinate(1, 1), DefaultBoardSize);
        }

        [TestClass]
        public class GetMovesFrom : QueenTest
        {
            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_1_2_For_1_1()
            {
                Assert.IsTrue(MovesFrom_1_1.Any(bc => bc.X == 1 && bc.Y == 2));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_2_2_For_1_1()
            {
                Assert.IsTrue(MovesFrom_1_1.Any(bc => bc.X == 2 && bc.Y == 2));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_3_3_For_1_1()
            {
                Assert.IsTrue(MovesFrom_1_1.Any(bc => bc.X == 3 && bc.Y == 3));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Does_Not_Return_0_0_From_1_1()
            {
                Assert.IsFalse(MovesFrom_1_1.Any(bc => bc.X == 0 && bc.Y == 0));
            }
        }
    }
}