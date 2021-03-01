using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game_app_Phase2.Model
{
    public class Cell
    {
        private Mark _mark;
        public Mark Mark { get => _mark; set => _mark = value; }
        public string[] IsCellEmpty(string[] board,int loaction)
        {
            if (!board[loaction].Equals("-"))
                throw new CellAlreadyOccupiedException();
            else
                board[loaction] = Mark.ToString();
            return board;
        }
    }
}
