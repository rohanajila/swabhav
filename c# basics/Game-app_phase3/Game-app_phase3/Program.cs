using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_app_phase3
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            Game obj = new Game();
            Console.WriteLine("**************GUESS GAME******************");
            do
            {
                Console.WriteLine("\nEnter your choice: \n1.Play\n2.Stop");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter a number");
                        obj.setUserGuess(int.Parse(Console.ReadLine()));
                        Console.WriteLine(obj.CheckUserGuess());
                        if (obj.CheckGameOver())
                        {
                            Console.WriteLine("\nCongratulations game over!\nNo of guess: " + obj.getNoOfChances());
                            Console.WriteLine("Number: " + obj.getRandomNumber());
                            Console.WriteLine("Your Guess: " + obj.getUserGuess());
                            choice = 2;
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nYou have exited the game!");
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;                      

                }
            } while (choice != 2);
            Console.ReadKey();
        }
    }
}
