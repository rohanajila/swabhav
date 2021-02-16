using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Man_app
{
    class Boy:Man
    {
        public override void Plays()
        {
            Console.WriteLine("Boy is playing");
        }
        public void Eats()
        {
            Console.WriteLine("Boy is eating");
        }
    }
}
