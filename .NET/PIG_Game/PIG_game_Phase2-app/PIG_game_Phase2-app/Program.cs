using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIG_game_Phase2_app
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayGame();          
            Console.ReadLine();
        }

        public static void PlayGame()
        {
            bool playGame = true;
            char choice;
            int turnScore = 0;
            int totalScore = 0;
            int die;
            int noOfTurns = 1;
            bool keepPlaying = true;
            while (playGame)
            {
                Console.WriteLine("\nTURN " + noOfTurns);
                noOfTurns++;
                keepPlaying = true;
                while (keepPlaying)
                {

                    if (turnScore >= 20 || totalScore >= 20)
                    {
                        keepPlaying = false;
                    }
                    else
                    {
                        Console.Write("Roll or Hold  (r/h) : ");

                        choice = char.Parse(Console.ReadLine());

                        if (choice.Equals('r'))
                        {
                            die = GenerateRandomNumber();
                            if (die != 1)
                            {
                                 Console.WriteLine("Die : " + die);
                                turnScore += die;

                            }
                            else
                            {
                                ScoreReset(ref turnScore, ref totalScore);
                                keepPlaying = false;
                            }
                        }
                        else if (choice.Equals('h'))
                        {
                            PrintTurnScore(ref turnScore, ref totalScore);
                            keepPlaying = false;
                        }
                    }
                }
                if (totalScore >= 20)
                {
                    Console.WriteLine("\nCongratulations!\nGame Over\n");
                    PrintResult(noOfTurns, totalScore);
                    playGame = false;
                }               

            }
        }
        
        public static void PrintResult(int noOfTurns,int totalScore)
        {
            Console.WriteLine("SCORE: "+totalScore+"\nTurns taken : "+(noOfTurns-1));

        }

        public static void PrintTurnScore(ref int turnScore, ref int totalScore)
        {
            Console.WriteLine("Score For Turn :"+turnScore);
            totalScore += turnScore;
            turnScore = 0;
            Console.WriteLine("Total score :"+totalScore);
        }

        public static void ScoreReset(ref int turnScore, ref int totalScore)
        {
            Console.WriteLine("Die: 1 , turn score will be set to zero");        
            turnScore = 0;
        }

        public static int GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 7);
            
        }
    }
}
