using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessTdd.Tests
{
    [TestClass]
    public class RookTest
    {
        [TestClass]
        public class GetMovesFrom
        {
            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Returns_Empty_Collection()
            {
                var rook = new Rook();

                Assert.AreEqual<int>(0, rook.GetMovesFrom(1,1).Count());
            }
        }
    }
}