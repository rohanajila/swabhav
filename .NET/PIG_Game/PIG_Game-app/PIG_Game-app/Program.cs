using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIG_Game_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playGame = true;           
            char choice;
            int turnScore = 0;
            int totalScore = 0;
            int die;
            int noOfTurns = 1;
            bool keepPlaying = true;
            while (playGame)
            {
                
                    Console.WriteLine("\nTURN "+ noOfTurns++);
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
                                die = random.Next(1,7);
                                if (die != 1)
                                {
                                    Console.WriteLine("Die : "+die);
                                    turnScore += die;
                                }
                                else
                                {
                                    Console.WriteLine("Die :1 , your turn score will be set to zero");
                                    Console.WriteLine("Total Score: " + totalScore);
                                    Console.WriteLine("\nTURN " + noOfTurns);
                                    noOfTurns++;
                                    turnScore = 0;
                                }
                            }
                            else if (choice.Equals('h'))
                            {
                                Console.WriteLine("Score For Turn :"+turnScore);
                                totalScore += turnScore;
                                Console.WriteLine("Total Score: " + totalScore);                               
                                turnScore = 0;                                
                                keepPlaying = false;
                            }
                        }
                    }
                    if (totalScore >= 20)
                    {
                        Console.WriteLine("\nCongratulations!\nGame Over\n");
                        Console.WriteLine("Total score: "+totalScore+" has been reached\nTurns taken : "+(noOfTurns-1));
                        playGame = false;
                    }

                

            }
            Console.ReadLine();
        }
        
    }
}
