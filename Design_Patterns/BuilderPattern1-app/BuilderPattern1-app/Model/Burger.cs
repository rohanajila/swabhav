using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern1_app.Model
{
    public abstract class Burger:Iitem
    {
        public abstract string name();
        public IPacking packing()
        {
            return new Wrapper();
        }
        public abstract float price();
    }
}
