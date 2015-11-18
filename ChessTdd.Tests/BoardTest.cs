using System;
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
                this.target.AddPiece(piece, new BoardCoordinate(2, 1));
                Assert.AreEqual<Pawn>(piece, this.target.GetPiece(new BoardCoordinate(2, 1)));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Does_Not_Throw_Exception_When_Adding_A_Piece_To_An_Unoccupied_Square()
            {
                target.AddPiece(this.piece, new BoardCoordinate(2, 1));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Throws_Exception_When_BoardCoordinate_Has_Larger_X_Value_Than_Board_Size()
            {
                var coordinate = new BoardCoordinate(9, 1);

                ExtendedAssert.Throws<ArgumentException>(() => this.target.AddPiece(new Pawn(), coordinate));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Throws_Exception_When_BoardCoordinate_Has_Larger_Value_Y_Than_Board_Size()
            {
                var coordinate = new BoardCoordinate(1, 9);

                ExtendedAssert.Throws<ArgumentException>(() => this.target.AddPiece(new Pawn(), coordinate));
            }

            [TestMethod, TestCategory("Proven"), TestCategory("Unit")]
            public void Throws_Exception_When_BoardCoordinate_Has_Zero_X_Value()
            {
                var coordinate = new BoardCoordinate(0, 3);

                ExtendedAssert.Throws<ArgumentException>(() => this.target.AddPiece(new Pawn(), coordinate));
            }
        }
    }
}
