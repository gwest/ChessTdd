using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessTdd.Tests
{
    [TestClass]
    public class KnightTest
    {
        private Knight Target { get; set; }

        private IEnumerable<BoardCoordinate> MovesFrom33 => GetMoves(3, 3);

        private IEnumerable<BoardCoordinate> GetMoves(int x, int y)
        {
            return Target.GetMovesFrom(new BoardCoordinate(x, y), 8);
        }
            
        [TestInitialize]
        public void BeforeEachTest()
        {
            Target = new Knight();
        }

        [TestClass]
        public class GetMovesFrom : KnightTest
        {
            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_3_2_From_1_1()
            {
                var moves = GetMoves(1, 1);

                Assert.IsTrue(moves.Any(bc => bc.X == 3 && bc.Y == 2));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_2_3_From_1_1()
            {
                var moves = GetMoves(1, 1);

                Assert.IsTrue(moves.Any(bc => bc.X == 2 && bc.Y == 3));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_4_3_From_2_2()
            {
                var moves = GetMoves(2, 2);

                Assert.IsTrue(moves.Any(bc => bc.X == 4 && bc.Y == 3));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_3_4_From_2_2()
            {
                var moves = GetMoves(2, 2);

                Assert.IsTrue(moves.Any(bc => bc.X == 3 && bc.Y == 4));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_4_1_From_2_2()
            {
                var moves = GetMoves(2, 2);

                Assert.IsTrue(moves.Any(bc => bc.X == 4 && bc.Y == 1));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_1_2_From_3_3()
            {
                Assert.IsTrue(MovesFrom33.Any(bc => bc.X == 1 && bc.Y == 2));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_1_4_From_3_3()
            {
                Assert.IsTrue(MovesFrom33.Any(bc => bc.X == 1 && bc.Y == 4));
            }
            
            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_2_1_From_3_3()
            {
                Assert.IsTrue(MovesFrom33.Any(bc => bc.X == 2 && bc.Y == 1));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_2_5_From_3_3()
            {
                Assert.IsTrue(MovesFrom33.Any(bc => bc.X == 2 && bc.Y == 5));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_4_1_From_3_3()
            {
                Assert.IsTrue(MovesFrom33.Any(bc => bc.X == 4 && bc.Y == 1));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Does_Not_Return_Illegal_Moves()
            {
                var moves = GetMoves(1, 1);

                Assert.IsFalse(MovesFrom33.Any(bc => bc.X == -4 && bc.Y == 0));
            }
        }

    }
}