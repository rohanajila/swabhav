using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tic_Tac_Toe_Game_app_Phase2.Model;
using Tic_Tac_Toe_Game_app_Phase2;

namespace Tic_Tac_Toe_Game_Test.TDD_Test
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void CreateBoardTest()
        {
            Board board = new Board(2);
            board.CreateBoard();
            int size = 4;
            string[] checkBoard = new string[size];
            for (int i=0; i < size;i++)
            {
                checkBoard[i] = "-";
            }
            for (int i = 0; i < size; i++)
            {
                Assert.AreEqual(checkBoard[i], board.PBoard[i]);
            }
            
        }
        [TestMethod]
        public void IsBoardFullTest()
        {
            Board board = new Board(2);
            board.CreateBoard();
            bool result=false;
            int size = 4;
            for (int i = 0; i < size; i++)
            {
                board.PBoard[i] = "X";
            }
            for (int i = 0; i < board.PBoard.Length; i++)
            {
                if (board.PBoard[i].Equals("-"))
                    result = false;
                else
                    result = true;
            }
            Assert.AreEqual(result, board.IsBoardFull());
        }
        [TestMethod]
        public void AddMarkToCellTest()
        {
            Mark mark=Mark.X;
            Board board = new Board(2);
            board.CreateBoard();
            int location=2;
            bool result = false;
            result=board.AddMarkToCell(mark, location);
            Assert.AreEqual("X", board.PBoard[location]);

        }
    }
}
