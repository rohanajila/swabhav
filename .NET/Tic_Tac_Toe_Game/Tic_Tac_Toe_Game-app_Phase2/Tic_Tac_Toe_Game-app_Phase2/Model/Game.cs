using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game_app_Phase2.Model
{
    public class Game
    {
        private List<Player> _players = new List<Player>();
        private Board _board;
        private ResultAnalyzer _analyzeResult;
        private int CURRENT_PLAYER = 0, NEXT_PLAYER = 1;
        private int _flag = 0;

        public Game(List<Player> players,Board board,ResultAnalyzer analyzeResult)
        {
            _players = players;
            _board = board;
            _analyzeResult = analyzeResult;
        }
        public Board Board { get => _board; }
        public List<Player> Player { get => _players; }
        public bool play(int location)
        {
            try
            {
                if(Board.AddMarkToCell(GetCurrentPlayer().Mark,location))
                {
                    Board.PrintBoard();
                    if(_flag==0)
                    {
                        CURRENT_PLAYER++;
                        NEXT_PLAYER--;
                        _flag++;
                    }
                    else
                    {
                        CURRENT_PLAYER--;
                        NEXT_PLAYER++;
                        _flag--;
                    }
                    return true;
                }
            }
            catch(CellAlreadyOccupiedException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(OutOfCellException e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public Player GetCurrentPlayer()
        {
            return Player[CURRENT_PLAYER];
        }
        public Player GetNextPlayer()
        {
            return Player[NEXT_PLAYER];
        }
        public string GetStatus()
        {
            return _analyzeResult.CheckWinner();
        }
    }
}
