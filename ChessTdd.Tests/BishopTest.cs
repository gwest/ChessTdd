using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessTdd.Tests
{
    [TestClass]
    public class BishopTest
    {
        private Bishop Target { get; set; }

        private IEnumerable<BoardCoordinate> GetMoves(int x, int y)
        {
            return Target.GetMovesFrom(new BoardCoordinate(x, y));
        }

        [TestInitialize]
        public void BeforeEachTest()
        {
            Target = new Bishop();
        }

        [TestClass]
        public class GetMovesFrom : BishopTest
        {
            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_Non_Empty_Collection()
            {
                Assert.IsTrue(this.GetMoves(1, 1).Any());
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_2_2_For_1_1()
            {
                var bishop = new Bishop();

                Assert.IsTrue(this.GetMoves(1, 1).Any(bc => bc.X == 2 && bc.Y == 2));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_1_1_For_2_2()
            {
                Assert.IsTrue(this.GetMoves(2, 2).Any(bc => bc.X == 1 && bc.Y == 1));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_2_1_For_1_2()
            {
                Assert.IsTrue(this.GetMoves(1, 2).Any(bc => bc.X == 2 && bc.Y == 1));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Does_Not_Return_Negative_Values_For_BoardCoorinates()
            {
                Assert.IsFalse(this.GetMoves(1, 2).Any(bc => bc.Y < 0 || bc.X < 0));
            }
            
            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_8_8_For_1_1()
            {
                Assert.IsTrue(this.GetMoves(1, 1).Any(bc => bc.X == 8 && bc.Y == 8));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_8_1_For_1_8()
            {
                Assert.IsTrue(this.GetMoves(1, 8).Any(bc => bc.X == 8 && bc.Y == 1));
            }
        }
    }
}
