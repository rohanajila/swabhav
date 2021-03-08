using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern1_app.Model
{
    public class ChickenBurger:Burger
    {
        public override float price()
        {
            return 100.5f;
        }
        public override string name()
        {
            return "Chicken Burger";
        }

    }
}
