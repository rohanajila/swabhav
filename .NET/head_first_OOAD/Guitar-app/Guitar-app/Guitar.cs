using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar_app
{
    class Guitar: Instrument
    {
        
        private GuitarSpec spec;  
        
        public GuitarSpec Spec
        {
            get { return spec; }
           
        }
        public Guitar(string serialNumber,double price,GuitarSpec spec):base(serialNumber,price,spec)
        {

        }
       

    }
}
