using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessTdd.Tests
{
    [TestClass]
    public class BishopTest
    {
        private Bishop Target { get; set; }

        private const int DefaultBoardSize = 8;

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
                Assert.IsTrue(Target.GetMovesFrom(new BoardCoordinate(1, 1), DefaultBoardSize).Any());
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_2_2_For_1_1()
            {
                var bishop = new Bishop();

                Assert.IsTrue(Target.GetMovesFrom(new BoardCoordinate(1, 1), DefaultBoardSize).Any(bc => bc.X == 2 && bc.Y == 2));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_1_1_For_2_2()
            {
                Assert.IsTrue(Target.GetMovesFrom(new BoardCoordinate(2, 2), DefaultBoardSize).Any(bc => bc.X == 1 && bc.Y == 1));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_2_1_For_1_2()
            {
                Assert.IsTrue(Target.GetMovesFrom(new BoardCoordinate(1, 2), DefaultBoardSize).Any(bc => bc.X == 2 && bc.Y == 1));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Does_Not_Return_Negative_Values_For_BoardCoorinates()
            {
                Assert.IsFalse(Target.GetMovesFrom(new BoardCoordinate(1, 2), DefaultBoardSize).Any(bc => bc.Y < 0 || bc.X < 0));
            }

        }
    }
}
