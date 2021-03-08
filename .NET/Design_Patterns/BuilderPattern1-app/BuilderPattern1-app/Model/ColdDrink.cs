using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern1_app.Model
{
    public abstract class ColdDrink:Iitem
    {
        public abstract string name();
        public IPacking packing()
        {
            return new Bottle();
        }
        public abstract float price();

    }
}
