using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern1_app.Model
{
    public interface Iitem
    {
        string name();
        IPacking packing();
        float price();
    }
}
