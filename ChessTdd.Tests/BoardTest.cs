using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessTdd.Tests
{
    [TestClass]
    public class BoardTest
    {
        [TestClass]
        public class AddPiece
        {
            private Pawn piece { get; set; }
            private Board target { get; set; }

            [TestInitialize]
            public void BeforeEachTest()
            {
                this.piece = new Pawn();
                this.target = new Board();
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Retrieves_Piece_Added_To_Location()
            {
                this.target.AddPiece(piece, 1, 1);
                Assert.AreEqual<Pawn>(piece, this.target.GetPiece(1, 1));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Does_Not_Throw_Exception_When_Adding_A_Piece_To_An_Unoccupied_Square()
            {
                target.AddPiece(this.piece, 2, 1);
            }
        }
    }
}
