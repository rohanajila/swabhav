using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar_app
{
    abstract class Instrument
    {
        private string serialNumber;
        private double price;
        private InstrumentSpec spec;
        public string SerialNumber
        {
            get { return serialNumber; }

        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public InstrumentSpec getSpec()
        {
            return spec;
        }
        public Instrument(string serialNumber,double price,InstrumentSpec spec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = spec;
        }
        
    }
}
