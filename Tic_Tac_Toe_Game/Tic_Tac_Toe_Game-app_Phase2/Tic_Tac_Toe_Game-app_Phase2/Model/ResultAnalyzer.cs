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

        }
        public Result CheckColumn()
        {

        }
        public Result CheckDiagonal()
        {

        }
        public Result CheckReverseDiagonal()
        {

        }
    }
}
