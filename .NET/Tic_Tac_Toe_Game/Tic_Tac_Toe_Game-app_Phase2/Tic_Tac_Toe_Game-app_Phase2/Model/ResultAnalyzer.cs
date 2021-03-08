using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game_app_Phase2.Model
{
    public class ResultAnalyzer
    {
        private Board _board;
        private Result _result = Result.INPROGRESS;
        public ResultAnalyzer(Board board)
        {
            _board = board;
        }
        public Board Board { get => _board; }
        public Result Result { get => _result; }
        public string CheckWinner()
        {
            if (_board.IsBoardFull())
                return Result.DRAW.ToString();
            if (CheckRow().Equals(Result.WIN))
                return Result.WIN.ToString();
            if (CheckColumn().Equals(Result.WIN))
                return Result.WIN.ToString();
            if (CheckDiagonal().Equals(Result.WIN))
                return Result.WIN.ToString();
            if (CheckReverseDiagonal().Equals(Result.WIN))
                return Result.WIN.ToString();
            return _result.ToString();

        }
        public Result CheckRow()
        {
            int j = 0, resultCount = 1;
            Result result = Result.INPROGRESS;
            for(int i=1;i<Board.PBoard.Length;i++)
            {
                if (!Board.PBoard[j].Equals("-") && (Board.PBoard[j].Equals(Board.PBoard[i])))
                {
                    if (++resultCount == Board.Size)
                    {
                        result = Result.WIN;
                        break;
                    }
                }
                else
                {
                    i = i + Board.Size;
                    j = j + Board.Size;
                    result = Result.INPROGRESS;
                }
                
            }
            return result;

        }
        public Result CheckColumn()
        {
            int j = 0, resultCount = 1;
            Result result = Result.INPROGRESS;
            for (int i = Board.Size; i < Board.PBoard.Length; i++)
            {
                if (!Board.PBoard[j].Equals("-") && (Board.PBoard[j].Equals(Board.PBoard[i])))
                {
                    if (++resultCount == Board.Size)
                    {
                        result = Result.WIN;
                        break;
                    }
                }
                else
                {

                    j++;
                    i = j;
                    result = Result.INPROGRESS;
                }

            }
            return result;

        }
        public Result CheckDiagonal()
        {
            int j = 0, resultCount = 1;           
            Result result = Result.INPROGRESS;
            return result;

        }
        public Result CheckReverseDiagonal()
        {
            int j = 0, resultCount = 1;            
            Result result = Result.INPROGRESS;
            return result;
        }
    }
}
