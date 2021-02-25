using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIG_game_Phase3_app.Model;

namespace PIG_game_Phase3_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Game obj = new Game();
            obj.PlayGame(obj);
            Console.Read();
        }
        public static  void PrintResult(Game obj)
        {
            Console.WriteLine("SCORE: " + obj.TotalScore + "\nTurns taken : " + (obj.NoOfTurns - 1));

        }

        public static  void PrintTurnScore(Game obj)
        {
            Console.WriteLine("Score For Turn :" + obj.TurnScore);
            obj.TotalScore += obj.TurnScore;
            obj.TurnScore = 0;
            Console.WriteLine("Total score :" + obj.TotalScore);
        }

        public static void ScoreReset(Game obj)
        {
            Console.WriteLine("Die: 1 , turn score will be set to zero");
            obj.TurnScore = 0;
        }

        public static int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 7);

        }
    }
}
