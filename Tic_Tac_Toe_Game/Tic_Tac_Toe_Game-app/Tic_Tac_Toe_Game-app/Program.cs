using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game_app
{
    class Program
    {
        static char[] _arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int _player = 1;
        static int _choice;
        static int _flag = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("First to play will be 'X'");
            RunGame();
            Console.Read();
        }
        public static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", _arr[1], _arr[2], _arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", _arr[4], _arr[5], _arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", _arr[7], _arr[8], _arr[9]);
            Console.WriteLine("     |     |      ");

        }
        public static int CheckWin()
        {
            if (_arr[1] == _arr[2] && _arr[2] == _arr[3])
            {
                return 1;
            }
            else if (_arr[4] == _arr[5] && _arr[5] == _arr[6])
            {
                return 1;
            }
            else if (_arr[7] == _arr[8] && _arr[8] == _arr[9])
            {
                return 1;
            }
            else if (_arr[1] == _arr[4] && _arr[4] == _arr[7])
            {
                return 1;
            }
            else if (_arr[2] == _arr[5] && _arr[5] == _arr[8])
            {
                return 1;
            }
            else if (_arr[3] == _arr[6] && _arr[6] == _arr[9])
            {
                return 1;
            }
            else if (_arr[1] == _arr[5] && _arr[5] == _arr[9])
            {
                return 1;
            }
            else if (_arr[3] == _arr[5] && _arr[5] == _arr[7])
            {
                return 1;
            }
            else if (_arr[1] != '1' && _arr[2] != '2' && _arr[3] != '3' && _arr[4] != '4' && _arr[5] != '5' && _arr[6] != '6' && _arr[7] != '7' && _arr[8] != '8' && _arr[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public static void RunGame()
        {
            do
            {              
                
                Console.WriteLine("\n");
                if (_player % 2 == 0)
                {
                    Console.WriteLine("O's chance");
                }
                else
                {
                    Console.WriteLine("X's chance");
                }
                Console.WriteLine("\n");
                Board();
                _choice = int.Parse(Console.ReadLine());
                if (_arr[_choice] != 'X' && _arr[_choice] != 'O')
                {
                    if (_player % 2 == 0)
                    {
                        _arr[_choice] = 'O';
                        _player++;
                    }
                    else
                    {
                        _arr[_choice] = 'X';
                        _player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", _choice, _arr[_choice]);
                    Console.WriteLine("\n");
                }
                _flag = CheckWin();
            } while (_flag != 1 && _flag != -1);
            
            Board();
            if (_flag == 1)
            {
                Console.WriteLine("Player {0} has won", (_player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }
    
    }
}


