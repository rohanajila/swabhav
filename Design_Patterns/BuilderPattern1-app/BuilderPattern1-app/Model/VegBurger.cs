using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern1_app.Model
{
    public class VegBurger:Burger
    {
        public override float price()
        {
            return 50.5f;
        }
        public override string name()
        {
            return "Veg Burger";
        }
    }
}
