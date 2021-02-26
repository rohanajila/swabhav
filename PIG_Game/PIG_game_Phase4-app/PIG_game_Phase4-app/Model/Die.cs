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
        public int Value { get => _value; }
        public void roll()
        {
            Random random = new Random();
            _value = random.Next(1, 7);
        }

    }
}
