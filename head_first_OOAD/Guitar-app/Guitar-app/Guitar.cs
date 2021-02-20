using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar_app
{
    class Guitar
    {
        private string serialNumber;
        private string model;
        private double price;
        private GuitarSpec spec;
        public string SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public GuitarSpec Spec
        {
            get { return spec; }
            set { spec = value; }
        }
        public Guitar()
        { }
        public Guitar(string serialNumber,double price,GuitarSpec spec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = spec;
        }

    }
}
