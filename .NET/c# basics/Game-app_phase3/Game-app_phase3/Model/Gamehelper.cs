using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_app_phase3
{
    class Gamehelper
    {
        public string getUserInput(string prompt)
        {
            string inputline;
            Console.WriteLine(prompt + " ");
            inputline = Console.ReadLine();
            return inputline;
        }
    }
}
