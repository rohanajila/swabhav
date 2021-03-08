using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5_1
{
    class SimpleDotComTestDrive
    {
        static void Main(string[] args)
        {
        }
    }
    public class SimpleDotCom
    {
        int[] locationCells;
        int numOfHits = 0;
        public void setLocationCells(int[] locs)
        {
            locationCells = locs;

        }
        public string checkYourself(string stringGuess)
        {
            int guess = int.Parse(stringGuess);
            string result = "miss";
            for(int cell:locationCells)
            {
                if(guess==cell)
                {
                    result = "hit";
                    numOfHits++;
                    break;

                }
                if (numOfHits == locationCells.Length)
                    result = "kill";
            }
            Console.WriteLine(result);
            return result;
        }
    }
