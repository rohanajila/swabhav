using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe_Game_app_Phase2.Model;

namespace Tic_Tac_Toe_Game_app_Phase2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            string p;
            int location;
            Console.WriteLine("Enter the board size: ");
            int size = int.Parse(Console.ReadLine());
            Board board = new Board(size);
            board.CreateBoard();
            Game game = new Game(players, board, new ResultAnalyzer(board));
            string name = GetFirstDataFromUser(game, players);
            while(true)
            {
                Console.WriteLine(name + " Enter cell number: ");
                location = int.Parse(Console.ReadLine());
                if(game.play(location))
                {
                    break;
                }
            }
            name = GetFirstDataFromUser(game, players);
            while (true)
            {
                Console.WriteLine(name + " Enter cell number: ");
                location = int.Parse(Console.ReadLine());
                if (game.play(location))
                {
                    break;
                }
            }
            while(game.GetStatus().Equals("INPROGRESS"))
            {
                Console.WriteLine(game.GetCurrentPlayer().Name + " Enter cell number: ");
                location = int.Parse(Console.ReadLine());
                game.play(location);
            }
            if(game.GetStatus().Equals("WIN"))
            {
                Console.WriteLine(game.GetNextPlayer().Name + " is WINNER!!");
            }
            else if(game.GetStatus().Equals("DRAW"))
            {
                Console.WriteLine("It's a DRAW...");
            }
            Console.ReadKey();
        }
        public static string GetFirstDataFromUser(Game game,List<Player> players)
        {
            Player player;
            string p;
            Console.WriteLine("Enter your name: ");
            p = Console.ReadLine();
            if(players.Count==0)
            {
                player = new Player(p, Mark.X);
            }
            else
            {
                player = new Player(p, Mark.O);
            }
            players.Add(player);
            return p;
        }

    }
    public enum Mark
    {
        X,O
    }
    public enum Result
    {
        WIN,DRAW,INPROGRESS
    }
}
