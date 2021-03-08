using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game_app_Phase2.Model
{
    public class Board
    {
        private string[] _board;
        private Cell _cell;
        private int _size;

        public Board(int size)
        {
            _size = size;
            _cell = new Cell();
        }
        public string[] PBoard { get => _board; set => _board = value; }
        public Cell Cell { get => _cell; }
        public int Size { get => _size; }
        public void CreateBoard()
        {
            _board = new string[Size * Size];
            for(int i=0;i<(Size*Size);i++)
            {
                _board[i] = "-";
            }
        }
        public bool IsBoardFull()
        {
            for(int i=0;i<_board.Length;i++)
            {
                if (_board[i].Equals("-"))
                    return false;
            }
            return true;
        }
        public void PrintBoard()
        {
            int j = 1;
            for(int i=0;i<PBoard.Length;i++)
            {
                if(j<=Size)
                {
                    Console.Write("| " + PBoard[i] + " ");
                    j++;
                }
                else
                {
                    j = 2;
                    Console.WriteLine("|");
                    Console.Write("| " + PBoard[i] + " ");
                }

            }
            Console.WriteLine("|");
        }
        public bool AddMarkToCell(Mark mark, int location)
        {
            if (location > PBoard.Length-1)
            {
                throw new OutOfCellException();
            }
            if(!IsBoardFull())
            {
                Cell.Mark = mark;
                _board = Cell.IsCellEmpty(PBoard, location);
                return true;
            }
            return false;
        }
    }
    
}
