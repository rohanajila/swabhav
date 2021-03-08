using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIG_game_Phase3_app.Model
{
    class Game
    {
        private int _turnScore;
        private int _totalScore;
        private int _die;
        private int _noOfTurns;

        public int TurnScore { get => _turnScore; set => _turnScore = value; }
        public int TotalScore { get => _totalScore; set => _totalScore = value; }
        public int Die { get => _die; set => _die = value; }
        public int NoOfTurns { get => _noOfTurns; set => _noOfTurns = value; }

        public  void PlayGame(Game obj)
        {
            bool playGame = true;
            char choice;
            obj.TurnScore = 0;
            obj.TotalScore = 0;
            obj.NoOfTurns = 1;
            bool keepPlaying = true;
            while (playGame)
            {
                Console.WriteLine("\nTURN " + obj.NoOfTurns);
                obj.NoOfTurns++;
                keepPlaying = true;
                while (keepPlaying)
                {

                    if (obj.TurnScore >= 20 || obj.TotalScore >= 20)
                    {
                        keepPlaying = false;
                    }
                    else
                    {
                        Console.Write("Roll or Hold  (r/h) : ");

                        choice = char.Parse(Console.ReadLine());

                        if (choice.Equals('r'))
                        {
                            obj.Die = Program.GenerateRandomNumber();
                            if (obj.Die != 1)
                            {
                                Console.WriteLine("Die : " + obj.Die);
                                obj.TurnScore += obj.Die;

                            }
                            else
                            {
                                Program.ScoreReset(obj);
                                keepPlaying = false;
                            }
                        }
                        else if (choice.Equals('h'))
                        {
                            Program.PrintTurnScore(obj);
                            keepPlaying = false;
                        }
                    }
                }
                if (obj.TotalScore >= 20)
                {
                    Console.WriteLine("\nCongratulations!\nGame Over\n");
                    Program.PrintResult(obj);
                    playGame = false;
                }

            }
        }

       
    }
}
