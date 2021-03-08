using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern1_app.Model
{
    public class Wrapper:IPacking
    {
        public string pack()
        {
            return "Wrapper";
        }
    }
}
