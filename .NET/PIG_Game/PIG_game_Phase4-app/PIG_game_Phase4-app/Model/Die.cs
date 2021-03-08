using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIG_game_Phase4_app.Model
{
    class Die
    {
        private int _value;

        public int Value
        {
            get { return _value; }
        }

        public void Roll()
        {
            _value = new Random().Next(1, 7);
        }

    }
}
