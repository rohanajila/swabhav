using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_app_phase3
{
    class Game
    {
        private int UserGuess;
        Random r = new Random();
        private int RandomNumber; 
        private int noOfChances=0;
        bool isGameOver;
        public Game()
        {
            RandomNumber = r.Next(100);
            isGameOver = false;
        }
        public void setUserGuess(int userguess)
        {
            UserGuess = userguess;

        }
        public string CheckUserGuess()
        {
            string guess="";
            if (UserGuess < RandomNumber)
            {
                ++noOfChances;
                guess="guess is low";

            }
            if (UserGuess > RandomNumber)
            {
                ++noOfChances;
                guess = "guess is high";

            }
            if (UserGuess == RandomNumber)
            {
                ++noOfChances;
                guess = "guess is correct";
                isGameOver = true;

            }
            return guess;

        }
        public bool CheckGameOver()
        {
            return isGameOver;
        }
        public int getNoOfChances()
        {
            return noOfChances;
        }
        public int getUserGuess()
        {
            return UserGuess;
        }
        public int getRandomNumber()
        {
            return RandomNumber;
        }

        
    }
}
