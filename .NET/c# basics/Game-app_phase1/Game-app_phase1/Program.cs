using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_app_phase1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            int UserGuess=0;
            int NoOfChances=0;
            Random _random = new Random();
            int RandomNumber = _random.Next(100);
            Console.WriteLine("**************GUESS GAME******************");            
            do
            {
                if (NoOfChances == 0)
                {
                    Console.WriteLine("\nEnter your choice: \n1.Start New Game\n2.Stop");
                }
                else
                {
                    Console.WriteLine("\nEnter your choice: \n1.Continue\n2.Stop\n3.Start New Game");
                }
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ++NoOfChances;
                        Console.WriteLine("\nEnter any number: ");
                        UserGuess = int.Parse(Console.ReadLine());
                        if (UserGuess < RandomNumber)
                        {
                            Console.WriteLine("\nyour guess is low");
                            
                        }
                        if (UserGuess > RandomNumber)
                        {
                            Console.WriteLine("\nyour guess is high");
                            
                        }
                        if (UserGuess == RandomNumber)
                        {
                            Console.WriteLine("\n\nCongratulations! Your Guess is right in " + NoOfChances + " guesses");
                            Console.WriteLine("Your Number was: " + RandomNumber + "\nGuess was:" + UserGuess);
                            choice = 2;
                            
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nYou have exited the game!");
                        break;
                    case 3:
                        RandomNumber = _random.Next(100);
                        UserGuess = 0;
                        NoOfChances = 0;
                        ++NoOfChances;
                        Console.WriteLine("\nEnter any number: ");
                        UserGuess = int.Parse(Console.ReadLine());
                        if (UserGuess < RandomNumber)
                        {
                            Console.WriteLine("\nyour guess is low");

                        }
                        if (UserGuess > RandomNumber)
                        {
                            Console.WriteLine("\nyour guess is high");

                        }
                        if (UserGuess == RandomNumber)
                        {
                            Console.WriteLine("\n\nCongratulations! Your Guess is right in " + NoOfChances + " guesses");
                            Console.WriteLine("Your Number was: " + RandomNumber + "\nGuess was:" + UserGuess);
                            choice = 2;

                        }
                        break;
                    default:
                        Console.WriteLine("\nEnter valid option!");
                        break;
                }
            } while (choice != 2);
            Console.ReadKey();
        }
    }
}
