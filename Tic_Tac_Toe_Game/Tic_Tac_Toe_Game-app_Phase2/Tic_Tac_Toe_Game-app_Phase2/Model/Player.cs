using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_Game_app_Phase2.Model
{
    public class Player
    {
        private string _name;
        private Mark _mark;

        public Player(string name, Mark mark)
        {
            _name = name;
            _mark = mark;
        }
        public string Name { get => _name; }
        public Mark Mark { get => _mark; }
    }
}
