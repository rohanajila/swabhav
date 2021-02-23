using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar_app
{
    class Mandolin:Instrument
    {
        private MandolinSpec spec;
        public MandolinSpec getSpec()
        {
            return spec;
        }
        public Mandolin(string serialNumber, double price, MandolinSpec spec) : base(serialNumber, price, spec)
        {

        }
    }
}
