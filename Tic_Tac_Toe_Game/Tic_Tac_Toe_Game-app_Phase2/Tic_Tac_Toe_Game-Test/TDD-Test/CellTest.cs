using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tic_Tac_Toe_Game_app_Phase2.Model;

namespace Tic_Tac_Toe_Game_Test.TDD_Test
{
    [TestClass]
    public class CellTest
    {
        [TestMethod]
        public void IsCellEmptyTest()
        {
            string[] board = new string[] {"X"};
            int location = 0;
            Cell cell = new Cell();
            try { cell.IsCellEmpty(board, location); }
            catch (CellAlreadyOccupiedException e)
            {
                Assert.AreEqual(new CellAlreadyOccupiedException().Message,e.Message);
            }
        }
    }
}
